using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
    class ManagerDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(Manager manager)
        {
            // query take variables $
            string query = $"INSERT INTO manager (manager_username, manager_password) Values ('{manager.Username}','{manager.Password}')";
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

        public static bool Update(Manager manager)
        {
            string query = $"UPDATE manager SET manager_username='{manager.Username}',manager_password='{manager.Password}' WHERE manager_id='{manager.Id}'"; // create the query


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
            databaseHandler.Delete("manager", "manager_id", id);
        }

        public static void Delete(Manager manager)
        {
            Delete(manager.Id);
        }

        public static Manager Get(int id)
        {
            String query = "SELECT * FROM manager WHERE manager_id = '" + id + "'";
            Manager manager = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    manager = new Manager(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                }
            }
            return manager;
        }

        public static List<Manager> GetAll()
        {
            String query = "SELECT * FROM manager";
            List<Manager> list = new List<Manager>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Manager manager = new Manager(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    list.Add(manager);

                }
            }

            return list;
        }
    }
}
