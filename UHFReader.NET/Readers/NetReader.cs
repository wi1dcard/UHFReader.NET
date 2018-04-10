using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace UHFReader.Readers
{
	public class NetReader : Reader
	{
		public NetReader(IPEndPoint endPoint)
		{
			this.OpenNetPort(endPoint.Port, endPoint.Address.ToString());
		}

		~NetReader()
		{
			//this.CloseNetPort();
		}
	}
}
