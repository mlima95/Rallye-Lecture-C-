using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rallyeLecture
{
    class Classe
    {
        
        private int idEnseignant, idNiveau;
        private string anneeScolaire;
        //Constructeur Classe
        public Classe(int idEnseignant, string anneeScolaire, int idNiveau)
        {
            this.idEnseignant = idEnseignant;
            this.anneeScolaire = anneeScolaire;
            this.idNiveau = idNiveau;
        }

        
        
        //Accesseur retournant l'id de l'enseignant 
        public int IdEnseignant
        {
            get { return idEnseignant; }
        }
        //Accesseur retournant l'id du niveau de l'élève
        public int IdNiveau
        {
            get { return idNiveau; }
        }
        //Accesseur retournant l'anneeScolaire 
        public string AnneeScolaire
        {
            get { return anneeScolaire; }
        }

        
    }
}
