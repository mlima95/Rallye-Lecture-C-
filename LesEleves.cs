using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace rallyeLecture
{
    class LesEleves
    {
        List<Eleve> lesEleves;
        //Constructeur les elèves
        public LesEleves()
        {

            lesEleves = new List<Eleve>();
        }
        //Méthode permettant de créer un fichier csv des élèves contenant le login et aussi le mot de passe 
        public void CreateCsvPasswordFile(string nomFichier)
        {

            StreamWriter writer = new StreamWriter(nomFichier+"test.csv");
            writer.WriteLine("login;password");
            for (int i = 0; i < lesEleves.Count; i++)
            {
                writer.WriteLine("{0};{1}",lesEleves[i].Login,lesEleves[i].PassWord);
            }
            writer.Close();
        }

        //Méthode permettant de lire un fichier csv contenant la liste des élèves et génère une collection d'élèves avec leur mot de passe
        public List<Eleve> LoadCsv(PassWordType type,long id)
        {
            StreamReader reader = new StreamReader(@"U:\RallyeLecture\maClasseCm2_2018.csv");
            
            while (!reader.EndOfStream)
            {
                var ligne = reader.ReadLine();
                var values = ligne.Split(';');
                string login;
                login = values[1] + values[0] + "@sio.jjr.fr";
                Eleve unEleve = new Eleve(values[0], values[1], login, type,id);
                lesEleves.Add(unEleve);
            }
            return lesEleves;
        }
    }
}
