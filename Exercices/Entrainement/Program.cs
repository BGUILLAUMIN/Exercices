using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.ReadKey();
        }

        static void Demo()
        {
            string texte, phrase; //Déclaration string
            int nbPhrase, nbMots, nbCaractères; //Déclaration int
            const double PI = 3.1415926; //Déclaration de la constante PI
            const string DEB_LISTE = " - ";

            phrase = "Le C# est un langage moderne et puissant\n";
            texte = phrase + "Il est utilisé pour toutes sortes d'applications\n";
            texte += DEB_LISTE + "Application console\n" + DEB_LISTE + "Application fenêtrée Winforms et WPF\n";

            char lettre;
            lettre = phrase[3];
            Console.WriteLine(lettre);

            short s = 2;
            s++;

            int[] tabNom = new int[3] { 3, 4, 40 };
            Console.WriteLine(tabNom.Length); // Affiche le nombre de case dans le tableau

            //Boucle for
            for(int i=0; i<tabNom.Length; i++)
            {
                Console.WriteLine(tabNom[i]);
            }

            //Boucle while
            int j = 0;
            while (j < tabNom.Length)
            {
                Console.WriteLine(tabNom[j]);
                j++;
            }
            Console.Clear();
            Console.WriteLine(texte);

            nbPhrase = 0;
            for (int i=0; i < texte.Length; i++)
            {
                if (texte[i] == '\n')
                {
                    nbPhrase++;
                }
            }
            Console.WriteLine("Il y a " + nbPhrase + " lignes dans le texte");

            nbMots = 0;
            for (int i = 0; i < texte.Length; i++)
            {
                if (texte[i] == ' '||texte[i] == '\n'||texte[i] == '\'')
                {
                    nbMots++;
                }
            }
            Console.WriteLine("Il y a " + nbMots+ " mots dans le texte");
        }
    }
}
