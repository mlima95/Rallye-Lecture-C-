using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace rallyeLecture
{
    class TableNiveau
    {
        private MySqlConnection cnx;
        private List<Niveau> lesNiveau=new List<Niveau>();

        //Permet de récuperer la collection des niveaux
        public List<Niveau> GetAll()
        {
            cnx = ConnectionMySql.GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            this.cnx.Open();
            cmd.Connection = this.cnx;
            cmd.CommandText = "niveau";
            cmd.CommandType = CommandType.TableDirect;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Niveau nv = new Niveau(Convert.ToInt32(reader[0]),Convert.ToString(reader[1]));
                lesNiveau.Add(nv);
            }
            this.cnx.Close();
            return lesNiveau;
            
        }
    }
}
