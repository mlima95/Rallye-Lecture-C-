using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rallyeLecture
{
    class Niveau
    {
        private int id;
        private string niveauScolaire;
        //Constructeur de Niveau
        public Niveau(int id, string niveauScolaire)
        {
            this.id = id;
            this.niveauScolaire = niveauScolaire;
        }
        //Accesseur retournant le niveau scolaire
        public string NiveauScolaire
        {
            get { return niveauScolaire; }
        }

        public int Id
        {
            get { return id; }
        }
    }
}
