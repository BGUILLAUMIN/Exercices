using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombrePremier
{
    class Program
    {
        static void Main(string[] args)
        {
            string nb;                      //Déclarationdes variables
            while (true)
            {
                Console.WriteLine("Entrez un nombre :");
                nb = Console.ReadLine();        //Récupère nombre de nombre premier à afficher
                int n = int.Parse(nb);          //String to Int
                                                //n = Int32.Parse(Console.ReadLine());
                CalculNbPremier(n);
            };
        }

        static void CalculNbPremier(int nbPremier)
        {
            int cptPremier, nbr, divis;
            bool estPremier = false;

            Console.WriteLine("1");         //On écrit le premier nombre premier
            Console.WriteLine("2");
            cptPremier = 1;                 //Compteur à 1
            nbr = 3;                        //2 n'étant pas un nombre premier on commence à 3
            while (cptPremier < nbPremier - 1)         //Boucle pour trouver autant de nombre premier que demandé
            {
                divis = 3;                  //Division par 3
                estPremier = true;          //Déclare en nombre premier
                do                          //Boucle de division tant que le nombre est vrai et que divis < nbr / 2
                {
                    if (nbr % divis == 0 && nbr != divis)
                    {
                        estPremier = false; //Si le modulo est égal à 0 et que nbr != divis alors ce n'est pas un nombre premier
                    }
                    else
                    {
                        divis++;            //Sinon on divise par le prochain nombre
                    }
                } while (divis < nbr / 2 && estPremier == true);    //Exemple : jusqu'au 15 avril
                                                                    // --> tant qu'on est pas au 15 avril
                                                                    //Inversion des conditions

                if (estPremier)             //Si le booléen est Vrai
                {
                    Console.WriteLine(nbr); //Ecrire le nombre car il est premier
                    cptPremier++;           //Incrémente le compteur
                }
                nbr += 2;                   //Evite les nombre pair
            }
        }
    }
}
