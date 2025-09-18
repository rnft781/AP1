using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{
    public class Competition
    {
        #region Proprietes
        private int _idCompetition;
        private List<Equipes> lesEquipes;
        #endregion
        #region Constructeurs
        public Competition(int idCompetition)
        {
            _idCompetition = idCompetition;
            lesEquipes = new List<Equipes>();
        }
        #endregion
        #region Getters/Setters
        public int IdCompetition { get => _idCompetition; set => _idCompetition = value; }
        public List<Equipes> LesEquipes { get => lesEquipes; set => lesEquipes = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
