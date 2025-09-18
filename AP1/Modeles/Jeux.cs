using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{
    public class Jeux
    {
        #region Proprietes
        private int _idJeux;
        private string _nomJeux;
        private TypeJeux _typeJeux;
        private string _statut;
        public enum TypeJeux { Type1 = 1, Type2 = 2, Type3 = 3 }
        #endregion
        #region Constructeurs
        public Jeux(int idJeux, string nomJeux, TypeJeux typeJeux, string statut)
        {
            _idJeux = idJeux;
            _nomJeux = nomJeux;
            _typeJeux = typeJeux;
            _statut = statut;
        }
        #endregion
        #region Getters/Setters
        public int IdJeux { get => _idJeux; set => _idJeux = value; }
        public string NomJeux { get => _nomJeux; set => _nomJeux = value; }
        public TypeJeux _TypeJeux { get => _typeJeux; set => _typeJeux = value; }
        public string Statut { get => _statut; set => _statut = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
