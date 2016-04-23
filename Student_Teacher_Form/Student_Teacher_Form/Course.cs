using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Course //Course object class
    {
        private int id, department_id;
        private String name, code, info;
        private Department department;

        public Course(int id, int departmentId, string name, string code, string info)
        {
            this.id = id;
            department_id = departmentId;
            this.name = name;
            this.code = code;
            this.info = info;
            this.department = null;
        }

        public Course(int departmentId, string name, string code, string info)
        {
            department_id = departmentId;
            this.name = name;
            this.code = code;
            this.info = info;
            this.department = null;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int DepartmentId
        {
            get { return department_id; }
            set { department_id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public Department Department
        {
            get {
                if (department == null)
                    department = DepartmentDB.Get(department_id);
                return department;
            }
            set { department = value; }
        }
    }
}
