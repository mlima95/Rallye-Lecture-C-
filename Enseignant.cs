using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rallyeLecture
{
    class Enseignant
    {
        int id;

        public int Id
        {
            get { return id; }
        }
        string nom,prenom,login,hashPassWord;

        //Constructeur enseignant
        public Enseignant(int id, string nom, string prenom, string login, string hashPassWord)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.hashPassWord = hashPassWord;
        }

        public Enseignant()
        {
            this.id = 0;
            this.nom = "";
            this.prenom = "";
            this.login = "";
            this.hashPassWord = "";
        }

    }
}
