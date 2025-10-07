using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1.Modeles
{  
    public class User
    {
        #region propriete
        private int _id;
        private string _nom;
        private string _mdp;
        private string _statut;
        private Equipe _leEleve;
        private Equipe _laEquipe;

        #endregion
        #region constructeur
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Mdp { get => _mdp; set => _mdp = value; }
        public string Statut { get => _statut; set => _statut = value; }
        public Equipe LeEleve { get => _leEleve; set => _leEleve = value; }
        public Equipe LaEquipe { get => _laEquipe; set => _laEquipe = value; }
        #endregion
        #region getter/setter
        #endregion
        #region methode
        #endregion
    }
}
