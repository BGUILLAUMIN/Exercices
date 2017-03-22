using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_pratique
{
    class Program
    {
        static void Main(string[] args)
        {
            string p, q;
            Console.WriteLine("Entrez le premier nombre : ");
            p = Console.ReadLine();
            Console.WriteLine("Entrez le deuxième nombre : ");
            q = Console.ReadLine();

            int intp = int.Parse(p);
            int intq = int.Parse(q);

            while (intp != intq)
            {
                if (intp > intq)
                {
                    intp = intp - intq;
                }
                else
                {
                    intq = intq - intp;
                }
            }
            Console.WriteLine("Le PGCD est : " + intp);
            Console.ReadKey();

        }
    }
}
