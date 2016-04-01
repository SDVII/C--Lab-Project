using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
    class AnnouncementDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(Announcement announcement)
        {
            // query take variables $
            string query = $"INSERT INTO Announcements (Announcements_title, Announcements_msg) Values ('{announcement.Title}','{announcement.Msg}')";
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

        public static bool Update(Announcement announcement)
        {
            string query = $"UPDATE Announcements SET Announcements_title='{announcement.Title}',Announcements_msg='{announcement.Msg}' WHERE Announcements_id='{announcement.Id}'"; // create the query


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
            databaseHandler.Delete("Announcements", "Announcements_id", id);
        }

        public static void Delete(Announcement announcement)
        {
            Delete(announcement.Id);
        }

        public static Announcement Get(int id)
        {
            String query = "SELECT * FROM Announcements WHERE Announcements_id = '" + id + "'";
            Announcement announcement = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    announcement = new Announcement(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                }
            }
            return announcement;
        }

        public static List<Announcement> GetAll()
        {
            String query = "SELECT * FROM Announcements";
            List<Announcement> list = new List<Announcement>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Announcement announcement = new Announcement(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    list.Add(announcement);

                }
            }
            return list;
        }
    }
}
