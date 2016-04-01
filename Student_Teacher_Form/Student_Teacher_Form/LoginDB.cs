using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Teacher_Form
{
    class LoginDB : DatabaseHandler
    {

        public LoginDB() {
            base.createConnection();
        }

        public bool getConnectionStatus() { // return the status of thec connection 
            return base.getConnectionStatus();
        }

        public List<String>[] select(String QueryWeWantToInserted, String[] Coulmns) { // select what we want from the database
            return base.selectAllFromTeacher(QueryWeWantToInserted,Coulmns);
        }





    }
}
