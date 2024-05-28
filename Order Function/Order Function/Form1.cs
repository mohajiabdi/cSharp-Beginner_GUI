namespace Order_Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Make Variable to Sort... From low To High 
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            int num4 = int.Parse(txtNum4.Text);
            int num5 = int.Parse(txtNum5.Text);
            lblDis.Text = " ";

            // Displaying the Values Before Sorting
            lblDis.Text += "Diplaying Before Sortin in Ascending Order:-\n" + num1.ToString() + ", " + num2.ToString() + ", " + num3.ToString()
               +", " + num4.ToString() + ", " + num5.ToString();

            lblDis.Text += "\n \n";

            // Changing The order to Ascending.... Using Order Function....
            Order(ref num1, ref num2, ref num3, ref num4, ref num5);

            // Displaying the Values After Sorting
            lblDis.Text += "Diplaying After Sortin in Ascending Order:-\n" + num1.ToString() + ", " + num2.ToString() + ", " + num3.ToString()
              +", "  + num4.ToString() + ", " + num5.ToString();



            ClearData();

        }

        public void Order(ref int a, ref int b, ref int c, ref int d, ref int e)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            if (a > c)
            {
                int temp = a;
                a = c;
                c = temp;
            }
            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }

            if (c > d)
            {
                int temp = c;
                c = d;
                d = temp;
            }

            if (d > e)
            {
                int temp = d;
                d = e;
                e = temp;
            }
        }

        public void ClearData()
        {
            txtNum1.Text = "";
            txtNum3.Clear();
            txtNum2.Clear();
            txtNum4.Clear();
            txtNum5.Clear();
            txtNum1.Focus();
        }
    }
}
