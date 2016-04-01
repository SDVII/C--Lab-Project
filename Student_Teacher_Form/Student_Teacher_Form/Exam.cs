using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Exam
    {
        private int id, course_id;
        private String time, place;
        private Course course;

        public Exam(int id, int courseId, string time, string place, Course course)
        {
            this.id = id;
            course_id = courseId;
            this.time = time;
            this.place = place;
            this.course = course;
        }

        public Exam(int courseId, string time, string place, Course course)
        {
            course_id = courseId;
            this.time = time;
            this.place = place;
            this.course = course;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int CourseId
        {
            get { return course_id; }
            set { course_id = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }
    }
}
