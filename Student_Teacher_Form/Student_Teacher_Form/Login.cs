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
    public partial class Login : Form
    {

        Font watermark = new Font("Calibri", 12, FontStyle.Italic);
        Font defaultF = new Font("Calibri", 12);
        Boolean validated = true;

        public Login()
        {
            InitializeComponent();

            //For Default Watermark
            pictureBox1.Select();
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Font = watermark;

            txtPass.Text = "Password";
            txtPass.ForeColor = Color.Gray;
            txtPass.PasswordChar = '\0';
            txtPass.Font = watermark;

            cbUsrT.SelectedIndex = 0;
            cbUsrT.ForeColor = Color.Gray;
            cbUsrT.Font = watermark;

        }

        public void checkInput(String uName, String pass)
        {
            if(uName.Equals("Username")|| pass.Equals("Password")|| txtPass.Text.Trim().Equals("") || txtUsername.Text.Trim().Equals(""))
            {
                btnLogin.Enabled=false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername__Enter(object sender, System.EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("")|| txtUsername.Text.Trim().Equals("Username"))
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
                txtUsername.Font = defaultF;
                checkInput(txtUsername.Text, txtPass.Text);
            }
        }

        private void txtUsername__Leave(object sender, System.EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals(""))
            {
                txtUsername.ForeColor = Color.Gray;
                txtUsername.Text = "Username";
                txtUsername.Font = watermark;
                checkInput(txtUsername.Text, txtPass.Text);
            }

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim().Equals("")|| txtPass.Text.Trim().Equals("Password"))
            {
                txtPass.ForeColor = Color.Black;
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.Font = defaultF;
                checkInput(txtUsername.Text, txtPass.Text);
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim().Equals(""))
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Gray;
                txtPass.PasswordChar = '\0'; //default format
                txtPass.Font = watermark;
                checkInput(txtUsername.Text, txtPass.Text);
            }

        }

        private void cbUsrT_Enter(object sender, EventArgs e)
        {
            cbUsrT.ForeColor = Color.Black;
            cbUsrT.Font = defaultF;
            checkInput(txtUsername.Text, txtPass.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            Validate the username, password and occupation
            For testing reasons, i'll make a Boolean "validated" which is always true. delete it after you insert the validate function.
            I will also use a fake ID for testing as well.
            */

            if(validated==true)
            {
                if (cbUsrT.Text.Equals("Student"))
                {
                    Student_Portal f = new Student_Portal(1234,txtUsername.Text);
                    f.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    Teacher_Portal f = new Teacher_Portal(5678,txtUsername.Text);
                    f.Visible = true;
                    this.Visible = false;
                }
            }

        }

        private void cbUsrT_Leave(object sender, EventArgs e)
        {
            checkInput(txtUsername.Text, txtPass.Text);
        }
    }
}
