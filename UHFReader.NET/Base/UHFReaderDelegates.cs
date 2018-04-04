using System;
using System.Runtime.InteropServices;

namespace UHFReader.Base
{
	public static class UHFReaderDelegates
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int OpenNetPort(int Port, string IPaddr, ref byte ComAddr, ref int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int CloseNetPort(int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int OpenComPort(int Port, ref byte ComAddr, byte Baud, ref int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int CloseComPort();

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int AutoOpenComPort(ref int Port, ref byte ComAddr, byte Baud, ref int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int CloseSpecComPort(int Port);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int GetReaderInformation(ref byte ConAddr, byte[] VersionInfo, ref byte ReaderType, byte[] TrType, ref byte dmaxfre, ref byte dminfre, ref byte powerdBm, ref byte ScanTime, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int WriteComAdr(ref byte ConAddr, ref byte ComAdrData, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetPowerDbm(ref byte ConAddr, byte powerDbm, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int Writedfre(ref byte ConAddr, ref byte dmaxfre, ref byte dminfre, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int Writebaud(ref byte ConAddr, ref byte baud, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int WriteScanTime(ref byte ConAddr, ref byte ScanTime, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int InSelfTestMode(ref byte ConAddr, bool IsSelfTestMode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int RfOutput(ref byte ConAddr, byte onoff, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetPWM(ref byte ConAddr, byte PWM, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int ReadPWM(ref byte ConAddr, ref byte PWM, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetPowerParameter(ref byte ConAddr, ref byte power, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int Getpower(ref byte ConAddr, ref byte power, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int CheckPowerParameter(ref byte ConAddr, ref int code, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int GetStartInformation(ref byte ConAddr, ref byte ADF7020E, ref byte FreE, ref byte addrE, ref byte scnE, ref byte xpwrE, ref byte pwmE, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SolidifyPWMandPowerlist(ref byte ConAddr, byte[] dBm_list, ref int code, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int Inventory_G2(ref byte ConAddr, byte AdrTID, byte LenTID, byte TIDFlag, byte[] EPClenandEPC, ref int Totallen, ref int CardNum, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int ReadCard_G2(ref byte ConAddr, byte[] EPC, byte Mem, byte WordPtr, byte Num, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte[] Data, byte EPClength, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int WriteCard_G2(ref byte ConAddr, byte[] EPC, byte Mem, byte WordPtr, byte Writedatalen, byte[] Writedata, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, int WrittenDataNum, byte EPClength, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int WriteBlock_G2(ref byte ConAddr, byte[] EPC, byte Mem, byte WordPtr, byte Writedatalen, byte[] Writedata, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, int WrittenDataNum, byte EPClength, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int EraseCard_G2(ref byte ConAddr, byte[] EPC, byte Mem, byte WordPtr, byte Num, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EPClength, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetCardProtect_G2(ref byte ConAddr, byte[] EPC, byte select, byte setprotect, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EPClength, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int DestroyCard_G2(ref byte ConAddr, byte[] EPC, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EPClength, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int WriteEPC_G2(ref byte ConAddr, byte[] Password, byte[] WriteEPC, byte WriteEPClen, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetReadProtect_G2(ref byte ConAddr, byte[] EPC, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EPClength, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetMultiReadProtect_G2(ref byte ConAddr, byte[] Password, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int RemoveReadProtect_G2(ref byte ConAddr, byte[] Password, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int CheckReadProtected_G2(ref byte ConAddr, ref byte readpro, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetEASAlarm_G2(ref byte ConAddr, byte[] EPC, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EAS, byte EPClength, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int CheckEASAlarm_G2(ref byte ConAddr, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int LockUserBlock_G2(ref byte ConAddr, byte[] EPC, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte BlockNum, byte EPClength, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int Inventory_6B(ref byte ConAddr, byte[] ID_6B, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int Inventory2_6B(ref byte ConAddr, byte Condition, byte StartAddress, byte mask, byte[] ConditionContent, byte[] ID_6B, ref int Cardnum, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int ReadCard_6B(ref byte ConAddr, byte[] ID_6B, byte StartAddress, byte Num, byte[] Data, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int WriteCard_6B(ref byte ConAddr, byte[] ID_6B, byte StartAddress, byte[] Writedata, byte Writedatalen, ref int writtenbyte, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int LockByte_6B(ref byte ConAddr, byte[] ID_6B, byte Address, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int CheckLock_6B(ref byte ConAddr, byte[] ID_6B, byte Address, ref byte ReLockState, ref int errorcode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetWGParameter(ref byte ConAddr, byte Wg_mode, byte Wg_Data_Inteval, byte Wg_Pulse_Width, byte Wg_Pulse_Inteval, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetWorkMode(ref byte ConAddr, byte[] Parameter, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int GetWorkModeParameter(ref byte ConAddr, byte[] Parameter, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int ReadActiveModeData(byte[] ModeData, ref int Datalength, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetAccuracy(ref byte ConAddr, byte Accuracy, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetOffsetTime(ref byte ConAddr, byte OffsetTime, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetFhssMode(ref byte ConAddr, byte FhssMode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int GetFhssMode(ref byte ConAddr, ref byte FhssMode, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetTriggerTime(ref byte ConAddr, ref byte TriggerTime, int PortHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int BuzzerAndLEDControl(ref byte ConAddr, byte AvtiveTime, byte SilentTime, byte Times, int FrmHandle);

		
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate int SetRelay(ref byte ConAddr, byte RelayStatus, int PortHandle);
		
	}
}
