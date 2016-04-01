using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
    class StudentDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(Student student)
        {
            // query take variables $
            string query = $"INSERT INTO teacher (student_username,student_name,student_surname,student_password,student_gpa,student_email,student_department_id,student_national_id,student_financialAffairs_id,student_advisor_id,student_msgr_id) Values ('{student.Username}','{student.Name}','{student.Surname}','{student.Password}','{student.Gpa}','{student.Email}','{student.DepartmentId}','{student.NationalId}','{student.FinancialAffairsId}','{student.AdvisorId}','{student.MsgrId}')";
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

        public static bool Update(Student student)
        {
            string query = $"UPDATE student SET student_username='{student.Username}',student_name='{student.Name}',student_surname='{student.Surname}',student_password='{student.Password}',student_gpa='{student.Gpa}',student_email='{student.Email}',student_department_id='{student.DepartmentId}',student_national_id={student.NationalId},student_financialAffairs_id='{student.FinancialAffairsId}',student_advisor_id='{student.AdvisorId}',student_msgr_id='{student.MsgrId}' WHERE student_id='{student.Id}'";

            if (databaseHandler.openConnection() == true) // check the connection
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
            databaseHandler.Delete("student", "student_id", id);
        }

        public static void DeleteStudent(Student student)
        {
            Delete(student.Id);
        }

        public static Student Get(int id)
        {
            String query = "SELECT * FROM student WHERE student_id = '" + id + "'";
            Student stu = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    stu = new Student(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetFloat(11));
                }
            }
            return stu;
        }

        public static Student GetWithUsername(String username)
        {
            String query = "SELECT * FROM student WHERE student_username = '" + username + "'";
            Student stu = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    stu = new Student(reader.GetInt32(0), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), 
                        reader.GetInt32(11), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(6), reader.GetFloat(5));
                }
            }
            return stu;
        }

        public static List<Student> GetAll()
        {

            String query = "SELECT * FROM student";
            List<Student> list = new List<Student>();


            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student stu = new Student(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetFloat(11));
                    list.Add(stu);
                }
            }

            return list;
        }
  
    }
}
