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


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername__Enter(object sender, System.EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("") || txtUsername.Text.Trim().Equals("Username"))
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
                txtUsername.Font = defaultF;
            }

        }

        private void txtUsername__Leave(object sender, System.EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals(""))
            {
                txtUsername.ForeColor = Color.Gray;
                txtUsername.Text = "Username";
                txtUsername.Font = watermark;
            }

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim().Equals("") || txtPass.Text.Trim().Equals("Password"))
            {
                txtPass.ForeColor = Color.Black;
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.Font = defaultF;
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
            }

        }

        private void cbUsrT_Enter(object sender, EventArgs e)
        {
            cbUsrT.ForeColor = Color.Black;
            cbUsrT.Font = defaultF;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text;
            string password = txtPass.Text;

            if (cbUsrT.SelectedIndex == 0)
            {
                Student stu = StudentDB.GetWithUsername(username);
                if (stu == null)
                {
                    MessageBox.Show("No such student");
                }
                else
                {
                    if (stu.Password != password)
                    {
                        MessageBox.Show("Wrong password");
                    }
                    else
                    {
                        Settings form = new Settings(stu);
                        form.Show();
                    }
                }
            }
            else
            {
                Teacher tea = TeacherDB.GetWithUsername(username);
                if (tea == null)
                {
                    MessageBox.Show("No such teacher");
                }
                else
                {
                    if (tea.Password != password)
                    {
                        MessageBox.Show("Wrong password", "Error");
                    }
                    else
                    {
                        Settings form = new Settings(tea);
                        form.Show();
                    }
                }
            }
        }
    }
}
