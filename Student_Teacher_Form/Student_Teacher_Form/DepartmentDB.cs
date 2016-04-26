using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
    class DepartmentDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        /*public static bool Add(Department department)
        {
            // query take variables $
            string query = $"INSERT INTO department(department_name, department_number_of_students)" +
                           $" VALUES ({department.Name},{department.NumberOfStudents})";
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

        public static bool Update(Department department)
        {
            string query = $"UPDATE department SET department_name='{department.Name}',department_number_of_students='{department.NumberOfStudents}' WHERE department_id='{department.Id}' LIMIT 1"; // create the query


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
            databaseHandler.Delete("department", "department_id", id);
        }

        public static void Delete(Department department)
        {
            Delete(department.Id);
        }*/

        public static Department Get(int id)
        {
            String query = "SELECT * FROM department WHERE department_id = '" + id + "' LIMIT 1";
            Department department = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    department = new Department(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(1));
                }
            }
            return department;
        }

        public static List<Department> GetAll()
        {
            String query = "SELECT * FROM department";
            List<Department> list = new List<Department>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Department department = new Department(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(1));
                    list.Add(department);

                }
            }

            return list;
        }
    }
}
