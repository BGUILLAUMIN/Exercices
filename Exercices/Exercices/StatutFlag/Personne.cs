using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatutFlag
{
    [Flags]
    public enum Statuts
    {
        Aucun = 0,
        CDI = 1,
        CDD = 2,
        DP = 4,
        CHSCT = 8,
        SYND = 16
    }
    public class Personne
    {
        public List<Personne> Liste { get; set; }
        public string Nom { get; }
        public string Prénom { get; }
        public Statuts Statut { get; set; }
        public Personne()
        {

        }
        public Personne(string prénom, string nom, Statuts statut)
        {
            Prénom = prénom;
            Nom = nom;
            Statut = statut;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} a le statut : {2}", Prénom, Nom, Statut);
        }
    }
}
