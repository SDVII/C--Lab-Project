using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class Events
    {
        private int id;
        private String name, info, organizer, place;
        private DateTime time;

        public Events(int id, string name, string info, string organizer, string place, DateTime time)
        {
            this.id = id;
            this.name = name;
            this.info = info;
            this.organizer = organizer;
            this.place = place;
            this.time = time;
        }

        public Events(string name, string info, string organizer, string place, DateTime time)
        {
            this.name = name;
            this.info = info;
            this.place = place;
            this.organizer = organizer;
            this.time = time;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        public string Organizer
        {
            get { return organizer; }
            set { organizer = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
