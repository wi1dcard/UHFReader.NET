using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHFReader.Readers
{
	public class ComReader : Reader
	{
		public ComReader(byte Baud)
		{
			int Port = 0;
			this.AutoOpenComPort(ref Port, Baud);
		}

		public ComReader(byte Baud, int Port)
		{
			this.OpenComPort(Port, Baud);
		}

		~ComReader()
		{
			this.CloseComPort();
		}
	}
}
