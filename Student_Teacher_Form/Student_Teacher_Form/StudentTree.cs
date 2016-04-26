using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class StudentTree
    {
        private StudentTreeNode root;
        private int size;

        public StudentTree()
        {
            root = null;
            size = 0;
        }

        private StudentTreeNode createStudentTreeNode(Student student)
        {
            return new StudentTreeNode(student);
        }

        public StudentTreeNode Root
        {
            get { return root; }
        }

        public int Size
        {
            get { return size; }
        }

        public Boolean insert(Student s)
        {
            if (root == null)
                root = createStudentTreeNode(s);
            else
            {
                StudentTreeNode parent = null, current = root;

                while (current != null)
                {
                    if (s.Id < current.Student.Id)
                    {
                        parent = current;
                        current = current.Left;
                    }
                    else if (s.Id > current.Student.Id)
                    {
                        parent = current;
                        current = current.Right;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (s.Id < parent.Student.Id)
                {
                    parent.Left = createStudentTreeNode(s);
                }
                else
                {
                    parent.Right = createStudentTreeNode(s);
                }
            }
            size++;
            return true;
        }

        public Student search(int id)
        {
            StudentTreeNode current = root;

            while (current != null)
            {
                if (id < current.Student.Id)
                    current = current.Left;
                else if (id > current.Student.Id)
                    current = current.Right;
                else
                {
                    return current.Student;
                }
            }
            return null;
        }
    }
}
