using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
    class CourseAnnouncementsDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(CourseAnnouncements courseAnnouncements)
        {
            // query take variables $
            string query = $"INSERT INTO courseAnnouncements (courseAnnouncements_teacher_id, courseAnnouncements_course_id, courseAnnouncements_title, courseAnnouncements_msg, courseAnnouncements_time) " +
                           $"Values ('{courseAnnouncements.TeacherId}','{courseAnnouncements.CourseId}'','{courseAnnouncements.Title}'','{courseAnnouncements.Msg }'','{courseAnnouncements.Time}')";
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

        public static bool Update(CourseAnnouncements courseAnnouncements)
        {
            string query = $"UPDATE courseAnnouncements SET courseAnnouncements_teacher_id='{courseAnnouncements.TeacherId}',courseAnnouncements_course_id='{courseAnnouncements.CourseId}',courseAnnouncements_title='{courseAnnouncements.Title}''" +
                           $",courseAnnouncements_msg='{courseAnnouncements.Msg}',courseAnnouncements_time='{courseAnnouncements.Time}' WHERE courseAnnouncements_id='{courseAnnouncements.Id}'"; // create the query


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
            databaseHandler.Delete("courseAnnouncements", "courseAnnouncements_id", id);
        }

        public static void Delete(CourseAnnouncements courseAnnouncements)
        {
            Delete(courseAnnouncements.Id);
        }

        public static CourseAnnouncements Get(int id)
        {
            String query = "SELECT * FROM courseAnnouncements WHERE courseAnnouncements_id = '" + id + "'";
            CourseAnnouncements courseAnnouncements = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    courseAnnouncements = new CourseAnnouncements(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5));
                }
            }
            return courseAnnouncements;
        }

        public static List<CourseAnnouncements> GetAll()
        {
            String query = "SELECT * FROM courseAnnouncements";
            List<CourseAnnouncements> list = new List<CourseAnnouncements>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CourseAnnouncements courseAnnouncements = new CourseAnnouncements(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5));
                    list.Add(courseAnnouncements);

                }
            }

            return list;
        }
    }
}
