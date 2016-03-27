using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class CourseAnnouncements
    {
        private int id, teacher_id, course_id;
        private String title, msg;
        private DateTime time;
        private Teacher teacher;
        private Course course;

        public CourseAnnouncements(int id, int teacherId, int courseId, string title, string msg, DateTime time, Teacher teacher, Course course)
        {
            this.id = id;
            teacher_id = teacherId;
            course_id = courseId;
            this.title = title;
            this.msg = msg;
            this.time = time;
            this.teacher = teacher;
            this.course = course;
        }

        public CourseAnnouncements(int teacherId, int courseId, string title, string msg, DateTime time, Teacher teacher, Course course)
        {
            teacher_id = teacherId;
            course_id = courseId;
            this.title = title;
            this.msg = msg;
            this.time = time;
            this.teacher = teacher;
            this.course = course;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int TeacherId
        {
            get { return teacher_id; }
            set { teacher_id = value; }
        }

        public int CourseId
        {
            get { return course_id; }
            set { course_id = value; }
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
