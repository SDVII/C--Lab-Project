using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
    class CourseFileDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static int Add(CourseFile courseFile)
        {
            int rtn =0;
            // query take variables $
            string query = $"INSERT INTO courseFile (courseFile_teacher_id, courseFile_course_id, courseFile_name, courseFile_info, courseFile_time) " +
                           $"Values ('{courseFile.Teacher.Id}','{courseFile.Course.Id}','{courseFile.Name}','{courseFile.Info }','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');" +
                           $"SELECT LAST_INSERT_ID()";
            // check if the connection is open first
            if (databaseHandler.openConnection() == true)
            {
                //fire the query with the connection
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                // send the query
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    rtn = reader.GetInt32(0);
                // close the connection if it is open
                databaseHandler.closeConnection();
                return rtn;
            }
            return rtn;
        }
        

        public static void Delete(int id)
        {
            databaseHandler.Delete("courseFile", "courseFile_id", id);
        }

        public static void Delete(CourseFile courseFile)
        {
            Delete(courseFile.Id);
        }

        /*public static CourseAnnouncements Get(int id)
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
        }*/

        /*public static List<CourseAnnouncements> GetAll()
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
        }*/

        public static List<CourseFile> GetWithCourseId(Course course)
        {
            String query = "SELECT * FROM courseFile WHERE courseFile_course_id = '" + course.Id + "'";
            List<CourseFile> list = new List<CourseFile>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CourseFile courseFile = new CourseFile(reader.GetInt32(0), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5),null, null);
                    list.Add(courseFile);
                }
            }

            return list;
        }

        public static List<CourseAnnouncements> GetLimited(int courseId, int amount)
        {
            String query = "SELECT * FROM courseAnnouncements WHERE courseAnnouncements_id = '" + courseId + "' ORDER BY courseAnnouncements_time DESC LIMIT 0, " + amount;
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
