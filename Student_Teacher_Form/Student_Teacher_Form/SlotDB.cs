using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class SlotDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        /*public static bool Add(Slot slot)
        {
            // query take variables $
            string query = $"INSERT INTO slot (slot_student_id, slot_course_code, slot_result, slot_semester, slot_teacher_name) " +
                           $"Values ('{slot.StudentId}','{slot.CourseCode}','{slot.SlotResult}','{slot.Semester}','{slot.TeacherName}')";
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

        /*public static bool Update(Slot slot)
        {
            string query = $"UPDATE slot SET slot_student_id='{slot.StudentId}',slot_course_id='{slot.CourseId}',slot_result='{slot.SlotResult}'" +
                           $" WHERE slot_id='{slot.Id}'"; // create the query


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
        }*/

        /*public static void Delete(int id)
        {
            databaseHandler.Delete("slot", "slot_id", id);
        }

        public static void Delete(Slot slot)
        {
            Delete(slot.Id);
        }*/

        /*public static Slot Get(int id)
        {
            String query = "SELECT * FROM slot WHERE slot_id = '" + id + "'";
            Slot slot = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    slot = new Slot(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3));
                }
            }
            return slot;
        }

        public static List<Slot> GetAll()
        {
            String query = "SELECT * FROM slot";
            List<Slot> list = new List<Slot>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Slot slot = new Slot(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3));
                    list.Add(slot);

                }
            }

            return list;
        }*/
        public static List<Slot> GetWithStudentId(int studentId, int semester )
        {
            String query = "SELECT slot_course_code, slot_result, slot_semester, slot_teacher_name FROM slot WHERE slot_student_id='"+studentId+"' AND slot_semester='"+semester+"'";
            List<Slot> list = new List<Slot>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Slot slot = new Slot(studentId, reader.GetInt32(2), reader.GetString(1), reader.GetString(0), reader.GetString(3));
                    list.Add(slot);

                }
            }

            return list;
        }
    }
}
