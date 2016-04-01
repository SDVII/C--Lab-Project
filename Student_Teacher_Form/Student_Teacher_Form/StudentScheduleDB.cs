using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class StudentScheduleDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(StudentSchedule studentSchedule)
        {
            // query take variables $
            string query = $"INSERT INTO studentSchedule (studentSchedule_student_id, studentSchedule_teacher_id, studentSchedule_course_id, studentSchedule_section_id) " +
                           $"Values ('{studentSchedule.StudentId}','{studentSchedule.TeacherId}','{studentSchedule.CourseId}','{studentSchedule.SectionId}')";
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

        public static bool Update(StudentSchedule studentSchedule)
        {
            string query = $"UPDATE studentSchedule SET studentSchedule_student_id='{studentSchedule.StudentId}',studentSchedule_teacher_id='{studentSchedule.TeacherId}',studentSchedule_course_id='{studentSchedule.CourseId}',studentSchedule_section_id='{studentSchedule.SectionId}'" +
                           $" WHERE studentSchedule_id='{studentSchedule.Id}'"; // create the query


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
            databaseHandler.Delete("studentSchedule", "studentSchedule_id", id);
        }

        public static void Delete(StudentSchedule studentSchedule)
        {
            Delete(studentSchedule.Id);
        }

        public static StudentSchedule Get(int id)
        {
            String query = "SELECT * FROM studentSchedule WHERE studentSchedule_id = '" + id + "'";
            StudentSchedule studentSchedule = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    studentSchedule = new StudentSchedule(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));
                }
            }
            return studentSchedule;
        }

        public static List<StudentSchedule> GetAll()
        {
            String query = "SELECT * FROM studentSchedule";
            List<StudentSchedule> list = new List<StudentSchedule>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    StudentSchedule studentSchedule = new StudentSchedule(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));
                    list.Add(studentSchedule);

                }
            }

            return list;
        }
    }
}
