using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class MsgrDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(Msgr msgr)
        {
            // query take variables $
            string query = $"INSERT INTO msgr (msgr_name) " +
                           $"Values ('{msgr.Name}')";
            // check if the connection is open first
            if (databaseHandler.openConnection() == true)
            {
                //fire the query with the connection
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                // send the query
                cmd.ExecuteNonQuery();
                // close the connection if it is open
                databaseHandler.closeConnection();
                return true;
            }
            return false;
        }

        public static bool Update(Msgr msgr)
        {
            string query = $"UPDATE msgr SET msgr_name='{msgr.Name}'" +
                           $" WHERE msgr_id='{msgr.Id}'"; // create the query


            if (databaseHandler.openConnection()) // check the connection
            {

                MySqlCommand cmd = new MySqlCommand(); //  create a sql command
                cmd.CommandText = query; // use the query
                cmd.Connection = databaseHandler.connection; // use the connection
                cmd.ExecuteNonQuery(); //Execute the Query
                databaseHandler.closeConnection(); // close the connection
                return true;
            }
            return false;
        }

        public static void Delete(int id)
        {
            databaseHandler.Delete("msgr", "msgr_id", id);
        }

        public static void Delete(Msgr msgr)
        {
            Delete(msgr.Id);
        }

        public static Msgr Get(int id)
        {
            String query = "SELECT * FROM msgr WHERE msgr_id = '" + id + "'";
            Msgr msgr = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    msgr = new Msgr(reader.GetInt32(0), reader.GetString(1));
                }
            }
            return msgr;
        }

        public static List<Msgr> GetAll()
        {
            String query = "SELECT * FROM msgr";
            List<Msgr> list = new List<Msgr>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Msgr msgr = new Msgr(reader.GetInt32(0), reader.GetString(1));
                    list.Add(msgr);

                }
            }

            return list;
        }
    }
}
