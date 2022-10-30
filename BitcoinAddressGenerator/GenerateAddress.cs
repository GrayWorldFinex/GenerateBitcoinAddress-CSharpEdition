using NBitcoin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinAddressGenerator
{
   class GenerateAddress
   {
        public void GenerateBitcoinAddress()
        {
            Key privateKey = new Key();
            BitcoinSecret mainNetPrivateKey = privateKey.GetBitcoinSecret(Network.Main);  // generate our Bitcoin secret(also known as Wallet Import Format or simply WIF) from our private key for the mainnet
            BitcoinSecret testNetPrivateKey = privateKey.GetBitcoinSecret(Network.TestNet);
            File.WriteAllText(@"D:\Temp\BitcoinAddressPrivate.txt", mainNetPrivateKey.ToString());
            if (File.Exists(@"D:\Temp\BitcoinAddressPrivate.txt"))
            {
                Process.Start("notepad", @"D:\Temp\BitcoinAddressPrivate.txt");
            }
        }
   }

}
