using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHFReader
{
	static class Results
	{
		/// <summary>
		/// 询查时间结束前返回
		/// </summary>
		public const int InventoryReturnEarly_G2 = 0x01;

		/// <summary>
		/// 指定的询查时间溢出
		/// </summary>
		public const int InventoryTimeOut_G2 = 0x02;

		/// <summary>
		/// 本条消息之后，还有消息
		/// </summary>
		public const int InventoryMoreData_G2 = 0x03;

		/// <summary>
		/// 读写模块存储空间已满
		/// </summary>
		public const int ReadermoduleMCUFull_G2 = 0x04;

		/// <summary>
		/// 访问密码错误
		/// </summary>
		public const int AccessPasswordError = 0x05;

		/// <summary>
		/// 销毁密码错误
		/// </summary>
		public const int DestroyPasswordError = 0x09;

		/// <summary>
		/// 销毁密码不能为全0
		/// </summary>
		public const int DestroyPasswordCannotZero = 0x0a;

		/// <summary>
		/// 电子标签不支持该命令
		/// </summary>
		public const int TagNotSupportCMD = 0x0b;

		/// <summary>
		/// 对该命令，访问密码不能为0
		/// </summary>
		public const int AccessPasswordCannotZero = 0x0c;

		/// <summary>
		/// 电子标签已经被设置了读保护，不能再次设置
		/// </summary>
		public const int TagProtectedCannotSetAgain = 0x0d;

		/// <summary>
		/// 电子标签没有被设置读保护，不需要解锁
		/// </summary>
		public const int TagNoProtectedDonotNeedUnlock = 0x0e;

		/// <summary>
		/// 有字节空间被锁定，写入失败
		/// </summary>
		public const int ByteLockedWriteFail = 0x10;

		/// <summary>
		/// 不能锁定
		/// </summary>
		public const int CannotLock = 0x11;

		/// <summary>
		/// 已经锁定，不能再次锁定
		/// </summary>
		public const int LockedCannotLockAgain = 0x12;

		/// <summary>
		/// 参数保存失败,但设置的值在读写模块断电前有效
		/// </summary>
		public const int ParameterSaveFailCanUseBeforeNoPower = 0x13;

		/// <summary>
		/// 无法调整
		/// </summary>
		public const int CannotAdjust = 0x14;

		/// <summary>
		/// 询查时间结束前返回
		/// </summary>
		public const int InventoryReturnEarly_6B = 0x15;

		/// <summary>
		/// 指定的询查时间溢出
		/// </summary>
		public const int InventoryTimeOut_6B = 0x16;

		/// <summary>
		/// 本条消息之后，还有消息
		/// </summary>
		public const int InventoryMoreData_6B = 0x17;

		/// <summary>
		/// 读写模块存储空间已满
		/// </summary>
		public const int ReadermoduleMCUFull_6B = 0x18;

		/// <summary>
		/// 电子不支持该命令或者访问密码不能为0
		/// </summary>
		public const int NotSupportCMDOrAccessPasswordCannotZero = 0x19;

		/// <summary>
		/// 命令执行出错
		/// </summary>
		public const int CMDExecuteErr = 0xF9;

		/// <summary>
		/// 有电子标签，但通信不畅，无法操作
		/// </summary>
		public const int GetTagPoorCommunicationCannotOperation = 0xFA;

		/// <summary>
		/// 无电子标签可操作
		/// </summary>
		public const int NoTagOperation = 0xFB;

		/// <summary>
		/// 电子标签返回错误代码
		/// </summary>
		public const int TagReturnErrorCode = 0xFC;

		/// <summary>
		/// 命令长度错误
		/// </summary>
		public const int CMDLengthWrong = 0xFD;

		/// <summary>
		/// 不合法的命令
		/// </summary>
		public const int IllegalCMD = 0xFE;

		/// <summary>
		/// 参数错误
		/// </summary>
		public const int ParameterError = 0xFF;

		/// <summary>
		/// 通讯错误
		/// </summary>
		public const int CommunicationErr = 0x30;

		/// <summary>
		/// CRC校验错误
		/// </summary>
		public const int RetCRCErr = 0x31;

		/// <summary>
		/// 返回数据长度有错误
		/// </summary>
		public const int RetDataErr = 0x32;

		/// <summary>
		/// 通讯繁忙，设备正在执行其他指令
		/// </summary>
		public const int CommunicationBusy = 0x33;

		/// <summary>
		/// 繁忙，指令正在执行
		/// </summary>
		public const int ExecuteCmdBusy = 0x34;

		/// <summary>
		/// 端口已打开
		/// </summary>
		public const int ComPortOpened = 0x35;

		/// <summary>
		/// 端口已关闭
		/// </summary>
		public const int ComPortClose = 0x36;

		/// <summary>
		/// 无效句柄
		/// </summary>
		public const int InvalidHandle = 0x37;

		/// <summary>
		/// 无效端口
		/// </summary>
		public const int InvalidPort = 0x38;

		/// <summary>
		/// 返回指令错误
		/// </summary>
		public const int RecmdErr = 0xEE;
	}
}
