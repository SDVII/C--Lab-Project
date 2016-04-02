using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class SectionTime
    {
        private int id, section_id, time;
        private String location;
        private Section section;

        public SectionTime(int id, int sectionId, int time, string location)
        {
            this.id = id;
            section_id = sectionId;
            this.time = time;
            this.section = null;
            this.location = location;
        }

        public SectionTime(int sectionId, int time, string location)
        {
            section_id = sectionId;
            this.time = time;
            this.section = null;
            this.location = location;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int SectionId
        {
            get { return section_id; }
            set { section_id = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public String getTimeAsString()
        {
            String rtn = "";

            int hour =  8 + (time % 17);

            rtn = hour + ":30-" + (hour + 1) + ":30";

            return rtn;
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public Section Section
        {
            get {
                if (section == null)
                    section = SectionDB.Get(section_id);
                return section;
            }
            set { section = value; }
        }
    }
}
