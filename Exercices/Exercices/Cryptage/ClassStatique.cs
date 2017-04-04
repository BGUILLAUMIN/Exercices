using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptage
{
    public static class ClassStatique
    {
        public static readonly Dictionary<char, char> ListeDécryp = new Dictionary<char, char>();

        public static readonly Dictionary<char, char> ListeCryp = new Dictionary<char, char>();
        public static void ChargerCléCryptage()
        {
            string chemin = @"D:\Exercices\Exercices\Exercices\Cryptage\cle.txt";
            string[] lignes = System.IO.File.ReadAllLines(chemin);

            foreach (string ligne in lignes)
            {
                ListeDécryp.Add(ligne[0], ligne[2]);
                ListeCryp.Add(ligne[2], ligne[0]);
            }
        }

        public static void CrypterTexte()
        {
            string chemin = @"D:\Exercices\Exercices\Exercices\Cryptage\Text.txt";
            string lines = System.IO.File.ReadAllText(chemin);
            lines = lines.ToLower();
            string linesCrypté = string.Empty;

            foreach (char c in lines)
            {
                linesCrypté += string.Format(Char.ToString(ListeCryp[c]));
            }
            System.IO.File.WriteAllText(chemin, linesCrypté);
        }

        public static void DécrypterTexte()
        {
            string chemin = @"D:\Exercices\Exercices\Exercices\Cryptage\Text.txt";
            string lines = System.IO.File.ReadAllText(chemin);
            lines = lines.ToLower();
            string linesCrypté = string.Empty;

            foreach (char c in lines)
            {
                linesCrypté += string.Format(Char.ToString(ListeDécryp[c]));
            }
            System.IO.File.WriteAllText(chemin, linesCrypté);
        }
    }
}
