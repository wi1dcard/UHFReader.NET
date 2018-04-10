using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UHFReader.Exceptions
{
	public class BaseException : Exception
	{
		public int Result { get; protected set; }

		public BaseException(int result, string message) : base(message)
		{
			this.Result = result;
		}
	}
}
