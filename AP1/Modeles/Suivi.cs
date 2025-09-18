using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{
    public class Suivi
    {
        #region Proprietes
        private int _tempsRestants;
        private List<Eleves> lesEleves;
        #endregion
        #region Constructeurs
        public Suivi(int tempsRestants)
        {
            _tempsRestants = tempsRestants;
            lesEleves = new List<Eleves>();
        }
        #endregion
        #region Getters/Setters
        public int TempsRestants { get => _tempsRestants; set => _tempsRestants = value; }
        public List<Eleves> LesEleves { get => lesEleves; set => lesEleves = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
