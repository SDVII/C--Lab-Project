using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
    class EventsDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(Events events)
        {
            // query take variables $
            string query = $"INSERT INTO events (events_name, events_info, events_organizer, events_place, events_time) " +
                           $"Values ('{events.Name}','{events.Info}'','{events.Organizer}'','{events.Place}'','{events.Time}')";
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

        public static bool Update(Events events)
        {
            string query = $"UPDATE events SET events_name='{events.Name}',events_info='{events.Info}',events_organizer='{events.Organizer}''" +
                           $",events_place='{events.Place}',events_time='{events.Time}' WHERE events_id='{events.Id}'"; // create the query


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
            databaseHandler.Delete("events", "events_id", id);
        }

        public static void Delete(Events events)
        {
            Delete(events.Id);
        }

        public static Events Get(int id)
        {
            String query = "SELECT * FROM events WHERE events_id = '" + id + "'";
            Events events = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    events = new Events(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5));
                }
            }
            return events;
        }

        public static List<Events> GetAll()
        {
            String query = "SELECT * FROM events";
            List<Events> list = new List<Events>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Events events = new Events(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5));
                    list.Add(events);

                }
            }

            return list;
        }
    }
}
