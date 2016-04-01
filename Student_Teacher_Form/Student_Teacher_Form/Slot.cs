using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Slot
    {
        private int id, student_id, course_id;
        private String slotResult;
        private Student student;
        private Course course;

        public Slot(int id, int studentId, int courseId, string slotResult)
        {
            this.id = id;
            student_id = studentId;
            course_id = courseId;
            this.slotResult = slotResult;
            this.course = null;
            this.student = null;
        }

        public Slot(int studentId, int courseId, string slotResult)
        {
            student_id = studentId;
            course_id = courseId;
            this.slotResult = slotResult;
            this.student = null;
            this.course = null;
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

        public int CourseId
        {
            get { return course_id; }
            set { course_id = value; }
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

        public Course Course
        {
            get {
                if (course == null)
                    course = CourseDB.Get(course_id);
                return course;
            }
            set { course = value; }
        }
    }
}
