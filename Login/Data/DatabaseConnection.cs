using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login.Data
{
    class DatabaseConnection
    {

        public static string conn;
        public static MySqlConnection connect;

        public static void db_connection()
        {
            try
            {
                conn = "Server=192.168.0.102;Database=encyclopedicgame;Uid=;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
           /* finally{
                try
                {
                    connect.Close();
                }
                catch (MySqlException mEx) { 
                
                
                }

            
            }*/

        }
    }
}
