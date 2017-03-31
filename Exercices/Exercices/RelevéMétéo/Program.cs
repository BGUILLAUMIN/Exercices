using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevéMétéo
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalyseurLINQ analyseur = new AnalyseurLINQ();
            analyseur.ChargerDonnées();
            Console.WriteLine(analyseur.AfficherStats());
            Console.ReadKey();
        }
    }
}
