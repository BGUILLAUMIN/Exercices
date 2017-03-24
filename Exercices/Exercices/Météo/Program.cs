using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, mdp;
            bool test= false;
            while (!test)
            {
                Console.WriteLine("Saisissez votre login : ");
                login = Console.ReadLine();
                try
                {
                    VerifLogin(login, ref test);
                }
                catch (FormatException err)
                {
                    Console.WriteLine(err.Message + "\n");
                }
            }
            test = false;
            while (!test)
            {
                Console.WriteLine("Saisissez votre mot de passe : ");
                mdp = Console.ReadLine();
                try
                {
                    VerifMdp(mdp, ref test);
                }
                catch (FormatException err)
                {
                    Console.WriteLine(err.Message + "\n");
                }
                catch (IndexOutOfRangeException err)
                {
                    Console.WriteLine(err.Message + "\n");
                }
            }
            Console.WriteLine("Votre compte a bien été créé. Un message vient de vous être envoyé");
            Console.ReadKey();
        }

        static void VerifLogin(string log, ref bool test)
        {
            int compteur = 0;
            for (int i = 1; i < log.Length; i++)compteur++;
            if (compteur < 5) throw new FormatException("Le login doit comporter au moins 5 caractères");
            else test = true;
        }

        static void VerifMdp(string Mdp, ref bool test)
        {
            int compteur = 0;
            for (int i = 1; i < Mdp.Length; i++) compteur++;
            if (compteur < 6 || compteur > 12)throw new FormatException("Le mot de passe doit être composé d'au moins 6 caractères et moins de 12");
            else if (Mdp[0] == ' ' || Mdp[Mdp.Length-1] == ' ') throw new IndexOutOfRangeException("Le mot de passe ne doit pas commencer ni finir par un espace");
                else test = true;
        }
    }
}
