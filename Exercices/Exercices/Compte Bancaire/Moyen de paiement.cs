using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire
{
    public abstract class MoyenPaiement : IRenouvelable
    {
        #region Propriétés automatiques
        public long NumCompte { get; set; }
        public string NomTitulaire { get; set; }
        public string PrénomTitulaire { get; set; }
        public DateTime DateRenouvellement { get; private set; }

        #endregion

        #region Constructeurs
        public MoyenPaiement()
        {

        }
        public MoyenPaiement(long numCpt)
        {
            NumCompte = numCpt;
        }
        #endregion

        #region Méthode

        public override string ToString()           //override puisqu'on redéfinit la méthode Tostring de la classe string 
        {
            //return base.ToString();               //La méthode ToString de la class string retour le nom de la classe instancier
            return string.Format("Moyen de paiement associé au compte {0} de {1} {2}, renouvelé le {3:d}\n", NumCompte,
                PrénomTitulaire, NomTitulaire, DateRenouvellement);
        }
        public abstract string Payer();

        public virtual void Renouveler(DateTime date)
        {
            DateRenouvellement = date;
        }
        #endregion

    }

    class Carte : MoyenPaiement
    {
        #region Propriété auto
        public long NumCarte { get; set; }
        public DateTime DateExpiration { get; set; }
        public int CodeVérif { get; set; }
        public int CodeSecret { get; set; }

        #endregion

        #region Constructeur
        public Carte()
        {

        }
        public Carte(long numCpt) : base(numCpt)
        {
        }

        #endregion

        #region Méthodes
        public override void Renouveler(DateTime date)   //Par défaut override = virtual si cette classe servait de mère
        {
            base.Renouveler(date);
            DateExpiration = DateExpiration.AddYears(2);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Carte de N°{0}, de code secret {1} qui expire le {2:d}",NumCarte,CodeSecret, DateExpiration);
        }

        public override string Payer()
        {
            return string.Format("Le commerçant saisit le montant.\nJe compose mon code.\nLe commerçant me donne la facture");
        }

        #endregion
    }

    class Chéquier : MoyenPaiement
    {
        #region Propriété
        public int NombreChèques { get; set; }
        public long NumPremierChèque { get; set; }
        #endregion

        #region Constructeur
        public Chéquier(long numCpt) : base(numCpt)           //Appelle le constructeur de l'ancêtre
        {

        }

        #endregion

        #region Méthodes
        public override void Renouveler(DateTime date)
        {
            base.Renouveler(date);
            NumPremierChèque += NombreChèques;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Chèquier de {0} chèques, dont le premier à le N°{1}", NombreChèques, NumPremierChèque);
        }

        public override string Payer()
        {
            return string.Format("Le commerçant saisit le montant.\nJe renseigne et je signe mon chèque.\n");
        }
        #endregion
    }
}


