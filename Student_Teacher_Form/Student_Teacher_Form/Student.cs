using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Student
    {
        private int id,semester;
        private String username, name, surname, password, email;
        private float gpa;
        private Department department;
        private FinancialAffairs financialAffairs;
        private Teacher advisor;
        private Msgr msgr;

        public Student(int id, int semester, string username, string name, string surname, string password, string email, float gpa, Department dep, FinancialAffairs fa, Msgr msgr, Teacher tea) {
            this.id = id;
            this.username = username;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.email = email;
            this.gpa = gpa;
            this.semester = semester;
            this.department = dep;
            this.financialAffairs = fa;
            this.advisor = tea;
            this.msgr = msgr;
        }
        public Student(int semester, string username, string name, string surname, string password, string email, float gpa, Department dep, FinancialAffairs fa, Msgr msgr, Teacher tea)
        {
            this.semester = semester;
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
            this.department = dep;
            this.financialAffairs = fa;
            this.advisor = tea;
            this.msgr = msgr;
        }



        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Semester
        {
            get { return semester; }
            set { semester = value; }
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
                return department;
            }
            set { department = value; }
        }

        public FinancialAffairs FinancialAffairs
        {
            get {
                return financialAffairs;
            }
            set { financialAffairs = value; }
        }

        public Teacher Advisor
        {
            get {
                return this.advisor;
            }
            set { advisor = value; }
        }

        public Msgr Msgr
        {
            get {
                return msgr;
            }
            set { msgr = value; }
        }
    }
}
