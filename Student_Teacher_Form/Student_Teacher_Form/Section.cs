using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class Section
    {
        private int id, course_id, teacher_id, number;
        private Course course;
        private Teacher teacher;

        public Section(int id, int courseId, int teacherId, int number, Course course, Teacher teacher)
        {
            this.id = id;
            course_id = courseId;
            teacher_id = teacherId;
            this.number = number;
            this.course = course;
            this.teacher = teacher;
        }

        public Section(int courseId, int teacherId, int number, Course course, Teacher teacher)
        {
            course_id = courseId;
            teacher_id = teacherId;
            this.number = number;
            this.course = course;
            this.teacher = teacher;
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

        public int TeacherId
        {
            get { return teacher_id; }
            set { teacher_id = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }

        public Teacher Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
    }
}
