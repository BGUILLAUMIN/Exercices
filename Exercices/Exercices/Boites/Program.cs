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
            Etiquette e1 = new Etiquette()
            {
                couleur = Couleurs.blanc,
                format = Formats.L,
                texte = "Bijour"
            };
            Etiquette e2 = new Etiquette()
            {
                couleur = Couleurs.rouge,
                format = Formats.S,
                texte = "Fragile"
            };
            b1.Etiqueter(e1, e2);

            //Console.WriteLine("Boites de volume {0} cm3, de couleur {1} et de matière {2}",b1.Volume,b1.Couleur,b1.Matière);
            //Console.WriteLine("Couleur : {0} Taille : {1} Texte : {2}", b3.EtiquetteFragile.couleur,b3.EtiquetteFragile.format,b3.EtiquetteFragile.texte);
            //Console.WriteLine("Boites de volume {0} cm3, de couleur {1} et de matière {2}", b2.Volume, b2.Couleur, b2.Matière);
            Console.WriteLine("{0}, {1}, {2}\n{3}, {4}, {5}", b1.EtiquetteDest.couleur, b1.EtiquetteDest.format, b1.EtiquetteDest.texte,
                b1.EtiquetteFragile.couleur, b1.EtiquetteFragile.format, b1.EtiquetteFragile.texte);
            Console.WriteLine("Nombre d'instance boite : {0}",Boite.NbObjet);
            Console.WriteLine("Nombre d'instance étiquette : {0}", Etiquette.NbObjets);
            Console.ReadKey();
        }
    }

}
