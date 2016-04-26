using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class AnnoNode
    {
        private CourseAnnouncements anno;
        private AnnoNode link;

        public AnnoNode(CourseAnnouncements anno)
        {
            link = null;
            this.anno = anno;
        }

        public CourseAnnouncements Anno
        {
            get { return anno; }
            set { anno = value; }
        }

        public AnnoNode Link
        {
            get { return link; }
            set { link = value; }
        }
    }
}
