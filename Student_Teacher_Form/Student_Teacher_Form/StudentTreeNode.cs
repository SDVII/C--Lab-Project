using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class StudentTreeNode
    {
        private Student student;
        private StudentTreeNode left, right;

        public StudentTreeNode(Student student)
        {
            this.student = student;
            left = null;
            right = null;
        }

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        public StudentTreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        public StudentTreeNode Right
        {
            get { return right; }
            set { right = value; }
        }
    }
}
