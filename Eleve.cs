using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rallyeLecture
{
    
    class Eleve
    {
        string nom, prenom, login, passWord;
        static Random random = new Random();
        private PassWordType type;
        private long id;

        public string Nom
        {
            get { return nom; }
        }

        public string Prenom
        {
            get { return prenom; }
        }

        //Accesseur retournant le mot de passe
        public string PassWord
        {
            get { return passWord; }

        }
        //Accesseur retournant le login
        public string Login
        {
            get { return login; }

        }
        //Constructeur eleve
        public Eleve(string nom, string prenom, string login, PassWordType type)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.passWord = GetNewPassWord(type);
        }

        public Eleve(string nom, string prenom, string login, PassWordType type,long id)
        {
            // TODO: Complete member initialization
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.type = type;
            this.id = id;
            this.passWord = GetNewPassWord(type);
        }

        //Méthode permetant de créer un mot de passe aléatoire
        static private string GetPassWordAleatoire()
        {
            string mdpAleatoire = "";

            List<string> choix = new List<string> { "minuscule", "majuscule", "chiffre", "special", "lettre", "lettre", "lettre", "lettre", "lettre" };
            char[] minuscule = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] majuscule = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] chiffre = "123456789".ToCharArray();
            char[] special = "&*-_@".ToCharArray();
            int i = random.Next(choix.Count);

            while (mdpAleatoire.Count() != 9)
            {

                switch (choix[i])
                {
                    case "minuscule":
                        choix.RemoveAt(i);
                        mdpAleatoire += minuscule[random.Next(minuscule.Length)];

                        break;

                    case "majuscule":
                        choix.RemoveAt(i);
                        mdpAleatoire += majuscule[random.Next(majuscule.Length)];

                        break;

                    case "chiffre":
                        choix.RemoveAt(i);
                        mdpAleatoire += chiffre[random.Next(chiffre.Length)];
                        break;

                    case "special":
                        choix.RemoveAt(i);
                        mdpAleatoire += special[random.Next(special.Length)];
                        break;

                    case "lettre":
                        choix.RemoveAt(i);
                        switch (random.Next(1))
                        {
                            case 0:

                                mdpAleatoire += minuscule[random.Next(minuscule.Length)];
                                break;
                            case 1:

                                mdpAleatoire += majuscule[random.Next(majuscule.Length)];
                                break;
                        }

                        break;
                }
                i = random.Next(0, choix.Count);
            }
            return mdpAleatoire;
        }
        //Méthode permetant de créer un mot de passe Construit (première lettre du prénom + nom de famille)
        private string GetPassWordConstruit()
        {

            return (this.prenom[0] + this.nom);
        }

        //Méthode permettant de faire appel au méthode de génération de mdp selon le type de mdp choisi (construit ou aléatoire)
        public string GetNewPassWord(PassWordType type)
        {
            string choixType;
            if (type == PassWordType.Construit)
            {

                choixType = GetPassWordConstruit();

            }

            else
            {

                choixType = GetPassWordAleatoire();
            }

            return choixType;

        }

        public string ToString()
        {
            return string.Format("nom : {0}, prenom {1}, login {2}, mot de passe {3}", this.nom, this.prenom, this.login, this.passWord);
        }
    }
}

