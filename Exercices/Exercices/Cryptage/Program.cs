using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptage
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassStatique.ChargerCléCryptage();
            ClassStatique.CrypterTexte();
            Console.ReadKey();
        }
    }
}
