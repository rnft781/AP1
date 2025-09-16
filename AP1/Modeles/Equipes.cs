using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{
    public class Equipes
    {
        #region Proprietes
        private int _idEquipe;
        private int _nbPlaces;
        private int _score;
        #endregion
        #region Constructeurs
        public Equipes(int idEquipe, int nbPlaces, int score)
        {
            _idEquipe = idEquipe;
            _nbPlaces = nbPlaces;
            _score = score;
        }
        #endregion
        #region Getters/Setters
        public int IdEquipe { get => _idEquipe; set => _idEquipe = value; }
        public int NbPlaces { get => _nbPlaces; set => _nbPlaces = value; }
        public int Score { get => _score; set => _score = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
