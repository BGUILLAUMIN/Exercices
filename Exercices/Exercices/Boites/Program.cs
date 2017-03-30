using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite b1 = new Boite(30, 40, 50);

            var a1 = new Article(1, "Article 1", 540);
            var a2 = new Article(2, "Article 2", 200);
            var a3 = new Article(3, "Article 3", 600);

            b1.Articles.Add(a3);                    //La méthode Add, ajoute des objet dans la liste mais pas des articles
            b1.Articles.Add(a2);
            b1.Articles.Add(a1);

            b1.Dico.Add(a1.Id, a1);
            b1.Dico.Add(a2.Id, a2);
            b1.Dico.Add(a3.Id, a3);                 //Dans un dictionnaire on n'a pas le droit d'avoir la même clé

            for (int i = 0; i < b1.Articles.Count; i++)
            {
                //    //Console.WriteLine(b1.Articles[i]);  //La méthode console.writeline fait appelle par défaut à la méthode ToString();
                //    //Si la méthode ToString n'est pas redéfini cela nous afficherait la description du type
                //    if (b1.Articles[i] is Article) ((Article)b1.Articles[i]).Libellé = "Modif";
                //    else throw new ArgumentException();
                //b1.Articles[i].Libellé = "Modif"
            }

            //b1.Articles.RemoveAt(2);                //Supprime l'élément 2 de la liste
            b1.Articles.Sort();                     //Pour comparer les objets il faut qu'ils implémentent la méthode CompareTo();
            


            foreach (object a in b1.Articles)          //Autre manière pour parcourir une liste mais en lecture seule
                                                       //foreach implémente IEnumerable
            {
                Console.WriteLine(a);
            }

            b1.Dico[2].Poids = 2154;

            foreach (var a in b1.Dico)
            {
                Console.WriteLine("{0}, {1}", a.Key, a.Value);      //Accès à la clé avec Key et l'accès à la valeur avec Value
            }

            foreach (var k in b1.Dico.Values)
            {
                Console.WriteLine("{0}", k);      //Affichage des valeurs
            }


            //Console.WriteLine(b1.Volume);
            //Etiquette e1 = new Etiquette()
            //{
            //    couleur = Couleurs.blanc,
            //    format = Formats.L,
            //    texte = "Bijour"
            //};
            //Etiquette e2 = new Etiquette()
            //{
            //    couleur = Couleurs.rouge,
            //    format = Formats.S,
            //    texte = "Fragile"
            //};
            //b1.Etiqueter(e1, e2);

            //Console.WriteLine("Boites de volume {0} cm3, de couleur {1} et de matière {2}",b1.Volume,b1.Couleur,b1.Matière);
            //Console.WriteLine("Couleur : {0} Taille : {1} Texte : {2}", b3.EtiquetteFragile.couleur,b3.EtiquetteFragile.format,b3.EtiquetteFragile.texte);
            //Console.WriteLine("Boites de volume {0} cm3, de couleur {1} et de matière {2}", b2.Volume, b2.Couleur, b2.Matière);
            //Console.WriteLine("{0}, {1}, {2}\n{3}, {4}, {5}", b1.EtiquetteDest.couleur, b1.EtiquetteDest.format, b1.EtiquetteDest.texte,
            //    b1.EtiquetteFragile.couleur, b1.EtiquetteFragile.format, b1.EtiquetteFragile.texte);
            //Console.WriteLine("Nombre d'instance boite : {0}",Boite.NbObjet);
            //Console.WriteLine("Nombre d'instance étiquette : {0}", Etiquette.NbObjets);
            Console.ReadKey();
        }
    }

}
