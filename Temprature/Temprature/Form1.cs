namespace Temprature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double cel = double.Parse(txtCelcius.Text);
            double fahr = (cel * 9 / 5) + 32;
           
            lblMessage.Text = "The Fahrenheit is " + fahr.ToString() + " F";

        }
    }
}
