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
    public partial class Course_info_Stu : Form
    {
        public Course_info_Stu()
        {
            InitializeComponent();
        }

        private void Course_info_Stu_Load(object sender, EventArgs e)
        {
            lvMsg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMsg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
