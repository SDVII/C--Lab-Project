using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Manager
    {
        private int id;
        private String username, password;

        public Manager(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public Manager(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
