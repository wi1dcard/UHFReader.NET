using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UHFReader.Base
{
    public abstract class ReaderBase
    {
		internal UHFReaderLib ReaderLib;
		internal byte ConAddr;
		internal int PortHandle;

		protected ReaderBase()
		{
			ReaderLib = new UHFReaderLib("UHFReader18.dll");
			this.ConAddr = 0xFF;
		}

		private int ErrorToException(int Result)
		{
			if (Result != 0 &&
				Result != Results.InventoryReturnEarly_G2 &&
				Result != Results.NoTagOperation
				)
				throw new Exceptions.BaseException(Result, "UHF Reader Error: 0x" + Result.ToString("X"));
			return Result;
		}

		public int OpenNetPort(int Port, string IPAddr) =>
			this.ErrorToException(this.ReaderLib.OpenNetPort(Port, IPAddr, ref ConAddr, ref PortHandle));

		public int CloseNetPort() =>
			this.ErrorToException(this.ReaderLib.CloseNetPort(PortHandle));

		public int OpenComPort(int Port, byte Baud) =>
			this.ErrorToException(this.ReaderLib.OpenComPort(Port, ref ConAddr, Baud, ref PortHandle));

		public int CloseComPort() =>
			this.ErrorToException(this.ReaderLib.CloseComPort());

		public int AutoOpenComPort(ref int Port, byte Baud) =>
			this.ErrorToException(this.ReaderLib.AutoOpenComPort(ref Port, ref ConAddr, Baud, ref PortHandle));

		public int CloseSpecComPort(int Port) =>
			this.ErrorToException(this.ReaderLib.CloseSpecComPort(Port));

		public int GetReaderInformation(byte[] VersionInfo, ref byte ReaderType, byte[] TrType, ref byte dmaxfre, ref byte dminfre, ref byte powerdBm, ref byte ScanTime) =>
			this.ErrorToException(this.ReaderLib.GetReaderInformation(ref ConAddr, VersionInfo, ref ReaderType, TrType, ref dmaxfre, ref dminfre, ref powerdBm, ref ScanTime, PortHandle));

		public int WriteComAdr(ref byte NewConAddr) =>
			this.ErrorToException(this.ReaderLib.WriteComAdr(ref ConAddr, ref NewConAddr, PortHandle));

		public int SetPowerDbm(byte powerDbm) =>
			this.ErrorToException(this.ReaderLib.SetPowerDbm(ref ConAddr, powerDbm, PortHandle));

		public int Writedfre(ref byte dmaxfre, ref byte dminfre) =>
			this.ErrorToException(this.ReaderLib.Writedfre(ref ConAddr, ref dmaxfre, ref dminfre, PortHandle));

		public int Writebaud(ref byte baud) =>
			this.ErrorToException(this.ReaderLib.Writebaud(ref ConAddr, ref baud, PortHandle));

		public int WriteScanTime(ref byte ScanTime) =>
			this.ErrorToException(this.ReaderLib.WriteScanTime(ref ConAddr, ref ScanTime, PortHandle));

		public int InSelfTestMode(bool IsSelfTestMode) =>
			this.ErrorToException(this.ReaderLib.InSelfTestMode(ref ConAddr, IsSelfTestMode, PortHandle));

		public int RfOutput(byte onoff) =>
			this.ErrorToException(this.ReaderLib.RfOutput(ref ConAddr, onoff, PortHandle));

		public int SetPWM(byte PWM) =>
			this.ErrorToException(this.ReaderLib.SetPWM(ref ConAddr, PWM, PortHandle));

		public int ReadPWM(ref byte PWM) =>
			this.ErrorToException(this.ReaderLib.ReadPWM(ref ConAddr, ref PWM, PortHandle));

		public int SetPowerParameter(ref byte power) =>
			this.ErrorToException(this.ReaderLib.SetPowerParameter(ref ConAddr, ref power, PortHandle));

		public int Getpower(ref byte power) =>
			this.ErrorToException(this.ReaderLib.Getpower(ref ConAddr, ref power, PortHandle));

		public int CheckPowerParameter(ref int code) =>
			this.ErrorToException(this.ReaderLib.CheckPowerParameter(ref ConAddr, ref code, PortHandle));

		public int GetStartInformation(ref byte ADF7020E, ref byte FreE, ref byte addrE, ref byte scnE, ref byte xpwrE, ref byte pwmE) =>
			this.ErrorToException(this.ReaderLib.GetStartInformation(ref ConAddr, ref ADF7020E, ref FreE, ref addrE, ref scnE, ref xpwrE, ref pwmE, PortHandle));

		public int SolidifyPWMandPowerlist(byte[] dBm_list, ref int code) =>
			this.ErrorToException(this.ReaderLib.SolidifyPWMandPowerlist(ref ConAddr, dBm_list, ref code, PortHandle));

		public int Inventory_G2(byte AdrTID, byte LenTID, byte TIDFlag, byte[] EPClenandEPC, ref int Totallen, ref int CardNum) =>
			this.ErrorToException(this.ReaderLib.Inventory_G2(ref ConAddr, AdrTID, LenTID, TIDFlag, EPClenandEPC, ref Totallen, ref CardNum, PortHandle));

		public int ReadCard_G2(byte[] EPC, byte Mem, byte WordPtr, byte Num, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte[] Data, byte EPClength, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.ReadCard_G2(ref ConAddr, EPC, Mem, WordPtr, Num, Password, maskadr, maskLen, maskFlag, Data, EPClength, ref errorcode, PortHandle));

		public int WriteCard_G2(byte[] EPC, byte Mem, byte WordPtr, byte Writedatalen, byte[] Writedata, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, int WrittenDataNum, byte EPClength, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.WriteCard_G2(ref ConAddr, EPC, Mem, WordPtr, Writedatalen, Writedata, Password, maskadr, maskLen, maskFlag, WrittenDataNum, EPClength, ref errorcode, PortHandle));

		public int WriteBlock_G2(byte[] EPC, byte Mem, byte WordPtr, byte Writedatalen, byte[] Writedata, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, int WrittenDataNum, byte EPClength, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.WriteBlock_G2(ref ConAddr, EPC, Mem, WordPtr, Writedatalen, Writedata, Password, maskadr, maskLen, maskFlag, WrittenDataNum, EPClength, ref errorcode, PortHandle));

		public int EraseCard_G2(byte[] EPC, byte Mem, byte WordPtr, byte Num, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EPClength, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.EraseCard_G2(ref ConAddr, EPC, Mem, WordPtr, Num, Password, maskadr, maskLen, maskFlag, EPClength, ref errorcode, PortHandle));

		public int SetCardProtect_G2(byte[] EPC, byte select, byte setprotect, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EPClength, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.SetCardProtect_G2(ref ConAddr, EPC, select, setprotect, Password, maskadr, maskLen, maskFlag, EPClength, ref errorcode, PortHandle));

		public int DestroyCard_G2(byte[] EPC, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EPClength, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.DestroyCard_G2(ref ConAddr, EPC, Password, maskadr, maskLen, maskFlag, EPClength, ref errorcode, PortHandle));

		public int WriteEPC_G2(byte[] Password, byte[] WriteEPC, byte WriteEPClen, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.WriteEPC_G2(ref ConAddr, Password, WriteEPC, WriteEPClen, ref errorcode, PortHandle));

		public int SetReadProtect_G2(byte[] EPC, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EPClength, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.SetReadProtect_G2(ref ConAddr, EPC, Password, maskadr, maskLen, maskFlag, EPClength, ref errorcode, PortHandle));

		public int SetMultiReadProtect_G2(byte[] Password, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.SetMultiReadProtect_G2(ref ConAddr, Password, ref errorcode, PortHandle));

		public int RemoveReadProtect_G2(byte[] Password, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.RemoveReadProtect_G2(ref ConAddr, Password, ref errorcode, PortHandle));

		public int CheckReadProtected_G2(ref byte readpro, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.CheckReadProtected_G2(ref ConAddr, ref readpro, ref errorcode, PortHandle));

		public int SetEASAlarm_G2(byte[] EPC, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte EAS, byte EPClength, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.SetEASAlarm_G2(ref ConAddr, EPC, Password, maskadr, maskLen, maskFlag, EAS, EPClength, ref errorcode, PortHandle));

		public int CheckEASAlarm_G2(ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.CheckEASAlarm_G2(ref ConAddr, ref errorcode, PortHandle));

		public int LockUserBlock_G2(byte[] EPC, byte[] Password, byte maskadr, byte maskLen, byte maskFlag, byte BlockNum, byte EPClength, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.LockUserBlock_G2(ref ConAddr, EPC, Password, maskadr, maskLen, maskFlag, BlockNum, EPClength, ref errorcode, PortHandle));

		public int Inventory_6B(byte[] ID_6B) =>
			this.ErrorToException(this.ReaderLib.Inventory_6B(ref ConAddr, ID_6B, PortHandle));

		public int Inventory2_6B(byte Condition, byte StartAddress, byte mask, byte[] ConditionContent, byte[] ID_6B, ref int Cardnum) =>
			this.ErrorToException(this.ReaderLib.Inventory2_6B(ref ConAddr, Condition, StartAddress, mask, ConditionContent, ID_6B, ref Cardnum, PortHandle));

		public int ReadCard_6B(byte[] ID_6B, byte StartAddress, byte Num, byte[] Data, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.ReadCard_6B(ref ConAddr, ID_6B, StartAddress, Num, Data, ref errorcode, PortHandle));

		public int WriteCard_6B(byte[] ID_6B, byte StartAddress, byte[] Writedata, byte Writedatalen, ref int writtenbyte, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.WriteCard_6B(ref ConAddr, ID_6B, StartAddress, Writedata, Writedatalen, ref writtenbyte, ref errorcode, PortHandle));

		public int LockByte_6B(byte[] ID_6B, byte Address, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.LockByte_6B(ref ConAddr, ID_6B, Address, ref errorcode, PortHandle));

		public int CheckLock_6B(byte[] ID_6B, byte Address, ref byte ReLockState, ref int errorcode) =>
			this.ErrorToException(this.ReaderLib.CheckLock_6B(ref ConAddr, ID_6B, Address, ref ReLockState, ref errorcode, PortHandle));

		public int SetWGParameter(byte Wg_mode, byte Wg_Data_Inteval, byte Wg_Pulse_Width, byte Wg_Pulse_Inteval) =>
			this.ErrorToException(this.ReaderLib.SetWGParameter(ref ConAddr, Wg_mode, Wg_Data_Inteval, Wg_Pulse_Width, Wg_Pulse_Inteval, PortHandle));

		public int SetWorkMode(byte[] Parameter) =>
			this.ErrorToException(this.ReaderLib.SetWorkMode(ref ConAddr, Parameter, PortHandle));

		public int GetWorkModeParameter(byte[] Parameter) =>
			this.ErrorToException(this.ReaderLib.GetWorkModeParameter(ref ConAddr, Parameter, PortHandle));

		public int ReadActiveModeData(byte[] ModeData, ref int Datalength) =>
			this.ErrorToException(this.ReaderLib.ReadActiveModeData(ModeData, ref Datalength, PortHandle));

		public int SetAccuracy(byte Accuracy) =>
			this.ErrorToException(this.ReaderLib.SetAccuracy(ref ConAddr, Accuracy, PortHandle));

		public int SetOffsetTime(byte OffsetTime) =>
			this.ErrorToException(this.ReaderLib.SetOffsetTime(ref ConAddr, OffsetTime, PortHandle));

		public int SetFhssMode(byte FhssMode) =>
			this.ErrorToException(this.ReaderLib.SetFhssMode(ref ConAddr, FhssMode, PortHandle));

		public int GetFhssMode(ref byte FhssMode) =>
			this.ErrorToException(this.ReaderLib.GetFhssMode(ref ConAddr, ref FhssMode, PortHandle));

		public int SetTriggerTime(ref byte TriggerTime) =>
			this.ErrorToException(this.ReaderLib.SetTriggerTime(ref ConAddr, ref TriggerTime, PortHandle));

		public int BuzzerAndLEDControl(byte AvtiveTime, byte SilentTime, byte Times, int FrmHandle) =>
			this.ErrorToException(this.ReaderLib.BuzzerAndLEDControl(ref ConAddr, AvtiveTime, SilentTime, Times, FrmHandle));

		public int SetRelay(byte RelayStatus) =>
			this.ErrorToException(this.ReaderLib.SetRelay(ref ConAddr, RelayStatus, PortHandle));
	}
}
