using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class FinancialAffairsDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(FinancialAffairs financialAffairs)
        {
            // query take variables $
            string query = $"INSERT INTO financialAffairs (financialAffairs_paid, financialAffairs_rest) " +
                           $"Values ('{financialAffairs.Paid}','{financialAffairs.Rest}')";
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

        public static bool Update(FinancialAffairs financialAffairs)
        {
            string query = $"UPDATE financialAffairs SET financialAffairs_paid='{financialAffairs.Paid}',financialAffairs_rest='{financialAffairs.Rest}'" +
                           $" WHERE financialAffairs_id='{financialAffairs.Id}'"; // create the query


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
            databaseHandler.Delete("financialAffairs", "financialAffairs_id", id);
        }

        public static void Delete(FinancialAffairs financialAffairs)
        {
            Delete(financialAffairs.Id);
        }

        public static FinancialAffairs Get(int id)
        {
            String query = "SELECT * FROM financialAffairs WHERE financialAffairs_id = '" + id + "'";
            FinancialAffairs financialAffairs = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    financialAffairs = new FinancialAffairs(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));
                }
            }
            return financialAffairs;
        }

        public static List<FinancialAffairs> GetAll()
        {
            String query = "SELECT * FROM financialAffairs";
            List<FinancialAffairs> list = new List<FinancialAffairs>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FinancialAffairs financialAffairs = new FinancialAffairs(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));
                    list.Add(financialAffairs);

                }
            }

            return list;
        }
    }
}
