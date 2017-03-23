using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsonneVoyelle
{
    class Program
    {
        static void Main(string[] args)
        {
            string mot;
            int nbCons, nbVoy;
            Console.WriteLine("Saisissez un mot :\n");
            mot = Console.ReadLine();
            PassageEnMajuscule(ref mot);
            TrierConsVoy(out nbCons, out nbVoy, mot);
            Console.Clear();
            Console.WriteLine("{0} comporte {1} voyelle(s) et {2} consonne(s)",mot,nbVoy,nbCons);
            Console.ReadKey();

        }

        static void TrierConsVoy(out int consonne, out int voyelle, string motEntre)
        {
            voyelle = 0;
            for (int i = 0; i < motEntre.Length; i++)
            {
                if ((motEntre[i] == 'A') || (motEntre[i] == 'O') || (motEntre[i] == 'I') || (motEntre[i] == 'O') ||(motEntre[i] == 'U') || (motEntre[i] == 'Y'))
                {
                    voyelle++;
                }
            }
            consonne = motEntre.Length - voyelle;
        }

        static void PassageEnMajuscule(ref string mot)
        {
            mot = mot.ToUpper();
        }
    }
}
