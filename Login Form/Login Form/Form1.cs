namespace Login_Form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (String.IsNullOrWhiteSpace(username) && String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password are required!!");
            }
            else if (String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Passowrd is required!!");
            }
            else if (String.IsNullOrWhiteSpace(username))
            {

                MessageBox.Show("Username is required!!!");
            }
            else
            {
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
       

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtUsername.BringToFront();
        }
    }
}
