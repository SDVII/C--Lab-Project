using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class SectionTimeDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        /*public static bool Add(SectionTime sectionTime)
        {
            // query take variables $
            string query = $"INSERT INTO sectionTime (sectionTime_section_id, sectionTime_time, sectionTime_location) " +
                           $"Values ('{sectionTime.SectionId}','{sectionTime.Time}','{sectionTime.Location}')";
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

        public static bool Update(SectionTime sectionTime)
        {
            string query = $"UPDATE sectionTime SET sectionTime_section_id='{sectionTime.SectionId}',sectionTime_time='{sectionTime.Time}',sectionTime_location='{sectionTime.Location}'" +
                           $" WHERE sectionTime_id='{sectionTime.Id}' LIMIT 1"; // create the query


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
            databaseHandler.Delete("sectionTime", "sectionTime_id", id);
        }

        public static void Delete(SectionTime sectionTime)
        {
            Delete(sectionTime.Id);
        }*/

        public static SectionTime Get(int id)
        {
            String query = "SELECT * FROM sectionTime WHERE sectionTime_id = '" + id + "'";
            SectionTime sectionTime = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sectionTime = new SectionTime(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3));
                }
            }
            return sectionTime;
        }

        public static List<SectionTime> GetAll()
        {
            String query = "SELECT * FROM sectionTime";
            List<SectionTime> list = new List<SectionTime>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SectionTime sectionTime = new SectionTime(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3));
                    list.Add(sectionTime);

                }
            }

            return list;
        }

        public static List<SectionTime> GetWithSectionId(int sectionId)
        {
            String query = "SELECT * FROM sectionTime WHERE sectionTime_section_id = '" + sectionId + "'";
            List<SectionTime> list = new List<SectionTime>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SectionTime sectionTime = new SectionTime(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3));
                    list.Add(sectionTime);

                }
            }

            return list;
        }
    }
}
