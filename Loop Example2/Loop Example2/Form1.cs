namespace Loop_Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDis.Text = "";


            if (txtStart.Text != "" && txtEnd.Text != "" && txtUpdate.Text != "")
            {
                int update = Convert.ToInt32(txtUpdate.Text);



                int start = Convert.ToInt32(txtStart.Text);
                int end = Convert.ToInt32(txtEnd.Text);


                if (start < end)
                {
                    for (int i = start; i <= end; i += update)
                    {
                        lblDis.Text += i.ToString() + "\n";
                    }
                }
                else
                {
                    for (int i = start; i >= end; i -= update)
                    {
                        lblDis.Text += i.ToString() + "\n";
                    }
                }
            }
            else
            {
                lblDis.Text = "Fill The Blank Spaces";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblDis.Text = "";
            txtUpdate.Text = "";
            txtStart.Text = "";
            txtEnd.Text = "";
            txtStart.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStart.Focus();
        }
    }
}
