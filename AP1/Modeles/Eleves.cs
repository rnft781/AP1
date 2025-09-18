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
        private Statut _statut;
     
        public enum Statut { Participe = 0, Elimine = 1};
        
        #endregion
        #region Constructeurs
        public Eleves(int id, string nom, string mdp)
        {
            _id = id;
            _nom = nom;
            _mdp = mdp;
            _statut = 0;
        }
        #endregion
        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Mdp { get => _mdp; set => _mdp = value; }
        public Statut _Statut { get => _statut; set => _statut = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
