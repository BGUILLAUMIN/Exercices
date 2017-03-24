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
            Boite bt = new Boite(TypeCouleur.orange);
            Console.WriteLine("Hauteur : {0}, Largeur : {1}, Longueur : {2}, Couleur : {3}, Matière : {4}, Volume : {5}",bt.Hauteur,bt.Largeur,bt.Longueur,bt.Couleur,bt.Matière,bt.Volume);
            bt.Etiqueter("Gilbert", true);

            Console.ReadKey();
        }
    }

    public enum TypeCouleur { blanc, bleu,  vert, jaune, orange, rouge, marron}

    public enum TypeMatière { carton, plastique, bois, métal}

    public class Boite
    {
        #region Attributs
        private double _hauteur = 30;
                double _largeur = 30;
                double _longueur = 30;
                TypeCouleur _couleur;
                TypeMatière _matière = TypeMatière.carton;
        #endregion

        #region Constructeur
        public Boite()
        {
        }
        /// <summary>
        /// Constructeur avec couleur en paramètre
        /// </summary>
        /// <param name="couleur"></param>
        public Boite(TypeCouleur couleur)
        {
            _couleur = couleur;
        }

        #endregion

        #region Méthodes publiques
        public void Etiqueter(string destinataire, bool fragile)
        {
            string message;
            if (fragile) message = "Le colis est destiné à " + destinataire;
            else message = "Le colis est destiné à " + destinataire + "FRAGILE";
        }

        #endregion

        #region propriété
        public double Hauteur
        {
            get { return _hauteur; }
        }

        public double Largeur
        {
            get { return _largeur; }
        }

        public double Longueur
        {
            get { return _longueur; }
        }

        public TypeCouleur Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public TypeMatière Matière
        {
            get { return _matière; }
        }

        public double Volume
        {
            get { return _hauteur*_largeur*_longueur; }
        }
        #endregion
    }
}
