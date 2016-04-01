using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Announcement
    {
        private int id;
        private String title, msg;

        public Announcement(int id, string title, string msg)
        {
            this.id = id;
            this.title = title;
            this.msg = msg;
        }

        public Announcement(string title, string msg)
        {
            this.title = title;
            this.msg = msg;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}
