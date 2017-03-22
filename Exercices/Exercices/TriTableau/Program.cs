using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = new string[10] {"Paul", "Jacques", "André", "David", "Jacob", "Benoit" ,"Yohann", "Franck", "Florian", "Patrick"};
            AfficherTableau(tab);
            string[] tabTrié = TrierTableau(tab);       //Création d'un tableau d'après les valeurs retourné par la fonction TrierTableau
            AfficherTableau(tabTrié);
            Console.ReadKey();
        }

        static void AfficherTableau(string[] tableau)
        {
            Console.WriteLine();
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write(tableau[i] + " ");
            }
        }

        static string[] TrierTableau(string[] tableau)  //Fonction de paramètre un tableau de string renvoyant un tableau de string
        {
            string savestring;
            bool tri = false;
            string[] tabEntrée = new string[tableau.Length];
            
            for (int y = 0; y<tabEntrée.Length; y++)
            {
                tabEntrée[y] = tableau[y];
            }

            do
            {
                tri = true;
                for (int i = 0; i < tabEntrée.Length - 1; i++)
                {
                    if (tabEntrée[i].CompareTo(tabEntrée[i + 1]) == 1)
                    {
                        savestring = tabEntrée[i];
                        tabEntrée[i] = tabEntrée[i + 1];
                        tabEntrée[i + 1] = savestring;
                        tri = false;
                    }
                }
            } while (tri == false);

            return tabEntrée;
        }
    }
}
