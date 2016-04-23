using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Teacher //Teacher object class
    {
        private int id, msgr_id;
        private String username, name, surname, password, email;
        private Msgr msgr;

        public Teacher(int id, int msgrId, string username, string name, string surname, string password, string email)
        {
            this.id = id;
            msgr_id = msgrId;
            this.name = name;
            this.username = username;
            this.surname = surname;
            this.email = email;
            this.msgr = null;
            this.password = password;
        }

        public Teacher(int msgrId, string username, string name, string surname, string password, string email)
        {
            msgr_id = msgrId;
            this.username = username;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.email = email;
            this.msgr = null;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int MsgrId
        {
            get { return msgr_id; }
            set { msgr_id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Msgr Msgr
        {
            get {
                if (msgr == null)
                    msgr = MsgrDB.Get(msgr_id);
                return msgr;
            }
            set { msgr = value; }
        }
    }
}
