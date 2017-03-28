using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    public enum Formats { XS, S, M, L, XL}
    public class Etiquette
    {
        private static int _nbObjet;
        public static int NbObjets { get { return _nbObjet; } }
        #region Propriété
        public string texte { get; set; }
        public Couleurs couleur { get; set; }
        public Formats format { get; set; }
        #endregion
        public Etiquette()
        {
            _nbObjet++;
        }
    }
}
