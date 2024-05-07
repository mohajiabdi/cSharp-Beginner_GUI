namespace Loops_Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int start = 1;
            while (start <= 10)
            {
                // Using += assignment operator
                lblDis.Text += start.ToString() + "\n";
                start++;

            }

        }

        private void lblDis_Click(object sender, EventArgs e)
        {

        }
    }
}
