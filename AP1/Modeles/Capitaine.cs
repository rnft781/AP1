using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{
    public class Capitaine : Eleves
    {
        #region Proprietes
        private int _nb1indice;
        private int _idCapitaine;
        #endregion
        #region Constructeurs
        public Capitaine(int id, string nom, string mdp, Statut statut, int nb1indice, int idCapitaine) : base(id, nom, mdp, statut)
        {
            _nb1indice = nb1indice;
            _idCapitaine = idCapitaine;
        }
        #endregion
        #region Getters/Setters
        public int Nb1indice { get => _nb1indice; set => _nb1indice = value; }
        public int IdCapitaine { get => _idCapitaine; set => _idCapitaine = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
