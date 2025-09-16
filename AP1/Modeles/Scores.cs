using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{
    public class Scores
    {
        #region Proprietes
        private List<Scores> lesScores;
        #endregion
        #region Constructeurs
        public Scores()
        {
            lesScores = new List<Scores>();
        }
        #endregion
        #region Getters/Setters
        public List<Scores> LesScores { get => lesScores; set => lesScores = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
