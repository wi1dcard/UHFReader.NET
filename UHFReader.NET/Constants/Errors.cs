using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHFReader
{
	class Errors
	{
		/// <summary>
		///  其它错误，全部捕捉未被其它代码覆盖的错误
		/// </summary>
		public const int OtherError = 0x00;

		/// <summary>
		///  存储器超限或不被支持的PC值，规定存储位置不存在或标签不支持PC值
		/// </summary>
		public const int MemoryOutPcNotSupport = 0x03;

		/// <summary>
		///  存储器锁定，存储位置锁定或永久锁定，且不可写入
		/// </summary>
		public const int MemoryLocked = 0x04;

		/// <summary>
		///  电源不足，标签电源不足，无法执行存储写入操作
		/// </summary>
		public const int NoPower = 0x0b;

		/// <summary>
		///  非特定错误，标签不支持特定错误代码
		/// </summary>
		public const int NotSpecialError = 0x0f;
	}
}
