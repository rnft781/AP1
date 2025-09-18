using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{
    public class Eleves
    {
        #region Proprietes
        private int _id;
        private string _nom;
        private string _mdp;
        public enum statut { Participe = 0, Elimine = 1};
        private statut _statut;
        #endregion
        #region Constructeurs
        public Eleves(int id, string nom, string mdp)
        {
            _id = id;
            _nom = nom;
            _mdp = mdp;
            _statut = statut;
        }
        #endregion
        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Mdp { get => _mdp; set => _mdp = value; }
        public statut Statut { get => _statut; set => _statut = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
