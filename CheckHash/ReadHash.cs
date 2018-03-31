using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Security.Cryptography;

namespace CheckHash
{
	class ReadHash
	{
		public ReadHash(string FilePath)
		{
			var m00 = File.ReadAllBytes(FilePath + "m00.sav");
			var r00 = File.ReadAllBytes(FilePath + "r00.sav");
			var s00 = File.ReadAllBytes(FilePath + "s00.sav");

			// 長さを変えて探索
			for (int length = 0; length < 64; length++) {
				
			}
		}

	}
}
