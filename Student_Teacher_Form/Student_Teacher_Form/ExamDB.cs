using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class ExamDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(Exam exam)
        {
            // query take variables $
            string query = $"INSERT INTO exam (exam_course_id, exam_time, exam_place) " +
                           $"Values ('{exam.CourseId}','{exam.Time}','{exam.Place}')";
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

        public static bool Update(Exam exam)
        {
            string query = $"UPDATE exam SET exam_course_id='{exam.CourseId}',exam_time='{exam.Time}',exam_place='{exam.Place}'" +
                           $" WHERE exam_id='{exam.Id}' LIMIT 1"; // create the query


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
            databaseHandler.Delete("exam", "exam_id", id);
        }

        public static void Delete(Exam exam)
        {
            Delete(exam.Id);
        }

        public static Exam Get(int id)
        {
            String query = "SELECT * FROM exam WHERE exam_id = '" + id + "' LIMIT 1";
            Exam exam = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    exam = new Exam(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3));
                }
            }
            return exam;
        }

        public static List<Exam> GetAll()
        {
            String query = "SELECT * FROM exam";
            List<Exam> list = new List<Exam>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Exam exam = new Exam(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3));
                    list.Add(exam);

                }
            }

            return list;
        }

        public static List<Exam> GetWithCourseId(int courseId)
        {
            String query = "SELECT * FROM exam WHERE exam_course_id = '" + courseId + "'";
            List<Exam> list = new List<Exam>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Exam exam = new Exam(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3));
                    list.Add(exam);

                }
            }

            return list;
        }
        public static List<Exam> GetWithCourseId(Course course)
        {
            String query = "SELECT * FROM exam WHERE exam_course_id = '" + course.Id + "'";
            List<Exam> list = new List<Exam>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Exam exam = new Exam(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3));
                    exam.Course = course;
                    list.Add(exam);

                }
            }

            return list;
        }
    }
}
