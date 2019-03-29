using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace rallyeLecture
{
    class TableEleve
    {
        MySqlConnection cnx;

        //Permet de créer un élève dans la table élève
        public void Insert(Eleve eleve,long idClasse)
        {
            //récupère l'id de la classe



            //récupère l'id du aauth_users
            cnx = ConnectionMySql.GetConnection();
            MySqlCommand cmd1 = new MySqlCommand();
            cmd1.Connection = cnx;
            cnx.Open();
            cmd1.CommandText = "select max(id) from aauth_users";
            cmd1.CommandType = CommandType.Text;
            int idAauth = Convert.ToInt32(cmd1.ExecuteScalar());
            cnx.Close();

            Hash pass = new Hash();
            

            //créer un utilisateur dans la table aauth_users
            cnx = ConnectionMySql.GetConnection();
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = cnx;
            cnx.Open();
            cmd2.CommandText = "insert into aauth_users(email,pass,username) values(@email,@passWord,@username) ";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("@email", MySqlDbType.String);
            cmd2.Parameters["@email"].Value = eleve.Prenom + eleve.Nom + "@sio.jjr.fr";
            cmd2.Parameters.Add("@username",MySqlDbType.String);
            cmd2.Parameters["@username"].Value = eleve.Prenom[0] + eleve.Nom;
            cmd2.Parameters.Add("@passWord",MySqlDbType.String);
            cmd2.Parameters["@passWord"].Value = pass.GetHashPassword(eleve.PassWord, idAauth+1);
            cmd2.ExecuteNonQuery();
            cnx.Close();

            cnx = ConnectionMySql.GetConnection();
            MySqlCommand cmd4 = new MySqlCommand();
            cmd4.Connection = cnx;
            cnx.Open();
            cmd4.CommandText = "insert into aauth_user_to_group(user_id,group_id) values(@idUser,@idGroup)";
            cmd4.CommandType = CommandType.Text;
            cmd4.Parameters.Add("@idUser", MySqlDbType.Int32);
            cmd4.Parameters["@idUser"].Value = idAauth+1;
            cmd4.Parameters.Add("@idGroup",MySqlDbType.Int32);
            cmd4.Parameters["@idGroup"].Value = 4;
            cmd4.ExecuteNonQuery();
            cnx.Close();

            TableClasse uneTableClasse = new TableClasse();
            idClasse = uneTableClasse.LastId;

            //créer un élève dans la table élève
            cnx = ConnectionMySql.GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cnx.Open();
            cmd.CommandText = "insert into eleve(idClasse,nom,prenom,login,idAuth) values(@idClasse,@nom,@prenom,@login,@idAuth)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idClasse", MySqlDbType.Int32);
            cmd.Parameters["@idClasse"].Value = idClasse;
            cmd.Parameters.Add("@nom", MySqlDbType.String);
            cmd.Parameters["@nom"].Value = eleve.Nom;
            cmd.Parameters.Add("@prenom", MySqlDbType.String);
            cmd.Parameters["@prenom"].Value = eleve.Prenom;
            cmd.Parameters.Add("@login", MySqlDbType.String);
            cmd.Parameters["@login"].Value = eleve.Login;
            cmd.Parameters.Add("@idAuth", MySqlDbType.Int32);
            cmd.Parameters["@idAuth"].Value = idAauth+1;
            cnx.Close();

        }
    }
}
