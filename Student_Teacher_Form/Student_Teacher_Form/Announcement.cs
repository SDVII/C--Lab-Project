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
        private DateTime time;

        public Announcement(int id, string title, string msg, DateTime time)
        {
            this.id = id;
            this.title = title;
            this.msg = msg;
            this.time = time;
        }

        public Announcement(string title, string msg, DateTime time)
        {
            this.title = title;
            this.msg = msg;
            this.time = time;
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
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
