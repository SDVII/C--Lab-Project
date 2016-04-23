using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Department
    {
        private int id, numberOfStudents;
        private String name;

        public Department(int id, int numberOfStudents, string name)
        {
            this.id = id;
            this.numberOfStudents = numberOfStudents;
            this.name = name;
        }
        public Department(int numberOfStudents, string name)
        {
            this.numberOfStudents = numberOfStudents;
            this.name = name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int NumberOfStudents
        {
            get { return numberOfStudents; }
            set { numberOfStudents = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
