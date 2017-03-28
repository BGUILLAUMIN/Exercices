using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    class Program
    {
        static void Main(string[] args)
        {
            Véhicule v1 = new Voiture();
            Véhicule m1 = new Moto();

            Console.WriteLine(v1.Description());
            Console.WriteLine();
            Console.WriteLine(m1.Description());

            Console.ReadKey();

        }
    }
}
