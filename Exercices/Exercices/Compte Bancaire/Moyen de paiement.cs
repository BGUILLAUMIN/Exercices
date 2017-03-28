using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire
{
    class MoyenPaiement
    {
        public long NumCompte { get; set; }
        public string NomTitulaire { get; set; }
        public string PrénomTitulaire { get; set; }
        public DateTime DateDernierRenouvellement { get; set; }

        public MoyenPaiement()
        {

        }

        public MoyenPaiement(long numCpt)
        {
            NumCompte = numCpt;
        }
        public virtual void Renouveler()
        {
            DateDernierRenouvellement = DateTime.Today;
        }

        public override string ToString()           //override puisqu'on redéfinit la méthode Tostring de la classe string 
        {
            //return base.ToString();               //La méthode ToString de la class string retour le nom de la classe instancier
            return string.Format("Moyen de paiement associé au compte {0} de {1} {2}, renouvelé le {3:d}\n", NumCompte,
                PrénomTitulaire, NomTitulaire, DateDernierRenouvellement);
        }
    }

    class Carte : MoyenPaiement
    {
        public long NumCarte { get; set; }
        public DateTime DateExpiration { get; set; }
        public int CodeVérif { get; set; }
        public int CodeSecret { get; set; }
        public Carte()
        {

        }
        public Carte(long numCpt) : base(numCpt)
        {
        }
        public override void Renouveler()   //Par défaut override = virtual si cette classe servait de mère
        {
            base.Renouveler();
            DateExpiration = DateExpiration.AddYears(2);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Carte de N°{0}, de code secret {1} qui expire le {2:d}",NumCarte,CodeSecret, DateExpiration);
        }
    }

    class Chéquier : MoyenPaiement
    {
        public int NombreChèques { get; set; }
        public long NumPremierChèque { get; set; }
        public Chéquier(long numCpt) : base(numCpt)           //Appelle le constructeur de l'ancêtre
        {

        }
        public override void Renouveler()
        {
            base.Renouveler();
            NumPremierChèque += NombreChèques;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Chèquier de {0} chèques, dont le premier à le N°{1}", NombreChèques, NumPremierChèque);
        }
    }
}


