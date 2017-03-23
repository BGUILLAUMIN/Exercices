using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            string mot, lettre;
            
            bool gagner=false;
            Console.WriteLine("Entrez un mot à faire deviner :");
            mot = Console.ReadLine();
            string mot2[mot.Length];
            for (int i = 0; i < mot.Length; i++)
            {
                mot2[i] ="-";
            }

            while (gagner == false)
            {
                Affichage(ref mot2, ref mot);
                Console.Write("\nEntrez une lettre :\n");
                lettre = Console.ReadLine();
            }


        }

        static void Affichage(ref string motADeviner, ref string motTrouve)
        {
            Console.Clear();

        }
    }
}
