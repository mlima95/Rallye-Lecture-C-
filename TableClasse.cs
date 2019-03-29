using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace rallyeLecture
{
    class TableClasse
    {
        private MySqlConnection cnx;
        private long lastId;

        public long LastId
        {
            get { return lastId; }
        }
        //Permet de d'insérer une nouvelle classe dans la table
        public long Insert(Classe classe)
        {
            long id;
            cnx = ConnectionMySql.GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cnx.Open();
            cmd.CommandText = "Insert into classe(idEnseignant,anneeScolaire,idNiveau) values(@idEnseignant,@annee,@idNiveau)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idEnseignant",MySqlDbType.Int32);
            cmd.Parameters["@idEnseignant"].Value=classe.IdEnseignant;
            cmd.Parameters.Add("@annee",MySqlDbType.String);
            cmd.Parameters["@annee"].Value = classe.AnneeScolaire;
            cmd.Parameters.Add("@idNiveau",MySqlDbType.Int32);
            cmd.Parameters["@idNiveau"].Value = classe.IdNiveau;
            cmd.ExecuteNonQuery();
            id=cmd.LastInsertedId;
            cnx.Close();
            lastId = id;
            // on récupère l'id
            return id;
        }
    }
}
