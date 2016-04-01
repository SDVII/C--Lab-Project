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
        private Section section;

        public SectionTime(int id, int sectionId, int time)
        {
            this.id = id;
            section_id = sectionId;
            this.time = time;
            this.section = null;
        }

        public SectionTime(int sectionId, int time)
        {
            section_id = sectionId;
            this.time = time;
            this.section = null;
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
