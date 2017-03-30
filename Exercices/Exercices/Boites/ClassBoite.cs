using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    #region Enum
    public enum Couleurs { blanc, bleu, vert, jaune, orange, rouge, marron }
    public enum Matières { carton, plastique, bois, métal }
    #endregion
    public class Boite
    {
        #region Champs privés
        private Etiquette _etiquetteDest;
        private Etiquette _etiquetteFragile;
        private static int _nbObjet;
        #endregion
        //private static int _nbObjetsCrees = 0;
        //public static int NbObjets
        //{
        //    get { return _nbObjetsCrees; }
        //}

        #region Constructeur
        public Boite()
        {
            _nbObjet++;
            //Articles = new ArrayList();
            Articles = new List<Article>();
            Dico = new Dictionary<int, Article>();
        }
        /// <summary>
        /// Constructeur avec couleur en paramètre
        /// </summary>
        /// <param name="couleur"></param>
        public Boite(Couleurs couleur) : this()
        {
            Hauteur = 30;
            Longueur = 30;
            Largeur = 30;
            Couleur = couleur;
            Matière = Matières.métal;
        }
        public Boite(double hauteur, double longueur, double largeur) : this()
        {
            Hauteur = hauteur;
            Longueur = longueur;
            Largeur = largeur;
            

        }

        public Boite(double hauteur, double longueur, double largeur, Matières matière) : this(hauteur, longueur, largeur)
        {
            Matière = matière;
        }
        public Boite(Couleurs couleur, Matières matière) : this(couleur)
        {
            Matière = matière;
        }

        #endregion

        #region Méthodes publiques
        public void Etiqueter(string destinataire)
        {
            Etiquette Et1 = new Etiquette() { couleur = Couleurs.blanc, format = Formats.L, texte = destinataire };
            _etiquetteDest = Et1;
        }

        public void Etiqueter(string destinataire, bool fragile)
        {
            Etiqueter(destinataire);
            if (fragile)
            {
                Etiquette Et2 = new Etiquette() { couleur = Couleurs.rouge, format = Formats.S, texte = destinataire + "FRAGILE" };
                _etiquetteFragile = Et2;
            }
        }

        public void Etiqueter(Etiquette etiquettedest, Etiquette etiquettefragile)
        {
            _etiquetteDest = etiquettedest;
            _etiquetteFragile = etiquettefragile;
        }

        public bool Compare(Boite autreBoite)
        {
            return (this.Hauteur == autreBoite.Hauteur && this.Largeur == autreBoite.Largeur
                && this.Longueur == autreBoite.Longueur && this.Couleur == autreBoite.Couleur
                && this.Matière == autreBoite.Matière);
        }
        #endregion

        #region propriété
        public Etiquette EtiquetteDest { get { return _etiquetteDest; } set { _etiquetteDest = value; } }
        public Etiquette EtiquetteFragile { get { return _etiquetteFragile; } set { _etiquetteFragile = value; } }
        public static int NbObjet { get { return _nbObjet; } }
        public double Hauteur { get; }
        public double Largeur { get; }
        public double Longueur { get; }

        public Couleurs Couleur { get; set; }
        public Matières Matière { get; set; }

        //public ArrayList Articles { get; }
        public List<Article> Articles { get; } //Liste générique, on définit le type d'objet à mettre dans la liste
        public Dictionary<int,Article> Dico { get; }
        public SortedDictionary<int, Article> DicoTrié { get; } //Le dictionnaire est tout le temps trié
        public double Volume
        {
            get
            {
                return Hauteur * Largeur * Longueur;
            }
        }

        #endregion
    }
}
