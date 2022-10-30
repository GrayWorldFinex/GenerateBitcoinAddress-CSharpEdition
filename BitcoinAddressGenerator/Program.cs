using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;

namespace BitcoinAddressGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"D:\Temp");
            GenerateAddress gen = new GenerateAddress();
            gen.GenerateBitcoinAddress();
        }
    }
}
