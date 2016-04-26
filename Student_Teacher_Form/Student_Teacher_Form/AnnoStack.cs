using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class AnnoStack
    {
        private AnnoNode top;

        public AnnoStack()
        {
            top = null;
        }

        public Boolean isEmpty()
        {
            return (top == null);
        }

        public void push(CourseAnnouncements anno)
        {
            AnnoNode an = new AnnoNode(anno);
            an.Link = top;
            top = an;
        }

        public Boolean pop()
        {
            if (isEmpty())
                return false;
            else
            {
                top = top.Link;
                return true;
            }
        }

        public CourseAnnouncements Top
        {
            get {
                if (top != null)
                    return top.Anno;
                else
                {
                    return null;
                }
            }
            set { top.Anno = value; }
        }
    }
}
