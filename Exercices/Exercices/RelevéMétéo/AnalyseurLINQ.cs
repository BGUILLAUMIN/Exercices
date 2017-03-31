using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace RelevéMétéo
{
    public class AnalyseurLINQ
    {
        private List<DonnéesMois> _data;
        public List<DonnéesMois> Data
        {
            get { return _data; }
        }

        public AnalyseurLINQ()
        {
            _data = new List<DonnéesMois>();
        }

        public void ChargerDonnées()
        {
            string chemin = @"..\..\DonnéesMétéoParis.txt";

            int cpt = 0;
            using (StreamReader str = new StreamReader(chemin))
            {
                string ligne;

                while ((ligne = str.ReadLine()) != null)
                {
                    cpt++;
                    if (cpt == 1) continue; // On n'analyse pas la première ligne car elle contient les en-têtes

                    var tab = ligne.Split('\t');
                    try
                    {
                        var donnéesMois = new DonnéesMois
                        {
                            Mois = DateTime.Parse(tab[0]),
                            TMin = double.Parse(tab[1]),
                            TMax = double.Parse(tab[2]),
                            Précipitations = double.Parse(tab[3]),
                            Ensoleillement = double.Parse(tab[4])
                        };

                        // Ajout des données du mois à la liste
                        Data.Add(donnéesMois);
                    }
                    catch (FormatException)
                    {
                        // On ignore simplement la ligne
                        Console.WriteLine("Erreur de format à la ligne suivante :\r\n{0}", ligne);
                    }
                }
            }
        }

        public string AfficherStats()
        {
            // mois de la température min la plus basse
            var moisTempMin = Data.Where(m => m.TMin == Data.Min(t => t.TMin)).First();

            // Sommes des précipitations de l'année 2016

            var sommePrecipitations = Data.Where(t => t.Mois.Year == 2016).Sum(m => m.Précipitations);

            // Durée d'ensoleillement moyenne du mois de Juillet sur toutes les années
            var duréeEnsoleillement = Data.Where(t => t.Mois.Month == 07).Average(m => m.Ensoleillement);

            // Précipitations moyennes par année         

            foreach (var a in Data.Select(d => d.Mois.Year).Distinct()) //Distingues les années dans Data
            {
                var précipicationMoyAnnée = Data.Where(t => t.Mois.Year == a).Average(m => m.Précipitations);
            }


            return string.Format(@"Mois où la température est minimal est la plus basse : {0}, avec {1}°C
Sommes des précipitations de l'année 2016 : {2}mm
Durée ensoleillement moyen des mois de juillet : {3}h
Précipitation moyennes par année : "
, moisTempMin.Mois.ToString("MMMM yyyy"),moisTempMin.TMin, sommePrecipitations,duréeEnsoleillement);

        }
    }

    /// <summary>
    /// Classe contenant les données d'un mois de relevé météo
    /// </summary>
    public class DonnéesMois
    {
        public DateTime Mois { get; set; }
        public double TMin { get; set; }
        public double TMax { get; set; }
        public double Précipitations { get; set; }
        public double Ensoleillement { get; set; }
    }
}
