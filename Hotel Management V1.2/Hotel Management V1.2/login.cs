using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_V1._2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtUsername.Focus();
            txtUsername.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = "admin";
            String password = "pass";

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (txtUsername.Text != username || txtPassword.Text != password)
                {
                    MessageBox.Show("Incorrect Username or Password");
                    ClearData();
                }
                else
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Fill In The Blank Space!!.");
            }
            void ClearData()
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
