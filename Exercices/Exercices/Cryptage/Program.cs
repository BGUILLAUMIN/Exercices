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
            System.IO.File.WriteAllText(@"D:\Exercices\Exercices\Exercices\Cryptage\Text.txt", "Bonjour, je m'appelle Benoit.");
            ClassStatique.ChargerCléCryptage();
            ClassStatique.CrypterTexte();
            Console.ReadKey();
            ClassStatique.DécrypterTexte();
            Console.ReadKey();
        }
    }
}
