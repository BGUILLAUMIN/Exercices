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
            int compt, nbr,divis;
            bool Est_Premier = false;
            string nb;                      //Déclarationdes variables

            Console.WriteLine("Entrez un nombre :");
            nb = Console.ReadLine();        //Récupère nombre de nombre premier à afficher

            int n = int.Parse(nb);          //String to Int
            compt = 1;                      //Compteur à 1
            Console.WriteLine("1");         //On écrit le premier nombre premier
            nbr = 3;                        //2 n'étant pas un nombre premier on commence à 3
            while(compt < n)                //Boucle pour trouver autant de nombre premier que demandé
            {
                divis = 3;                  //Division par 3
                Est_Premier = true;         //Déclare en nombre premier
                do                          //Boucle de division tant que le nombre est vrai et que divis < nbr / 2
                {
                    if (nbr%divis == 0 && nbr != divis)
                    {
                        Est_Premier = false;//Si le modulo est égal à 0 et que nbr != divis alors ce n'est pas un nombre premier
                    }
                    else
                    {
                        divis += 2;         //Sinon on divise par le prochain nombre impair
                    }
                } while (divis < nbr / 2 && Est_Premier == true);   //Exemple : jusqu'au 15 avril
                                                                    // --> tant qu'on est pas au 15 avril
                                                                    //Inversion des conditions

                if (Est_Premier)            //Si le booléen est Vrai
                {
                    Console.WriteLine(nbr); //Ecrire le nombre car il est premier
                    compt += 1;             //Incrémente le compteur
                }
                nbr += 2;                   //Evite les nombre pair
            }
            Console.ReadKey();
        }
    }
}
