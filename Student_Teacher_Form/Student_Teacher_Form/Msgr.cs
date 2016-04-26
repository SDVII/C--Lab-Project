using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class Msgr //Msgr object class
    {
        private int id;
        private String name;

        public Msgr(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Msgr(string name)
        {
            this.name = name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}