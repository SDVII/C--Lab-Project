using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Teacher_Form
{
     class DatabaseHandler
    {
        public MySqlConnection connection; // connection object open/close connection
        protected string server; // server ip
        protected string database; // DB name
        protected string username; // DB username
        protected string password; // DB password
        public string connectionError; // connnection Error ..checkConnection()
        public bool ConnectionStatus = false; // checking the status of the connection if it is on or off / true or false






        // it will return the checkingConnectionStatus
        public bool getConnectionStatus()
        {
            return ConnectionStatus;
        }




        public DatabaseHandler()
        {
            // it will create the connection whenever the object created
            
        }




 





        // open connection
        public bool openConnection()
        {
            try
            {
                string connectionString; // we will store in it all connection information

                server = "37.139.18.76"; // set server ip 127.0.0.1
                database = "csp"; // set DB name 
                username = "puser"; // set DB username
                password = "password"; // set DB password

                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";"; // store connection information

                connection = new MySqlConnection(connectionString); // send connection request
                connection.Open();
                ConnectionStatus = true;

                // it will start the conncetion  and return true
            return true;
            }
            catch (MySqlException e)
            {// catch errors
                ConnectionStatus = false;
                switch (e.Number)
                { // e.Number --> error Number
                    case 0: //0 --> conection error
                        connectionError = "There is a Error in the connection";
                        break;

                    case 1045: // 1045 --> username or password error
                        connectionError = "Please Check again your password";
                        break;
                }
                return false;
            }
        }






        // close DB connections
        public bool closeConnection()
        {
            try
            {
                ConnectionStatus = false; // just for checking the status of the connection we can get it by 
                connection.Close(); // close the connection
                return true;
            }
            catch (MySqlException ex)
            {
                connectionError = ex.Message; // bring the errors
                return false;
            }
        }





        // it will take a query and array of the columns i want to bring
        public List<String>[] select(String QueryWeWantToInserted, String[] Coulmns)
        {

            List<string>[] list = new List<string>[Coulmns.Length]; // the array number = coulmns

            for (int i = 0; i < Coulmns.Length; i++) // make a list for each column
            {
                list[i] = new List<string>();
            }

            String query = QueryWeWantToInserted; // query we send it to the database


            if (this.openConnection() == true) // check if there is a connection
            {
                MySqlCommand cmd = new MySqlCommand(query, connection); // it will fire the command with the connection
                MySqlDataReader reader = cmd.ExecuteReader(); // it will create object that read the database according to DB columns

                while (reader.Read()) // it will loop while there is a rows
                {
                    for (int i = 0; i < Coulmns.Length; i++) // fill the lists accourding to the column name
                    {
                        list[i].Add(reader[Coulmns[i]].ToString());

                    }
                }
            }
            return list; // array contain a lists which contain a columns data
        }





        //INSERT into teacher table
        protected void InsertNewTeacher(Teacher teacher)
        {
            // query take variables $
            string query = $"INSERT INTO teacher (teacher_username,teacher_name,teacher_surname,teacher_password,teacher_email,teacher_msgr_id) Values ('{teacher.Username}','{teacher.Name}','{teacher.Surname}','{teacher.Password}','{teacher.Email}','{teacher.MsgrId}')";
            // check if the connection is open first
            if (this.openConnection() == true)
            {
                //fire the query with the connection
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // send the query
                cmd.ExecuteNonQuery();
                // close the connection if it is open
                this.closeConnection();
            }
        }














        // insert a new request From the teacher to the manager
        public  void insertNewRequest(String title,String content,String selectedOpetion) {
            string query = $"INSERT INTO teacherRequest (teacherRequest_title,teacherRequest_content,teacherRequest_select) Values ('{title}','{content}','{selectedOpetion}')";

            if (this.openConnection() == true)
            {
                //fire the query with the connection
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // send the query
                cmd.ExecuteNonQuery();
                // close the connection if it is open
                this.closeConnection();
            }
        }

        public void insertDocumentRequest(int studentId, String name, String option, String language)
        {
            string query = $"INSERT INTO DocumentRequest (DocumentRequest_student_id,DocumentRequest_documentName,DocumentRequest_shippingOption, DocumentRequest_language) Values ('{studentId}','{name}','{option}','{language}')";

            if (this.openConnection() == true)
            {
                //fire the query with the connection
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // send the query
                cmd.ExecuteNonQuery();
                // close the connection if it is open
                this.closeConnection();
            }
        }
        public List<List<String>> getReadyDocuments(int studentId) {
            List<List<String>> documentList = new List<List<string>>();

            string query = $"SELECT DocumentRequest_documentName,DocumentRequest_shippingOption,DocumentRequest_language FROM DocumentRequest WHERE DocumentRequest_student_id='{studentId}' AND DocumentRequest_ready = '{1}'";

            if (openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    List<String> list = new List<string>() { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                    documentList.Add(list);
                }
            }
            return documentList;
        }



        // insert a new reportIssue 
        public void insertReportIssue(String title, String content, String selectedOpetion)
        {
            string query = $"INSERT INTO reportIssue (reportIssue_title,reportIssue_content,reportIssue_select) Values ('{title}','{content}','{selectedOpetion}')";

            if (this.openConnection() == true)
            {
                //fire the query with the connection
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // send the query
                cmd.ExecuteNonQuery();
                // close the connection if it is open
                this.closeConnection();
            }
        }




        //update row from teacher_table method
        protected void updateTeacher(Teacher teacher)
        {


            string query = $"UPDATE teacher SET teacher_username='{teacher.Username}',teacher_name='{teacher.Name}',teacher_surname='{teacher.Surname}',teacher_password='{teacher.Password}',teacher_email='{teacher.Email}',teacher_msgr_id='{teacher.MsgrId}' WHERE teacher_id='{teacher.Id}'"; // create the query


            if (this.openConnection() == true) // check the connection
            {

                MySqlCommand cmd = new MySqlCommand(); //  create a sql command
                cmd.CommandText = query; // use the query
                cmd.Connection = connection; // use the connection
                cmd.ExecuteNonQuery(); //Execute the Query
                this.closeConnection(); // close the connection
            }
        }





        public void Delete(String tableName, String columnName, int columnValue)
        {
            string query = $"DELETE FROM {tableName} WHERE {columnName} = {columnValue} "; // the query

            if (this.openConnection() == true) // check if the connection is open first
            {
                MySqlCommand cmd = new MySqlCommand(query, connection); // assign the connection and the query 
                cmd.ExecuteNonQuery(); // excute the query
                this.closeConnection(); // close the connection
            }
        }
    }
}
