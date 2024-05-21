namespace Random_Numbers
{
    public partial class Form1 : Form
    {
        int num1, num2, sum;
        int r;
        Random random;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            random = new Random();
            if(txtRandom.Text != "") {
                r = int.Parse(txtRandom.Text);


                num1 = random.Next(r);
                num2 = random.Next(r);
                //lblNumbers.Text = random.Next(10).ToString() +" + "+ random.Next(10).ToString();

                lblNumbers.Text = num1.ToString() + " + " + num2.ToString() + " =";
                sum = num1 + num2;
            }
            else
            {
                lblNumbers.Text = "Enter Set Limit";
            }


            lblResult.Text = string.Empty;
            


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
           if(txtUserAnswer.Text != "")
            {
                if (int.Parse(txtUserAnswer.Text) == sum)
                {
                    lblResult.BackColor = Color.Green;
                    lblResult.ForeColor = Color.White;
                    lblResult.Text = "Correct";
                }
                else
                {
                    lblResult.BackColor = Color.Red;
                    lblResult.ForeColor = Color.White;
                    lblResult.Text = "Incorrect!";
                }
            }
            else
            {
                lblResult.BackColor = Color.Yellow;
                lblResult.ForeColor = Color.Black;
                lblResult.Text = "Enter The Answer!!";
            }
            txtUserAnswer.Clear();
            lblNumbers.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
