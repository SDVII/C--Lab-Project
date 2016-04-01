using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
    class TeacherDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }


        public static bool Add(Teacher teacher)
        {
            // query take variables $
            string query = $"INSERT INTO teacher (teacher_username,teacher_name,teacher_surname,teacher_password,teacher_email,teacher_msgr_id) Values ('{teacher.Username}','{teacher.Name}','{teacher.Surname}','{teacher.Password}','{teacher.Email}','{teacher.MsgrId}')";
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

        public static bool Update(Teacher teacher)
        {
            string query = $"UPDATE teacher SET teacher_username='{teacher.Username}',teacher_name='{teacher.Name}',teacher_surname='{teacher.Surname}',teacher_password='{teacher.Password}',teacher_email='{teacher.Email}',teacher_msgr_id='{teacher.MsgrId}' WHERE teacher_id='{teacher.Id}'"; // create the query


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
            databaseHandler.Delete("teacher", "teacher_id", id);
        }

        public static void Delete(Teacher teacher)
        {
            Delete(teacher.Id);
        }

        public static Teacher Get(int id)
        {
            String query = "SELECT * FROM teacher WHERE teacher_id = '" + id + "'";
            Teacher teacher = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    teacher = new Teacher(reader.GetInt32(0), reader.GetInt32(6), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
            }
            return teacher;
        }

        public static Teacher GetWithUsername(string username)
        {
            String query = "SELECT * FROM teacher WHERE teacher_username = '" + username.Trim() + "'";
            Teacher teacher = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    teacher = new Teacher(reader.GetInt32(0), reader.GetInt32(6), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
            }
            return teacher;
        }

        public static List<Teacher> GetAll()
        {
            String query = "SELECT * FROM teacher";
            List<Teacher> list = new List<Teacher>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Teacher teacher = new Teacher(reader.GetInt32(0), reader.GetInt32(6), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    list.Add(teacher);
                    
                }
            }

            return list;
        } 
    }
}
