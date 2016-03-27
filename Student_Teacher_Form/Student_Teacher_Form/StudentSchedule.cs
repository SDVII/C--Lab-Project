using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class StudentSchedule
    {
        private int id, student_id, teacher_id, course_id, section_id;
        private Student student;
        private Teacher teacher;
        private Course course;
        private Section section;

        public StudentSchedule(int id, int studentId, int teacherId, int courseId, int sectionId, Student student, Teacher teacher, Course course, Section section)
        {
            this.id = id;
            student_id = studentId;
            teacher_id = teacherId;
            course_id = courseId;
            section_id = sectionId;
            this.student = student;
            this.teacher = teacher;
            this.course = course;
            this.section = section;
        }

        public StudentSchedule(int studentId, int teacherId, int courseId, int sectionId, Student student, Teacher teacher, Course course, Section section)
        {
            student_id = studentId;
            teacher_id = teacherId;
            course_id = courseId;
            section_id = sectionId;
            this.student = student;
            this.teacher = teacher;
            this.course = course;
            this.section = section;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int StudentId
        {
            get { return student_id; }
            set { student_id = value; }
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

        public int SectionId
        {
            get { return section_id; }
            set { section_id = value; }
        }

        public Student Student
        {
            get { return student; }
            set { student = value; }
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

        public Section Section
        {
            get { return section; }
            set { section = value; }
        }
    }
}
