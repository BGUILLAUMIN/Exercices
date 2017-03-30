using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatutFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> ListePersonnel = new List<Personne>();
            List<Personne> ListeCDD_CHSCT = new List<Personne>();
            List<Personne> ListeCDI_DP = new List<Personne>();

            ListePersonnel.Add(new Personne("Abel", "TURPIN", Statuts.CDI));
            ListePersonnel.Add(new Personne("Achille", "BONNEAU", Statuts.CDD | Statuts.DP));
            ListePersonnel.Add(new Personne("Adelphe", "BLONDEL", Statuts.CDI | Statuts.DP | Statuts.CHSCT | Statuts.SYND));
            ListePersonnel.Add(new Personne("Aimé", "BLACK", Statuts.CDI));
            ListePersonnel.Add(new Personne("Aimée", "PERRIER", Statuts.CDI));
            ListePersonnel.Add(new Personne("Alain", "JORDAN", Statuts.CDD | Statuts.CHSCT));
            ListePersonnel.Add(new Personne("Alban", "BAUDRY", Statuts.CDD));
            ListePersonnel.Add(new Personne("Albert", "ORLEANS", Statuts.CDI | Statuts.DP | Statuts.SYND));
            ListePersonnel.Add(new Personne("Alexandra", "VALOIS", Statuts.CDI | Statuts.SYND));
            ListePersonnel.Add(new Personne("Alexandre", "WEST", Statuts.CDI | Statuts.DP | Statuts.CHSCT));

            foreach (var a in ListePersonnel)
            {
                if ((a.Statut & (Statuts.CDD | Statuts.CHSCT)) == (Statuts.CDD | Statuts.CHSCT)) ListeCDD_CHSCT.Add(a);
                else if ((a.Statut & (Statuts.CDI | Statuts.DP)) == (Statuts.CDI | Statuts.DP)) ListeCDI_DP.Add(a);
            }

            foreach (var a in ListeCDD_CHSCT)
            {
                Console.WriteLine(a);
            }

            foreach (var a in ListeCDI_DP)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            foreach (var a in ListeCDD_CHSCT)
            {
                a.Statut |= Statuts.CHSCT;
                Console.WriteLine(a);
            }

            foreach (var a in ListeCDI_DP)
            {
                a.Statut |= Statuts.CHSCT;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
