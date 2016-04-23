using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Form
{
    public partial class Financial_Affairs : Form
    {
        private Student_Portal student_Portal;
        private FinancialAffairs fa;
        private int semester;

        public Financial_Affairs(int semester, FinancialAffairs fa, Student_Portal student_Portal)
        {
            InitializeComponent();
            this.semester = semester;
            this.fa = fa;
            this.student_Portal = student_Portal;
            //this.Text = stuID + "";

            populateFinancialStatus(lbSem, lbPaid, lbRmnDbt);
        }

        private void populateFinancialStatus(Label lbSem, Label lbPaid, Label lbRmnDbt)
        {
            lbSem.Text = ""+ semester;
            lbPaid.Text = ""+fa.Paid;
            lbRmnDbt.Text = ""+fa.Rest;
        }

        private void btnAccFA_Click(object sender, EventArgs e)
        {
            this.Close();
            student_Portal.Enabled = true;
        }

        private void Financial_Affairs_FormClosed(object sender, FormClosedEventArgs e)
        {
            student_Portal.Enabled = true;
        }

        private void btnRfshP_Click(object sender, EventArgs e)
        {
            fa = FinancialAffairsDB.Get(fa.Id);
            populateFinancialStatus(lbSem, lbPaid, lbRmnDbt);
        }
    }
}
