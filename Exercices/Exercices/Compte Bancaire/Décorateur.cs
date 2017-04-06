using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire
{
    public abstract class Décorateur : CompteBancaire
    {
        protected CompteBancaire compte;

        public Décorateur(CompteBancaire compte):base(TypeCompte.Courant)
        {
            this.compte = compte;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
    public class Alert : Décorateur
    {
        protected string alert;

        //Constructeur
        public Alert(CompteBancaire compte, string mesalert) : base(compte)
        {
            alert = mesalert;
        }

        public override string ToString()
        {
            return string.Format(alert) + base.ToString();
        }
    }
}
