using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class StudentSchedule //StudentSchedule object class
    {
        private int id, student_id, teacher_id, course_id, section_id;
        private Student student;
        private Teacher teacher;
        private Course course;
        private Section section;

        public StudentSchedule(int id, int studentId, int teacherId, int courseId, int sectionId)
        {
            this.id = id;
            student_id = studentId;
            teacher_id = teacherId;
            course_id = courseId;
            section_id = sectionId;
            this.student = null;
            this.teacher = null;
            this.course = null;
            this.section = null;
        }

        public StudentSchedule(int studentId, int teacherId, int courseId, int sectionId)
        {
            student_id = studentId;
            teacher_id = teacherId;
            course_id = courseId;
            section_id = sectionId;
            this.student = null;
            this.teacher = null;
            this.course = null;
            this.section = null;
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
            get {
                if (student == null)
                    student = StudentDB.Get(student_id);
                return student;
            }
            set { student = value; }
        }

        public Teacher Teacher
        {
            get {
                if (teacher == null)
                    teacher = TeacherDB.Get(teacher_id);
                return teacher;
            }
            set { teacher = value; }
        }

        public Course Course
        {
            get {
                if (course == null)
                    course = CourseDB.Get(course_id);
                return course;
            }
            set { course = value; }
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
