using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace rallyeLecture
{
    static class ConnectionMySql
    {
        static private MySqlConnection cnx;

       static public void Connection(string user, string passWord,string database,string server)
        {

           string sConnection = "user=" + user + ";password=" + passWord + ";host=" + server + ";database=" + database + ";";
           ConnectionMySql.cnx = new MySqlConnection(sConnection);
        }

        static public MySqlConnection GetConnection()
        {

            return ConnectionMySql.cnx;
         }

   }
}
