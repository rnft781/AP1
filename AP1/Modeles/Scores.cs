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
        private int _score;
        private List<Jeux> _lesJeux;
        #endregion
        #region Constructeurs
        public Scores(int score)
        {
            _score = score;
            _lesJeux = new List<Jeux>();
        }
        #endregion
        #region Getters/Setters
        public int Score { get => _score; set => _score = value; }
        public List<Jeux> LesJeux { get => _lesJeux; set => _lesJeux = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
