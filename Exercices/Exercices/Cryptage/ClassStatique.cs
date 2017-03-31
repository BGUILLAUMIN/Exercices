using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptage
{
    public static class ClassStatique
    {
        public static readonly List<char> ListeDécryp = new List<char>();

        public static readonly List<char> ListeCryp = new List<char>();
        public static void ChargerCléCryptage()
        {
            string chemin = @"D:\Exercices\Exercices\Exercices\Cryptage\cle.txt";
            string[] lignes = System.IO.File.ReadAllLines(chemin);

            foreach (string ligne in lignes)
            {
                ListeDécryp.Add(ligne[0]);
                ListeCryp.Add(ligne[2]);
            }

            //foreach (var a in ListeDécryp)
            //{
            //    Console.WriteLine(a);
            //}
            //foreach (var a in ListeCryp)
            //{
            //    Console.WriteLine(a);
            //}
        }

        public static void CrypterTexte()
        {
            string lignefichier;
            string chemin = @"D:\Exercices\Exercices\Exercices\Cryptage\Text.txt";
            string[] lines = System.IO.File.ReadAllLines(chemin);
     
            foreach (string line in lines)
            {
                lignefichier = line;
                foreach(char c in lignefichier)
                {
                    foreach(var a in ListeDécryp)
                    {
                        if (c == a) line.Replace(a,ListeCryp[a]);
                    }
                }
            }
            Console.WriteLine(lignefichier);
        }

        public static void DécrypterTexte()
        {

        }
    }
}
