namespace WageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h, r;
            h = int.Parse(txtHours.Text);
            r = int.Parse(txtRate.Text);

            int result = h * r;
            //MessageBox.Show("The Money Earned by working " + h + " Hours is " + result);

            // lblMessage.Text = "The Money Earned by working " + h + " Hours is " + result.ToString();
            lblMessage.Text = result.ToString("c");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
