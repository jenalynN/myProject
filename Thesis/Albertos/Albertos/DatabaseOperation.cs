using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Albertos
{
    class DatabaseOperation
    {
        static MySqlConnection con = new MySqlConnection("server=localhost;database=dbpizza;user=root");
        static MySqlCommand cd;
        static MySqlDataReader dr;

        public static void OpenConnection() {
            con.Open(); 
        }

        public static void CloseConnection()
        {
            con.Close();
        }

        public static MySqlDataReader ViewOrder(){
            cd = new MySqlCommand("select * from tborder",con);
            dr = cd.ExecuteReader();
            return dr;
        }
    }
}
