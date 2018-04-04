using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHFReader.Base
{
	public class UHFReaderLib
	{
		protected MemLibrary libInstance;

		public UHFReaderLib(string libPath)
		{
			libInstance = new MemLibrary(libPath);
		}

		public UHFReaderDelegates.OpenNetPort OpenNetPort
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.OpenNetPort>("OpenNetPort");
			}
		}

		public UHFReaderDelegates.CloseNetPort CloseNetPort
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.CloseNetPort>("CloseNetPort");
			}
		}

		public UHFReaderDelegates.OpenComPort OpenComPort
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.OpenComPort>("OpenComPort");
			}
		}

		public UHFReaderDelegates.CloseComPort CloseComPort
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.CloseComPort>("CloseComPort");
			}
		}

		public UHFReaderDelegates.AutoOpenComPort AutoOpenComPort
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.AutoOpenComPort>("AutoOpenComPort");
			}
		}

		public UHFReaderDelegates.CloseSpecComPort CloseSpecComPort
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.CloseSpecComPort>("CloseSpecComPort");
			}
		}

		public UHFReaderDelegates.GetReaderInformation GetReaderInformation
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.GetReaderInformation>("GetReaderInformation");
			}
		}

		public UHFReaderDelegates.WriteComAdr WriteComAdr
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteComAdr>("WriteComAdr");
			}
		}

		public UHFReaderDelegates.SetPowerDbm SetPowerDbm
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetPowerDbm>("SetPowerDbm");
			}
		}

		public UHFReaderDelegates.Writedfre Writedfre
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.Writedfre>("Writedfre");
			}
		}

		public UHFReaderDelegates.Writebaud Writebaud
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.Writebaud>("Writebaud");
			}
		}

		public UHFReaderDelegates.WriteScanTime WriteScanTime
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteScanTime>("WriteScanTime");
			}
		}

		public UHFReaderDelegates.InSelfTestMode InSelfTestMode
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.InSelfTestMode>("InSelfTestMode");
			}
		}

		public UHFReaderDelegates.RfOutput RfOutput
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.RfOutput>("RfOutput");
			}
		}

		public UHFReaderDelegates.SetPWM SetPWM
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetPWM>("SetPWM");
			}
		}

		public UHFReaderDelegates.ReadPWM ReadPWM
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.ReadPWM>("ReadPWM");
			}
		}

		public UHFReaderDelegates.SetPowerParameter SetPowerParameter
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetPowerParameter>("SetPowerParameter");
			}
		}

		public UHFReaderDelegates.Getpower Getpower
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.Getpower>("Getpower");
			}
		}

		public UHFReaderDelegates.CheckPowerParameter CheckPowerParameter
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.CheckPowerParameter>("CheckPowerParameter");
			}
		}

		public UHFReaderDelegates.GetStartInformation GetStartInformation
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.GetStartInformation>("GetStartInformation");
			}
		}

		public UHFReaderDelegates.SolidifyPWMandPowerlist SolidifyPWMandPowerlist
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SolidifyPWMandPowerlist>("SolidifyPWMandPowerlist");
			}
		}

		public UHFReaderDelegates.Inventory_G2 Inventory_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.Inventory_G2>("Inventory_G2");
			}
		}

		public UHFReaderDelegates.ReadCard_G2 ReadCard_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.ReadCard_G2>("ReadCard_G2");
			}
		}

		public UHFReaderDelegates.WriteCard_G2 WriteCard_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteCard_G2>("WriteCard_G2");
			}
		}

		public UHFReaderDelegates.WriteBlock_G2 WriteBlock_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteBlock_G2>("WriteBlock_G2");
			}
		}

		public UHFReaderDelegates.EraseCard_G2 EraseCard_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.EraseCard_G2>("EraseCard_G2");
			}
		}

		public UHFReaderDelegates.SetCardProtect_G2 SetCardProtect_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetCardProtect_G2>("SetCardProtect_G2");
			}
		}

		public UHFReaderDelegates.DestroyCard_G2 DestroyCard_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.DestroyCard_G2>("DestroyCard_G2");
			}
		}

		public UHFReaderDelegates.WriteEPC_G2 WriteEPC_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteEPC_G2>("WriteEPC_G2");
			}
		}

		public UHFReaderDelegates.SetReadProtect_G2 SetReadProtect_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetReadProtect_G2>("SetReadProtect_G2");
			}
		}

		public UHFReaderDelegates.SetMultiReadProtect_G2 SetMultiReadProtect_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetMultiReadProtect_G2>("SetMultiReadProtect_G2");
			}
		}

		public UHFReaderDelegates.RemoveReadProtect_G2 RemoveReadProtect_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.RemoveReadProtect_G2>("RemoveReadProtect_G2");
			}
		}

		public UHFReaderDelegates.CheckReadProtected_G2 CheckReadProtected_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.CheckReadProtected_G2>("CheckReadProtected_G2");
			}
		}

		public UHFReaderDelegates.SetEASAlarm_G2 SetEASAlarm_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetEASAlarm_G2>("SetEASAlarm_G2");
			}
		}

		public UHFReaderDelegates.CheckEASAlarm_G2 CheckEASAlarm_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.CheckEASAlarm_G2>("CheckEASAlarm_G2");
			}
		}

		public UHFReaderDelegates.LockUserBlock_G2 LockUserBlock_G2
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.LockUserBlock_G2>("LockUserBlock_G2");
			}
		}

		public UHFReaderDelegates.Inventory_6B Inventory_6B
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.Inventory_6B>("Inventory_6B");
			}
		}

		public UHFReaderDelegates.Inventory2_6B Inventory2_6B
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.Inventory2_6B>("Inventory2_6B");
			}
		}

		public UHFReaderDelegates.ReadCard_6B ReadCard_6B
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.ReadCard_6B>("ReadCard_6B");
			}
		}

		public UHFReaderDelegates.WriteCard_6B WriteCard_6B
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteCard_6B>("WriteCard_6B");
			}
		}

		public UHFReaderDelegates.LockByte_6B LockByte_6B
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.LockByte_6B>("LockByte_6B");
			}
		}

		public UHFReaderDelegates.CheckLock_6B CheckLock_6B
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.CheckLock_6B>("CheckLock_6B");
			}
		}

		public UHFReaderDelegates.SetWGParameter SetWGParameter
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetWGParameter>("SetWGParameter");
			}
		}

		public UHFReaderDelegates.SetWorkMode SetWorkMode
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetWorkMode>("SetWorkMode");
			}
		}

		public UHFReaderDelegates.GetWorkModeParameter GetWorkModeParameter
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.GetWorkModeParameter>("GetWorkModeParameter");
			}
		}

		public UHFReaderDelegates.ReadActiveModeData ReadActiveModeData
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.ReadActiveModeData>("ReadActiveModeData");
			}
		}

		public UHFReaderDelegates.SetAccuracy SetAccuracy
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetAccuracy>("SetAccuracy");
			}
		}

		public UHFReaderDelegates.SetOffsetTime SetOffsetTime
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetOffsetTime>("SetOffsetTime");
			}
		}

		public UHFReaderDelegates.SetFhssMode SetFhssMode
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetFhssMode>("SetFhssMode");
			}
		}

		public UHFReaderDelegates.GetFhssMode GetFhssMode
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.GetFhssMode>("GetFhssMode");
			}
		}

		public UHFReaderDelegates.SetTriggerTime SetTriggerTime
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetTriggerTime>("SetTriggerTime");
			}
		}

		public UHFReaderDelegates.BuzzerAndLEDControl BuzzerAndLEDControl
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.BuzzerAndLEDControl>("BuzzerAndLEDControl");
			}
		}

		public UHFReaderDelegates.SetRelay SetRelay
		{
			get
			{
				return libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetRelay>("SetRelay");
			}
		}

	}
}
