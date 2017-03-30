using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public enum Energies { Aucune, Essence, Gazole, GPL, Electrique }
    public abstract class Véhicule : IComparable<Véhicule>
    {
        #region propriété
        public string Nom { get; }
        public int NombreRoue { get; }
        public Energies Energie { get; }
        public abstract double PRK { get; }
        public decimal Prix { get; set; }
        public Dictionary<string,Véhicule> Dico { get; set; }
        public SortedList<Véhicule,string> DicoTrié { get; set; }
        #endregion

        #region constructeurs
        public Véhicule(string nom, decimal prix)
        {
            Prix = prix;
            Nom = nom;
        }
        public Véhicule(string nom, int nbRoue, Energies energie, double prk)
        {
            Nom = nom;
            NombreRoue = nbRoue;
            Energie = energie;
        }
        #endregion

        #region méthodes public
        public virtual string Description()
        {
            return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {3}", Nom, NombreRoue, Energie);
        }

        public abstract void CalculerConso();

        public int CompareTo(Véhicule véhicule)
        {
            if (Prix < véhicule.Prix) return -1;
            else if (Prix == véhicule.Prix) return 0;
            else return 1;

        }
        public override string ToString()
        {
            return string.Format("{0}, {1} EUR", Nom,Prix);
        }

        //public int CompareTo(object obj)
        //{
        //    if (obj is Véhicule)
        //    {
        //        Véhicule V = (Véhicule)obj;
        //        if (this.PRK - V.PRK < 0) return -1;
        //        else if (this.PRK - V.PRK == 0) return 0;
        //        else return 1;
        //    }
        //    throw new ArgumentException();
        //}


        #endregion

    }

    public class Voiture : Véhicule
    {
        public override double PRK
        {
            get
            {
                return 0.35;
            }
        }
        #region Constructeur
        public Voiture(string nom, decimal prix) : base(nom, prix)
        {
            Dico = new Dictionary<string, Véhicule>();
            DicoTrié = new SortedList<Véhicule,string>();
        }
        public Voiture() : base("Voiture", 4, Energies.Gazole,50)
        {
            Dico = new Dictionary<string, Véhicule>();
            DicoTrié = new SortedList<Véhicule,string>();
        }
        #endregion

        #region méthode
        public override string Description()
        {
            return string.Format("Je suis une voiture\r\n") + base.Description();
        }
        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }

        public string Refaireparallélisme()
        {
            return string.Format("Parallélisme refait");
        }
    }
    #endregion


    public class Moto : Véhicule
    {
        public override double PRK
        {
            get
            {
                return 0.60;
            }
        }
        #region Constructeur
        public Moto(string nom, decimal prix) : base(nom, prix)
        {

        }
        public Moto() : base("Moto", 2, Energies.Essence,20)
        {

        }
        #endregion

        #region Méthode
        public override string Description()
        {
            return string.Format("Je suis une Moto\r\n") + base.Description();
        }

        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}

