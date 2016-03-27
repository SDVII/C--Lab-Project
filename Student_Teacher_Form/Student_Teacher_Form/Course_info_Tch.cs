using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Form
{
    
    public partial class Course_info_Tch : Form
    {
        String filename;
        String path;
        String bName;
        String uName;
        Boolean bClicked = false;
        Boolean uClicked = false;

        public Course_info_Tch()
        {
            InitializeComponent();
        }

        private void btnBrwsD_Click(object sender, EventArgs e)
        {
            bClicked = true;
            var btn = (Button)sender;
            bName = btn.Name;

        }

        private void btnUpD_Click(object sender, EventArgs e)
        {
            uClicked = true;
            var btn = (Button)sender;
            uName = btn.Name;
        }

        private void Course_info_Tch_Enter(object sender, EventArgs e)
        {
            if (bClicked == true)
            {
                ofd.Title = "Attach File";
                ofd.InitialDirectory = @"C:\";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = System.IO.Path.GetFileName(ofd.FileName);
                    path = System.IO.Path.GetDirectoryName(ofd.FileName);
                    if (bName.Equals(btnBrwsD.Name))
                        txtPathD.Text = path + "//" + filename;
                    else
                        txtPathM.Text = path + "//" + filename;
                }
                bClicked = false;
                bName = "";
            }

            if(uClicked == true)
            {
                if (!Utilities.NullOrEmpty(txtPathD.Text))
                {
                    WebClient wc = new WebClient();
                    NetworkCredential nc = new NetworkCredential("", "");
                    Uri url;
                    if (uName.Equals(btnUpD.Name))
                    {
                        url = new Uri(@"" + filename);
                    }
                    else
                    {
                        url = new Uri(@"" + filename);
                    }
                    wc.Credentials = nc;
                    byte[] arrReturn = wc.UploadFile(url, txtPathD.Text);
                    MessageBox.Show(arrReturn.ToString());
                }
                uClicked = false;
                uName = "";
            }
        }
    }
}
