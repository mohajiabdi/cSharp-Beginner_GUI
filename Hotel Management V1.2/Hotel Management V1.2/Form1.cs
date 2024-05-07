namespace Hotel_Management_V1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 3;
            pbar.Text = pbar.Value.ToString();
            if (pbar.Value == 100)
            {
                timer1.Enabled = false;
                login login = new login();
                login.Show();
                this.Hide();
            }
           
        }

        private void pbarDots_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
