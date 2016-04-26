using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class SectionDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        /*public static bool Add(Section section)
        {
            // query take variables $
            string query = $"INSERT INTO section (section_course_id, section_number, section_teacher_id) " +
                           $"Values ('{section.CourseId}','{section.Number}','{section.TeacherId}')";
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

        public static bool Update(Section section)
        {
            string query = $"UPDATE section SET section_course_id='{section.CourseId}',section_number='{section.Number}',section_teacher_id='{section.TeacherId}'" +
                           $" WHERE section_id='{section.Id}'"; // create the query


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
            databaseHandler.Delete("section", "section_id", id);
        }

        public static void Delete(Section section)
        {
            Delete(section.Id);
        }*/

        public static Section Get(int id)
        {
            String query = "SELECT * FROM section WHERE section_id = '" + id + "'";
            Section section = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    section = new Section(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(3), reader.GetInt32(2));
                }
            }
            return section;
        }

        public static List<Section> GetAll()
        {
            String query = "SELECT * FROM section";
            List<Section> list = new List<Section>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Section section = new Section(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(3), reader.GetInt32(2));
                    list.Add(section);

                }
            }

            return list;
        }
        public static List<Section> GetWithTeacherId(int teacherId)
        {
            String query = "SELECT * FROM section WHERE section_teacher_id = " + teacherId;
            List<Section> list = new List<Section>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Section section = new Section(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(3), reader.GetInt32(2));
                    list.Add(section);

                }
            }

            return list;
        }
    }
}
