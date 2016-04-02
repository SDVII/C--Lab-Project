using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class MsgDB
    {
        private static DatabaseHandler databaseHandler = new DatabaseHandler();

        public static String getConnectionError()
        {
            return databaseHandler.connectionError;
        }

        public static bool Add(Msg msg)
        {
            // query take variables $
            string query = $"INSERT INTO msg (msg_sender_id, msg_receiver_id, msg_time, msg_title, msg_message, msg_file_name) " +
                           $"Values ('{msg.SenderId}','{msg.ReceiverId}'','{msg.Time}'','{msg.Title}'','{msg.Message}'','{msg.FileName}')";
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

        public static bool Update(Msg msg)
        {
            string query = $"UPDATE msg SET msg_sender_id='{msg.SenderId}',msg_receiver_id='{msg.ReceiverId}',msg_time='{msg.Time}''" +
                           $",msg_title='{msg.Title}',msg_message='{msg.Message}',msg_file_name='{msg.FileName}' WHERE msg_id='{msg.Id}'"; // create the query


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
            databaseHandler.Delete("msg", "msg_id", id);
        }

        public static void Delete(Msg msg)
        {
            Delete(msg.Id);
        }

        public static Msg Get(int id)
        {
            String query = "SELECT * FROM msg WHERE msg_id = '" + id + "'";
            Msg msg = null;

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    msg = new Msg(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                }
            }
            return msg;
        }

        public static List<Msg> GetAll()
        {
            String query = "SELECT * FROM msg";
            List<Msg> list = new List<Msg>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Msg msg = new Msg(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    list.Add(msg);

                }
            }

            return list;
        }

        public static List<Msg> GetWithReceiverId(int receiverId)
        {
            String query = "SELECT * FROM msg WHERE msg_receiver_id = '" + receiverId + "'";
            List<Msg> list = new List<Msg>();

            if (databaseHandler.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseHandler.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Msg msg = new Msg(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    list.Add(msg);

                }
            }

            return list;
        }
    }
}
