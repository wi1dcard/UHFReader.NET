using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace UHFReader.Base
{
	//-------
	// Reference: https://blogs.msdn.microsoft.com/jmstall/2007/01/06/type-safe-managed-wrappers-for-kernel32getprocaddress/
	//-------

	// See http://msdn.microsoft.com/msdnmag/issues/05/10/Reliability/ for more about safe handles.
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		private SafeLibraryHandle() : base(true) { }
		protected override bool ReleaseHandle()
		{
			return LoadMemLibrary.FreeMemLibrary(handle);
		}
	}

	static class LoadMemLibrary
	{
		const string Kernel = "LoadMemLibrary.dll";
		[DllImport(Kernel, CharSet = CharSet.Ansi, BestFitMapping = false, SetLastError = true)]
		public static extern SafeLibraryHandle LoadMemLibraryByFilename(String fileName);

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[DllImport(Kernel, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeMemLibrary(IntPtr hModule);

		[DllImport(Kernel)]
		public static extern IntPtr GetMemProcAddress(SafeLibraryHandle hModule, String procname);
	}

	/// <summary>
	/// Utility class to wrap an unmanaged DLL and be responsible for freeing it.
	/// </summary>
	/// <remarks>This is a managed wrapper over the native LoadLibrary, GetProcAddress, and
	/// FreeLibrary calls.
	/// </example>
	public class MemLibrary : IDisposable
	{
		// Unmanaged resource. CLR will ensure SafeHandles get freed, without requiring a finalizer on this class.
		SafeLibraryHandle m_hLibrary;

		/// <summary>
		/// Constructor to load a dll and be responible for freeing it.
		/// </summary>
		/// <param name="fileName">full path name of dll to load</param>
		/// <exception cref="System.IO.FileNotFound">if fileName can't be found</exception>
		/// <remarks>Throws exceptions on failure. Most common failure would be file-not-found, or
		/// that the file is not a  loadable image.</remarks>
		public MemLibrary(string fileName)
		{
			m_hLibrary = LoadMemLibrary.LoadMemLibraryByFilename(fileName);
			if (m_hLibrary.IsInvalid)
			{
				int hr = Marshal.GetHRForLastWin32Error();
				Marshal.ThrowExceptionForHR(hr);
			}
		}

		/// <summary>
		/// Dynamically lookup a function in the dll via kernel32!GetProcAddress.
		/// </summary>
		/// <param name="functionName">raw name of the function in the export table.</param>
		/// <returns>null if function is not found. Else a delegate to the unmanaged function.
		/// </returns>
		/// <remarks>GetProcAddress results are valid as long as the dll is not yet unloaded. This
		/// is very very dangerous to use since you need to ensure that the dll is not unloaded
		/// until after you're done with any objects implemented by the dll. For example, if you
		/// get a delegate that then gets an IUnknown implemented by this dll,
		/// you can not dispose this library until that IUnknown is collected. Else, you may free
		/// the library and then the CLR may call release on that IUnknown and it will crash.</remarks>
		public TDelegate GetUnmanagedFunction<TDelegate>(string functionName) where TDelegate : class
		{
			IntPtr p = LoadMemLibrary.GetMemProcAddress(m_hLibrary, functionName);

			// Failure is a common case, especially for adaptive code.
			if (p == IntPtr.Zero)
			{
				return null;
			}
			Delegate function = Marshal.GetDelegateForFunctionPointer(p, typeof(TDelegate));

			// Ideally, we'd just make the constraint on TDelegate be
			// System.Delegate, but compiler error CS0702 (constrained can't be System.Delegate)
			// prevents that. So we make the constraint system.object and do the cast from object-->TDelegate.
			object o = function;

			return (TDelegate)o;
		}

		/// <summary>
		/// Call FreeLibrary on the unmanaged dll. All function pointers
		/// handed out from this class become invalid after this.
		/// </summary>
		/// <remarks>This is very dangerous because it suddenly invalidate
		/// everything retrieved from this dll. This includes any functions
		/// handed out via GetProcAddress, and potentially any objects returned
		/// from those functions (which may have an implemention in the
		/// dll).
		/// </remarks>
		public void Dispose()
		{
			if (!m_hLibrary.IsClosed)
			{
				m_hLibrary.Close();
			}
		}
	}
}