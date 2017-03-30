using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            //var carte = new Carte (101)
            //{
            //    NomTitulaire = "Gabin",
            //    PrénomTitulaire = "Jean",
            //    DateDernierRenouvellement = new DateTime(2015, 09, 30),
            //    NumCarte = 101000,
            //    CodeSecret = 4569,
            //    DateExpiration = new DateTime(2017, 09, 30)
            //};

            //var chq = new Chéquier (102)
            //{
            //    NomTitulaire = "Delon",
            //    PrénomTitulaire = "Alain",
            //    DateDernierRenouvellement = new DateTime(2015, 02, 28),
            //    NombreChèques = 25,
            //    NumPremierChèque = 102001
            //};

            MoyenPaiement[] tabMP = new MoyenPaiement[4];
            tabMP[0] = new Carte(456);
            tabMP[1] = new Chéquier (455);
            tabMP[2] = new Carte(101);
            tabMP[3] = new Chéquier(126);


         

            //DateTime dt = new DateTime(2017, 02, 25);
            //CompteBancaire cb = new CompteBancaire(dt, TypeCompte.Courant);   //Instanciation de la classe, création d'un objet de la class CompteBancaire
            //cb.DécouvertAutorisé = -700;
            //cb.Créditer(1000);
            //Console.WriteLine("solde courant : {0}", cb.SoldeCourant);
            //cb.Débiter(600);
            //Console.WriteLine("solde courant : {0}", cb.SoldeCourant);
            //cb.Débiter(2000);
            //Console.WriteLine("solde courant : {0}", cb.SoldeCourant);

            //CompteBancaire ce = new CompteBancaire(DateTime.Today, TypeCompte.Courant);
            //CompteBancaire[] tabComptes = new CompteBancaire[3];
            //tabComptes[0] = new CompteBancaire(TypeCompte.Courant);
            //tabComptes[1] = new CompteBancaire(TypeCompte.Epargne);
            //tabComptes[2] = new CompteBancaire(TypeCompte.PEA);

            Console.ReadKey();
        }
    }

    public enum TypeCompte { Courant, Epargne, PEA, PEE }       //Type énuméré public, pour être utilisé il doit être de la même accessibilité que la class qui l'utilise

    public class CompteBancaire              //Création de la classe CompteBancaire
    {
        #region Champs privés                //Permet la lisibilité du code : snippet  Ctrl + M + O : Masque toutes les régions, Ctrl + M + L fait l'inverse
        private bool _aDécouvert;            //Les champs privés sont précèdé du underscore "_"
        private DateTime _dateCréation;
        private DateTime _dateCloture;
        private decimal _soldeCourant;
        private decimal _decouvertAutorisé;
        private TypeCompte _type;
        #endregion

        public CompteBancaire(TypeCompte type)             //Constructeur de la class CompteBancaire
        {
            _dateCréation = DateTime.Today;
            _type = type;
        }
        /// <summary>
        /// Création d'un compte avec date de création
        /// </summary>
        /// <param name="dateCréa"></param>
        public CompteBancaire(DateTime dateCréa, TypeCompte type)    //La création de plusieurs constructeurs s'appelle la surcharge
        {
            _dateCréation = dateCréa;
            _type = type;
        }
        /// <summary>
        /// Création d'un compte avec date de création et solde courant
        /// </summary>
        /// <param name="dateCréa"></param>
        /// <param name="SoldeCourant"></param>
        public CompteBancaire(DateTime dateCréa, decimal SoldeCourant)
        {
            _dateCréation = DateCréation;
            _soldeCourant = SoldeCourant;
        }

        #region Propriétés

        public bool Adécouvert                  //Nom des propriétés commence par une majuscule  Raccourci propriété prop --> tab --> tab
                                                //Les propriétés ne sont pas appelées avec des parenthèse contrairement aux méthodes
        {
            get { return _aDécouvert; }
        }

        public DateTime DateCloture
        {
            get { return _dateCloture; }
        }
        public DateTime DateCréation
        {
            get { return _dateCréation; }
        }

        public decimal SoldeCourant
        {
            get { return _soldeCourant; }
        }

        public decimal DécouvertAutorisé                //Déclaration d'une propriété en get/set
        {
            get { return _decouvertAutorisé; }
            set { _decouvertAutorisé = value; }
        }
        #endregion

        #region Méthodes privées
        private int CalculerAncienneté()
        {
            return (DateTime.Today - _dateCréation).Days;   //A l'intérieur d'une classe on peut avoir accès aux champs privées
                                                            //(...).Days permet de retourner l'information de l'objet DateTime en nombre de jour
        }
        private decimal CalculerIntérêts()
        {
            return 0;
        }
        private decimal CalculerSolde()
        {
            return _soldeCourant + CalculerIntérêts();
        }
        #endregion

        #region Méthodes publiques
        public void Cloturer()
        {
            _dateCloture = DateTime.Today;
            CalculerSolde();
        }
        public void Créditer(decimal montant)
        {
            _soldeCourant += montant;
        }
        public void Débiter(decimal montant)
        {
            _soldeCourant -= montant;
            if (_soldeCourant < _decouvertAutorisé) _soldeCourant -= 5;
            if (_soldeCourant < 0) _aDécouvert = true;
        }
        #endregion

    }
}
