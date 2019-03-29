using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace rallyeLecture
{
    public partial class alimentationBdd : Form
    {
        public alimentationBdd()
        {
            InitializeComponent();
            ConnectionMySql.Connection("root","siojjr","rallyeLecture","172.16.0.174");
            MySqlConnection cnx = ConnectionMySql.GetConnection();
            cbRepertoire.Click += new EventHandler(cbRepertoire_Click);
            cbAleatoire.Click += new EventHandler(cbAleatoire_Click);
            cbConstruit.Click += new EventHandler(cbConstruit_Click);
            btnLancerIntegration.Click += new EventHandler(btnLancerIntegration_Click);
            TableNiveau tableNiveau = new TableNiveau();
            List<Niveau> niveau=tableNiveau.GetAll();
            foreach (Niveau liste in niveau)
            {
                cmbNiveau.Items.Add(liste.NiveauScolaire);
            }

            List<Eleve> Nom = new List<Eleve>();
            LesEleves LesEleves = new LesEleves();
            //PassWordType type = PassWordType.Aleatoire;
            //Nom = LesEleves.LoadCsv(type);

            // for (int i = 0; i < Nom.Count; i++)
            //  {
            //  cblIntegrer.Items.Add(Nom[i].ToString());

            //  }
            //LesEleves.CreateCsvPasswordFile();

        }



        void btnLancerIntegration_Click(object sender, EventArgs e)
        {
            string s = folderBrowserDialog1.SelectedPath + " / " + Convert.ToString(cblIntegrer.SelectedItem);
            LesEleves LesEleves = new LesEleves();
            PassWordType type;
            if (tbAnnee.Text != "")
            {
                if (cbAleatoire.Checked == true || cbConstruit.Checked == true)
                {
                    if (cbAleatoire.Checked == true)
                    {
                        type = PassWordType.Aleatoire;

                    }
                    else
                    {
                        type = PassWordType.Construit;

                    }
                    MySqlConnection cnx = ConnectionMySql.GetConnection();
                    MySqlCommand cmd = new MySqlCommand();
                    Enseignant enseignant = new Enseignant();
                    TableEnseignant uneTableEnseignant = new TableEnseignant();
                    enseignant = uneTableEnseignant.GetByLogin("enseignant@sio.jjr.fr");
                    Classe uneClasse=new Classe(enseignant.Id,tbAnnee.Text,cmbNiveau.SelectedIndex);
                    TableClasse uneTableClasse = new TableClasse();
                    long id = uneTableClasse.Insert(uneClasse);

                    
                    // créer la classe dans la base de donnée.
                    // on récupère l'id de la classe
                    List<Eleve> Nom = LesEleves.LoadCsv(type,id); //Mettre en paramètre id classe

                    TableEleve uneTableEleve = new TableEleve();

                    foreach (Eleve eleve in Nom)
                    {
                        uneTableEleve.Insert(eleve, id);
                    }

                    LesEleves.CreateCsvPasswordFile(tbAnnee.Text);


                    MessageBox.Show("Intégration réussit");
                }
                else
                {
                    MessageBox.Show("Intégration échoue");
                }


            }
            else
            {
                MessageBox.Show("Intégration échoue");
            }
        }

        private void cbConstruit_Click(object sender, EventArgs e)
        {
            cbAleatoire.Checked = false;
        }

        private void cbAleatoire_Click(object sender, EventArgs e)
        {
            cbConstruit.Checked = false;
        }


        private void cbRepertoire_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            cbRepertoire.Text = folderBrowserDialog1.SelectedPath;
            DirectoryInfo dossier = new DirectoryInfo(@cbRepertoire.Text);
            FileInfo[] fichiers = dossier.GetFiles();

            foreach (FileInfo fichier in fichiers)
            {
                cblIntegrer.Items.Add(fichier.Name);
            }
        }
    }
}
