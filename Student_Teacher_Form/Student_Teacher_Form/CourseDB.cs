using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Map.Native;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
    class CourseDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(Course course)
        {
            // query take variables $
            string query = $"INSERT INTO course (course_department_id, course_name, course_code, course_info) " +
                           $"Values ('{course.DepartmentId}','{course.Name}'','{course.Code}'','{course.Info}')";
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

        public static bool Update(Course course)
        {
            string query = $"UPDATE course SET course_department_id'{course.DepartmentId}',course_name='{course.Name}',course_code='{course.Code}''" +
                           $",course_info='{course.Info}' WHERE course_id='{course.Id}'"; // create the query


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
            databaseHandler.Delete("course", "course_id", id);
        }

        public static void Delete(Course course)
        {
            Delete(course.Id);
        }

        public static Course Get(int id)
        {
            String query = "SELECT * FROM course WHERE course_id = '" + id + "'";
            Course course = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    course = new Course(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                }
            }
            return course;
        }

        public static List<Course> GetAll()
        {
            String query = "SELECT * FROM course";
            List<Course> list = new List<Course>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    list.Add(course);

                }
            }

            return list;
        }
    }
}
