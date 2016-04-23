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
            string query = $"INSERT INTO teacher (student_username,student_name,student_surname,student_password,student_gpa,student_email,student_department_id,student_semester,student_financialAffairs_id,student_advisor_id,student_msgr_id) Values ('{student.Username}','{student.Name}','{student.Surname}','{student.Password}','{student.Gpa}','{student.Email}','{student.Department.Id}','{student.Semester}','{student.FinancialAffairs.Id}','{student.Advisor.Id}','{student.Msgr.Id}')";
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
            string query = $"UPDATE student SET student_username='{student.Username}',student_name='{student.Name}',student_surname='{student.Surname}',student_password='{student.Password}',student_gpa='{student.Gpa}',student_email='{student.Email}',student_department_id='{student.Department.Id}',student_semester={student.Semester},student_financialAffairs_id='{student.FinancialAffairs.Id}',student_advisor_id='{student.Advisor.Id}',student_msgr_id='{student.Msgr.Id}' WHERE student_id='{student.Id}'";

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
            String query = "SELECT student.student_id, student.student_username, student.student_name, student.student_surname, student.student_password, student.student_gpa,student.student_email, student.student_semester, "+
                "department.department_id, department.department_name, department.department_number_of_students, "+
                "financialAffairs.financialAffairs_id,financialAffairs.financialAffairs_paid, financialAffairs.financialAffairs_rest,"+
                " msgr.msgr_id, msgr.msgr_name,"+
                " teacher.teacher_id, teacher.teacher_username, teacher.teacher_name, teacher.teacher_surname, teacher.teacher_password, teacher.teacher_email,"+
                " tm.msgr_id, tm.msgr_name"+
                " FROM student INNER JOIN department ON department.department_id=student.student_department_id INNER JOIN financialAffairs ON financialAffairs.financialAffairs_id = student.student_financialAffairs_id INNER JOIN msgr ON msgr.msgr_id = student.student_msgr_id INNER JOIN teacher ON teacher.teacher_id = student.student_advisor_id INNER JOIN msgr tm ON tm.msgr_id = teacher.teacher_msgr_id"+
                " WHERE student.student_id='"+id+"' LIMIT 1";
            Student stu = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    stu = new Student(reader.GetInt32(0), reader.GetInt32(7), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(6), reader.GetFloat(5),
                        new Department(reader.GetInt32(8), reader.GetInt32(10), reader.GetString(9)),
                        new FinancialAffairs(reader.GetInt32(11), reader.GetInt32(12), reader.GetInt32(13)),
                        new Msgr(reader.GetInt32(14), reader.GetString(15)),
                        new Teacher(reader.GetInt32(16), reader.GetInt32(22), reader.GetString(17), reader.GetString(18), reader.GetString(19), reader.GetString(20), reader.GetString(21)));
                }
            }
            return stu;
        }

        public static Student GetWithUsername(String username)
        {
            String query = "SELECT student.student_id, student.student_username, student.student_name, student.student_surname, student.student_password, student.student_gpa,student.student_email, student.student_semester, " +
                "department.department_id, department.department_name, department.department_number_of_students, " +
                "financialAffairs.financialAffairs_id,financialAffairs.financialAffairs_paid, financialAffairs.financialAffairs_rest," +
                " msgr.msgr_id, msgr.msgr_name," +
                " teacher.teacher_id, teacher.teacher_username, teacher.teacher_name, teacher.teacher_surname, teacher.teacher_password, teacher.teacher_email," +
                " tm.msgr_id, tm.msgr_name" +
                " FROM student INNER JOIN department ON department.department_id=student.student_department_id INNER JOIN financialAffairs ON financialAffairs.financialAffairs_id = student.student_financialAffairs_id INNER JOIN msgr ON msgr.msgr_id = student.student_msgr_id INNER JOIN teacher ON teacher.teacher_id = student.student_advisor_id INNER JOIN msgr tm ON tm.msgr_id = teacher.teacher_msgr_id" +
                " WHERE student.student_username='" + username + "' LIMIT 1";
            Student stu = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    stu = new Student(reader.GetInt32(0), reader.GetInt32(7), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(6), reader.GetFloat(5),
                        new Department(reader.GetInt32(8), reader.GetInt32(10), reader.GetString(9)),
                        new FinancialAffairs(reader.GetInt32(11), reader.GetInt32(12), reader.GetInt32(13)),
                        new Msgr(reader.GetInt32(14), reader.GetString(15)),
                        new Teacher(reader.GetInt32(16), reader.GetInt32(22), reader.GetString(17), reader.GetString(18), reader.GetString(19), reader.GetString(20), reader.GetString(21)));
                }
            }
            return stu;
        }

        public static List<Student> GetAll()
        {

            String query = "SELECT student.student_id, student.student_username, student.student_name, student.student_surname, student.student_password, student.student_gpa,student.student_email, student.student_semester, " +
                "department.department_id, department.department_name, department.department_number_of_students, " +
                "financialAffairs.financialAffairs_id,financialAffairs.financialAffairs_paid, financialAffairs.financialAffairs_rest," +
                " msgr.msgr_id, msgr.msgr_name," +
                " teacher.teacher_id, teacher.teacher_username, teacher.teacher_name, teacher.teacher_surname, teacher.teacher_password, teacher.teacher_email," +
                " tm.msgr_id, tm.msgr_name" +
                " FROM student INNER JOIN department ON department.department_id=student.student_department_id INNER JOIN financialAffairs ON financialAffairs.financialAffairs_id = student.student_financialAffairs_id INNER JOIN msgr ON msgr.msgr_id = student.student_msgr_id "+
                " INNER JOIN teacher ON teacher.teacher_id = student.student_advisor_id INNER JOIN msgr tm ON tm.msgr_id = teacher.teacher_msgr_id";
            List<Student> list = new List<Student>();


            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student stu = new Student(reader.GetInt32(0), reader.GetInt32(7), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(6), reader.GetFloat(5),
                        new Department(reader.GetInt32(8), reader.GetInt32(10), reader.GetString(9)),
                        new FinancialAffairs(reader.GetInt32(11), reader.GetInt32(12), reader.GetInt32(13)),
                        new Msgr(reader.GetInt32(14), reader.GetString(15)),
                        new Teacher(reader.GetInt32(16), reader.GetInt32(22), reader.GetString(17), reader.GetString(18), reader.GetString(19), reader.GetString(20), reader.GetString(21)));
                    list.Add(stu);
                }
            }

            return list;
        }
  
    }
}
