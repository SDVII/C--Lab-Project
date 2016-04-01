using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Student
    {
        private int id, department_id, national_id, financialAffairs_id, advisor_id, msgr_id;
        private String username, name, surname, password, email;
        private float gpa;
        private Department department;
        private FinancialAffairs financialAffairs;
        private Teacher advisor;
        private Msgr msgr;

        public Student(int id, int departmentId, int nationalId, int financialAffairsId, int advisorId, int msgrId, string username, string name, string surname, string password, string email, float gpa) {
            this.id = id;
            this.username = username;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.email = email;
            this.gpa = gpa;
            department_id = departmentId;
            national_id = nationalId;
            financialAffairs_id = financialAffairsId;
            advisor_id = advisorId;
            msgr_id = msgrId;
        }
        public Student(int departmentId, int nationalId, int financialAffairsId, int advisorId, int msgrId, string username, string name, string surname, string password, string email, float gpa)
        {
            department_id = departmentId;
            national_id = nationalId;
            financialAffairs_id = financialAffairsId;
            advisor_id = advisorId;
            msgr_id = msgrId;
            this.username = username;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.email = email;
            this.gpa = gpa;
            this.department = null;
            this.financialAffairs = null;
            this.advisor = null;
            this.msgr = null;
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

        public int NationalId
        {
            get { return national_id; }
            set { national_id = value; }
        }

        public int FinancialAffairsId
        {
            get { return financialAffairs_id; }
            set { financialAffairs_id = value; }
        }

        public int AdvisorId
        {
            get { return advisor_id; }
            set { advisor_id = value; }
        }

        public int MsgrId
        {
            get { return msgr_id; }
            set { msgr_id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public float Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public Department Department
        {
            get {
                if (this.department == null)
                {
                    this.department = DepartmentDB.Get(this.department_id);
                }
                return this.department;
            }
            set { department = value; }
        }

        public FinancialAffairs FinancialAffairs
        {
            get {
                if (financialAffairs == null)
                    financialAffairs = FinancialAffairsDB.Get(financialAffairs_id);
                return financialAffairs;
            }
            set { financialAffairs = value; }
        }

        public Teacher Advisor
        {
            get {
                if (this.advisor == null) {
                    this.advisor = TeacherDB.Get(this.advisor_id);
                }
                return this.advisor;
            }
            set { advisor = value; }
        }

        public Msgr Msgr
        {
            get {
                if (msgr == null)
                    msgr = MsgrDB.Get(msgr_id);
                return msgr;
            }
            set { msgr = value; }
        }
    }
}
