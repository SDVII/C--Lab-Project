using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class CourseFile
    {
        private int id;
        private String name, info;
        private DateTime time;
        private Teacher teacher;
        private Course course;

        public CourseFile(int id, string name, string info, DateTime time, Teacher teacher, Course course)
        {
            this.id = id;
            this.name = name;
            this.info = info;
            this.time = time;
            this.teacher = teacher;
            this.course = course;
        }

        public CourseFile(string name, string info, DateTime time, Teacher teacher, Course course)
        {
            this.name = name;
            this.info = info;
            this.time = time;
            this.teacher = teacher;
            this.course = course;
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

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public Teacher Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }
    }
}
