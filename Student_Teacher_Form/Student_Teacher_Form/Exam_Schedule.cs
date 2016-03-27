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
    public partial class Exam_Schedule : Form
    {
        public Exam_Schedule()
        {
            InitializeComponent();
        }

        private void Exam_Schedule_Load(object sender, EventArgs e)
        {
            lvExSchd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvExSchd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
