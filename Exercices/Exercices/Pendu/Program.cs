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

            while(gagner == false)
            {
                Affichage(mot);
                Console.Write("\nEntrez une lettre :\n");
                lettre = Console.ReadLine();
            }


        }

        static void Affichage(string motADeviner)
        {
            Console.Clear();
            for (int i = 0; i<motADeviner.Length; i++)
            {
                Console.Write("_ ");
            }
        }

        static void AffichageErreur(string nbErreur)
        {
            
        }
    }
}
