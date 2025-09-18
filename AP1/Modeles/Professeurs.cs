using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{
    public class Professeurs
    {
        #region Proprietes
        private int _idProfesseur;
        private Suivi _leSuivi;
        #endregion
        #region Constructeurs
        public Professeurs(int idProfesseur, Suivi leSuivi)
        {
            _idProfesseur = idProfesseur;
            _leSuivi = leSuivi;
        }
        #endregion
        #region Getters/Setters
        public int IdProfesseur { get => _idProfesseur; set => _idProfesseur = value; }
        public Suivi LeSuivi { get => _leSuivi; set => _leSuivi = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
