namespace Lab_Assignment__04_06_2024_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            int input;
            input = int.Parse(txtInput.Text);

            CalcAge(input);
            clearData();
        }


        public void CalcAge(int year)
        {
            if (year < 0)
            {
                txtDis.Text = "Enter Positive Year";
            }
            else
            {
                int days = year * 365;
                txtDis.Text += days.ToString() + " Days\n";
            }
        }

        public void clearData()
        {
            txtInput.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);

            int result = Addition(input);
            txtDis.Text += result.ToString() + " \n";
            clearData();

        }

        public int Addition(int n)
        {
            n++;
            return n;
        }

        public int minuteToSeconds(int minutes)
        {
           
            return minutes * 60;
        }

        private void btnSeconds_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);

            int seconds = minuteToSeconds(input); 

            txtDis.Text += seconds.ToString() + " Seconds\n";
            clearData() ;
        }
    }
}
