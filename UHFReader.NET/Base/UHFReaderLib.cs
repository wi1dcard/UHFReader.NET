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

			this.OpenNetPort = libInstance.GetUnmanagedFunction<UHFReaderDelegates.OpenNetPort>("OpenNetPort");
			this.CloseNetPort = libInstance.GetUnmanagedFunction<UHFReaderDelegates.CloseNetPort>("CloseNetPort");
			this.OpenComPort = libInstance.GetUnmanagedFunction<UHFReaderDelegates.OpenComPort>("OpenComPort");
			this.CloseComPort = libInstance.GetUnmanagedFunction<UHFReaderDelegates.CloseComPort>("CloseComPort");
			this.AutoOpenComPort = libInstance.GetUnmanagedFunction<UHFReaderDelegates.AutoOpenComPort>("AutoOpenComPort");
			this.CloseSpecComPort = libInstance.GetUnmanagedFunction<UHFReaderDelegates.CloseSpecComPort>("CloseSpecComPort");
			this.GetReaderInformation = libInstance.GetUnmanagedFunction<UHFReaderDelegates.GetReaderInformation>("GetReaderInformation");
			this.WriteComAdr = libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteComAdr>("WriteComAdr");
			this.SetPowerDbm = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetPowerDbm>("SetPowerDbm");
			this.Writedfre = libInstance.GetUnmanagedFunction<UHFReaderDelegates.Writedfre>("Writedfre");
			this.Writebaud = libInstance.GetUnmanagedFunction<UHFReaderDelegates.Writebaud>("Writebaud");
			this.WriteScanTime = libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteScanTime>("WriteScanTime");
			this.InSelfTestMode = libInstance.GetUnmanagedFunction<UHFReaderDelegates.InSelfTestMode>("InSelfTestMode");
			this.RfOutput = libInstance.GetUnmanagedFunction<UHFReaderDelegates.RfOutput>("RfOutput");
			this.SetPWM = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetPWM>("SetPWM");
			this.ReadPWM = libInstance.GetUnmanagedFunction<UHFReaderDelegates.ReadPWM>("ReadPWM");
			this.SetPowerParameter = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetPowerParameter>("SetPowerParameter");
			this.Getpower = libInstance.GetUnmanagedFunction<UHFReaderDelegates.Getpower>("Getpower");
			this.CheckPowerParameter = libInstance.GetUnmanagedFunction<UHFReaderDelegates.CheckPowerParameter>("CheckPowerParameter");
			this.GetStartInformation = libInstance.GetUnmanagedFunction<UHFReaderDelegates.GetStartInformation>("GetStartInformation");
			this.SolidifyPWMandPowerlist = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SolidifyPWMandPowerlist>("SolidifyPWMandPowerlist");
			this.Inventory_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.Inventory_G2>("Inventory_G2");
			this.ReadCard_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.ReadCard_G2>("ReadCard_G2");
			this.WriteCard_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteCard_G2>("WriteCard_G2");
			this.WriteBlock_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteBlock_G2>("WriteBlock_G2");
			this.EraseCard_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.EraseCard_G2>("EraseCard_G2");
			this.SetCardProtect_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetCardProtect_G2>("SetCardProtect_G2");
			this.DestroyCard_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.DestroyCard_G2>("DestroyCard_G2");
			this.WriteEPC_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteEPC_G2>("WriteEPC_G2");
			this.SetReadProtect_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetReadProtect_G2>("SetReadProtect_G2");
			this.SetMultiReadProtect_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetMultiReadProtect_G2>("SetMultiReadProtect_G2");
			this.RemoveReadProtect_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.RemoveReadProtect_G2>("RemoveReadProtect_G2");
			this.CheckReadProtected_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.CheckReadProtected_G2>("CheckReadProtected_G2");
			this.SetEASAlarm_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetEASAlarm_G2>("SetEASAlarm_G2");
			this.CheckEASAlarm_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.CheckEASAlarm_G2>("CheckEASAlarm_G2");
			this.LockUserBlock_G2 = libInstance.GetUnmanagedFunction<UHFReaderDelegates.LockUserBlock_G2>("LockUserBlock_G2");
			this.Inventory_6B = libInstance.GetUnmanagedFunction<UHFReaderDelegates.Inventory_6B>("Inventory_6B");
			this.Inventory2_6B = libInstance.GetUnmanagedFunction<UHFReaderDelegates.Inventory2_6B>("Inventory2_6B");
			this.ReadCard_6B = libInstance.GetUnmanagedFunction<UHFReaderDelegates.ReadCard_6B>("ReadCard_6B");
			this.WriteCard_6B = libInstance.GetUnmanagedFunction<UHFReaderDelegates.WriteCard_6B>("WriteCard_6B");
			this.LockByte_6B = libInstance.GetUnmanagedFunction<UHFReaderDelegates.LockByte_6B>("LockByte_6B");
			this.CheckLock_6B = libInstance.GetUnmanagedFunction<UHFReaderDelegates.CheckLock_6B>("CheckLock_6B");
			this.SetWGParameter = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetWGParameter>("SetWGParameter");
			this.SetWorkMode = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetWorkMode>("SetWorkMode");
			this.GetWorkModeParameter = libInstance.GetUnmanagedFunction<UHFReaderDelegates.GetWorkModeParameter>("GetWorkModeParameter");
			this.ReadActiveModeData = libInstance.GetUnmanagedFunction<UHFReaderDelegates.ReadActiveModeData>("ReadActiveModeData");
			this.SetAccuracy = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetAccuracy>("SetAccuracy");
			this.SetOffsetTime = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetOffsetTime>("SetOffsetTime");
			this.SetFhssMode = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetFhssMode>("SetFhssMode");
			this.GetFhssMode = libInstance.GetUnmanagedFunction<UHFReaderDelegates.GetFhssMode>("GetFhssMode");
			this.SetTriggerTime = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetTriggerTime>("SetTriggerTime");
			this.BuzzerAndLEDControl = libInstance.GetUnmanagedFunction<UHFReaderDelegates.BuzzerAndLEDControl>("BuzzerAndLEDControl");
			this.SetRelay = libInstance.GetUnmanagedFunction<UHFReaderDelegates.SetRelay>("SetRelay");
		}

		public UHFReaderDelegates.OpenNetPort OpenNetPort
		{
			get; protected set;
		}

		public UHFReaderDelegates.CloseNetPort CloseNetPort
		{
			get; protected set;
		}

		public UHFReaderDelegates.OpenComPort OpenComPort
		{
			get; protected set;
		}

		public UHFReaderDelegates.CloseComPort CloseComPort
		{
			get; protected set;
		}

		public UHFReaderDelegates.AutoOpenComPort AutoOpenComPort
		{
			get; protected set;
		}

		public UHFReaderDelegates.CloseSpecComPort CloseSpecComPort
		{
			get; protected set;
		}

		public UHFReaderDelegates.GetReaderInformation GetReaderInformation
		{
			get; protected set;
		}

		public UHFReaderDelegates.WriteComAdr WriteComAdr
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetPowerDbm SetPowerDbm
		{
			get; protected set;
		}

		public UHFReaderDelegates.Writedfre Writedfre
		{
			get; protected set;
		}

		public UHFReaderDelegates.Writebaud Writebaud
		{
			get; protected set;
		}

		public UHFReaderDelegates.WriteScanTime WriteScanTime
		{
			get; protected set;
		}

		public UHFReaderDelegates.InSelfTestMode InSelfTestMode
		{
			get; protected set;
		}

		public UHFReaderDelegates.RfOutput RfOutput
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetPWM SetPWM
		{
			get; protected set;
		}

		public UHFReaderDelegates.ReadPWM ReadPWM
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetPowerParameter SetPowerParameter
		{
			get; protected set;
		}

		public UHFReaderDelegates.Getpower Getpower
		{
			get; protected set;
		}

		public UHFReaderDelegates.CheckPowerParameter CheckPowerParameter
		{
			get; protected set;
		}

		public UHFReaderDelegates.GetStartInformation GetStartInformation
		{
			get; protected set;
		}

		public UHFReaderDelegates.SolidifyPWMandPowerlist SolidifyPWMandPowerlist
		{
			get; protected set;
		}

		public UHFReaderDelegates.Inventory_G2 Inventory_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.ReadCard_G2 ReadCard_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.WriteCard_G2 WriteCard_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.WriteBlock_G2 WriteBlock_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.EraseCard_G2 EraseCard_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetCardProtect_G2 SetCardProtect_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.DestroyCard_G2 DestroyCard_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.WriteEPC_G2 WriteEPC_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetReadProtect_G2 SetReadProtect_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetMultiReadProtect_G2 SetMultiReadProtect_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.RemoveReadProtect_G2 RemoveReadProtect_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.CheckReadProtected_G2 CheckReadProtected_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetEASAlarm_G2 SetEASAlarm_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.CheckEASAlarm_G2 CheckEASAlarm_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.LockUserBlock_G2 LockUserBlock_G2
		{
			get; protected set;
		}

		public UHFReaderDelegates.Inventory_6B Inventory_6B
		{
			get; protected set;
		}

		public UHFReaderDelegates.Inventory2_6B Inventory2_6B
		{
			get; protected set;
		}

		public UHFReaderDelegates.ReadCard_6B ReadCard_6B
		{
			get; protected set;
		}

		public UHFReaderDelegates.WriteCard_6B WriteCard_6B
		{
			get; protected set;
		}

		public UHFReaderDelegates.LockByte_6B LockByte_6B
		{
			get; protected set;
		}

		public UHFReaderDelegates.CheckLock_6B CheckLock_6B
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetWGParameter SetWGParameter
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetWorkMode SetWorkMode
		{
			get; protected set;
		}

		public UHFReaderDelegates.GetWorkModeParameter GetWorkModeParameter
		{
			get; protected set;
		}

		public UHFReaderDelegates.ReadActiveModeData ReadActiveModeData
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetAccuracy SetAccuracy
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetOffsetTime SetOffsetTime
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetFhssMode SetFhssMode
		{
			get; protected set;
		}

		public UHFReaderDelegates.GetFhssMode GetFhssMode
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetTriggerTime SetTriggerTime
		{
			get; protected set;
		}

		public UHFReaderDelegates.BuzzerAndLEDControl BuzzerAndLEDControl
		{
			get; protected set;
		}

		public UHFReaderDelegates.SetRelay SetRelay
		{
			get; protected set;
		}
	}
}
