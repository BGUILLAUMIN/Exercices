using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public enum Energies { Aucune, Essence, Gazole, GPL, Electrique } 
    class Véhicule
    {
        #region propriété
        public string Nom { get; }
        public int NombreRoue { get; }
        public Energies Energie { get; }
        #endregion
        #region constructeurs

        public Véhicule(string nom, int nbRoue, Energies energie)
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
        #endregion

    }

    class Voiture : Véhicule
    {
        #region Constructeur
        public Voiture() : base("Voiture", 4, Energies.Gazole)
        {

        }
        #endregion
        #region méthode
        public override string Description()
        {
            return string.Format("Je suis une voiture\r\n") + base.Description();
        }
        #endregion
    }

    class Moto : Véhicule
    {
        #region Constructeur
        public Moto() : base("Moto", 2, Energies.Essence)
        {

        }
        #endregion
        #region Méthode
        public override string Description()
        {
            return string.Format("Je suis une Moto\r\n") + base.Description();
        }
        #endregion

    }
}
