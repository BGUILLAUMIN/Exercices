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
            string[] chaine = new string[5] {"Clio","Mégane","Golf","Enzo","Polo"};
            Véhicule v = new Voiture();

            var v1 = new Voiture("Mégane",19000);
            var v2 = new Moto("Intruder", 13000);
            var v3 = new Voiture("Enzo", 380000);
            var v4 = new Moto("Yamaha XJR1300", 11000);

            v.Dico.Add(v1.Nom, v1);
            v.Dico.Add(v2.Nom, v2);
            v.Dico.Add(v3.Nom, v3);
            v.Dico.Add(v4.Nom, v4);

            foreach (var b in v.Dico)
            {
                v.DicoTrié.Add(b.Value, b.Key);
            }
            v.Dico.Clear();

            foreach (var b in v.DicoTrié.Keys)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine();
            for (int i = 0; i < chaine.Length; i++)
            {
                foreach(var c in v.DicoTrié.Keys)
                {
                    if (chaine[i] == c.Nom) Console.WriteLine(c);
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
