using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Slot //Slot object class
    {
        private int id, student_id, semester;
        private String courseCode, slotResult, teacherName;
        private Student student;

        public Slot(int id, int studentId, int semester, string slotResult, string courseCode, string teacherName)
        {
            this.id = id;
            student_id = studentId;
            this.slotResult = slotResult;
            this.semester = semester;
            this.courseCode = courseCode;
            this.teacherName = teacherName;
            this.student = null;
        }

        public Slot(int studentId, int semester, string slotResult, string courseCode, string teacherName)
        {
            student_id = studentId;
            this.slotResult = slotResult;
            this.semester = semester;
            this.courseCode = courseCode;
            this.teacherName = teacherName;
            this.student = null;
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

        public int Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        public string SlotResult
        {
            get { return slotResult; }
            set { slotResult = value; }
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

        public string CourseCode
        {
            get
            {
                return courseCode;
            }

            set
            {
                courseCode = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return teacherName;
            }

            set
            {
                teacherName = value;
            }
        }



        /*public Course Course
        {
            get {
                if (course == null)
                    course = CourseDB.Get(course_id);
                return course;
            }
            set { course = value; }
        }*/
    }
}
