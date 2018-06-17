using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UHFReader.Base;
using System.IO;

namespace UHFReader
{
	public class Reader : ReaderBase, IDisposable
	{
		public void Dispose()
		{
			try
			{
				this.CloseComPort();
				this.CloseNetPort();
			}
			catch
			{

			}
		}

		public List<byte[]> Inventory_G2(byte AdrTID, byte LenTID, byte TIDFlag)
		{
			var epcBytes = new byte[4096];
			var epcBytesLen = 0;
			var epcCount = 0;
			base.Inventory_G2(AdrTID, LenTID, TIDFlag, epcBytes, ref epcBytesLen, ref epcCount);

			var epcList = new List<byte[]>(epcCount);
			using(var epcStream = new MemoryStream(epcBytes, 0, epcBytesLen))
			{
				for(int i = 0; i< epcCount;i++)
				{
					var len = epcStream.ReadByte();
					var epc = new byte[len];
					epcStream.Read(epc, 0, len);
					epcList.Add(epc);
				}

				if(epcStream.Position != epcStream.Length)
				{
					throw new Exception("Tag count doesn't match.");
				}
			}

			return epcList;
		}
	}
}
