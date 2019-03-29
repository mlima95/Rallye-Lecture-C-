using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace rallyeLecture
{
    class TableEnseignant
    {
        private MySqlConnection cnx;
        //Permet de recupérer un enseignant par son login 
        public Enseignant GetByLogin(string login)
        {
            this.cnx = ConnectionMySql.GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnx;
            cnx.Open();
            cmd.CommandText = "select e.id,nom,prenom,username,pass from enseignant e inner join aauth_users a on e.idAuth=a.id where login=@login";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@login", MySqlDbType.String);
            cmd.Parameters["@login"].Value = login;
            MySqlDataReader reader = cmd.ExecuteReader();
            Enseignant enseignant;
            reader.Read();
            enseignant = new Enseignant((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
            cnx.Close();
            return enseignant;
            
        }
    }
}
