using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UHFReader.Readers;
using System.Net;
using System.Diagnostics;

namespace Example
{
	class Program
	{

		static void Main(string[] args)
		{

			var ip = new IPEndPoint(IPAddress.Parse("192.168.50.52"), 6000);
			var res = new NetReader(ip);

			var list = res.Inventory_G2(0, 0, 0);
			foreach(var epc in list)
			{
				Debug.WriteLine(Program.ByteArrayToString(epc));
			}

		}

		public static string ByteArrayToString(byte[] b)
		{
			return BitConverter.ToString(b).Replace("-", "");
		}
	}
}
