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
    public partial class Form1 : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message message)//to make the form dragable after removing the title bar
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername__Enter(object sender, System.EventArgs e)
        {

            txtUsername.Text = "";

        }

        private void txtUsername__Leave(object sender, System.EventArgs e)
        {

            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;
            Font f = new Font("Calibri", 11, FontStyle.Italic);
            txtUsername.Font = f;

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.PasswordChar = '*';
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.Text = "Password";
            txtPass.ForeColor = Color.Gray;
            Font f = new Font("Calibri", 11, FontStyle.Italic);
            txtPass.PasswordChar = '\0';
            txtPass.Font = f;

        }
    }
}
