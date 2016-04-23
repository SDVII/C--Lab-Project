using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    public class FinancialAffairs //FinancialAffairs object class
    {
        private int id, paid, rest;

        public FinancialAffairs(int id, int paid, int rest)
        {
            this.id = id;
            this.paid = paid;
            this.rest = rest;
        }

        public FinancialAffairs(int paid, int rest)
        {
            this.paid = paid;
            this.rest = rest;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        public int Rest
        {
            get { return rest; }
            set { rest = value; }
        }


    }
}
