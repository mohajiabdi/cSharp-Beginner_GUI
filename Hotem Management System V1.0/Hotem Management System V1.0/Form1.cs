using System.Security.Cryptography.X509Certificates;

namespace Hotem_Management_System_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = "admin";
            String password = "pass";

           if (txtUsername.Text !="" && txtPassword.Text != "")
            {
                if(txtUsername.Text != username || txtPassword.Text != password)
                {
                    MessageBox.Show("Incorrect Username or Password");
                    ClearData();
                }else
                {
                    Dash1 dashboard = new Dash1 ();
                    dashboard.Show();
                    this.Hide();
                    ClearData();
                }
            }else
            {
                MessageBox.Show("Fill In The Blank Space!!.");
            }
            void ClearData()
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
