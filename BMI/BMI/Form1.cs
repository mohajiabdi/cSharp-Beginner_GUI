namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            
            rbtnKg.Checked = true;
            txtWeight.Focus();
            txtWeight.BringToFront();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            string weightText = txtWeight.Text;
            //double weight = double.Parse(weightText);

            string heightText = txtHeight.Text;
            //double height = double.Parse(heightText);


            if (double.TryParse(weightText, out double weight) && double.TryParse(heightText, out double height))
            {
                

                // Calculation logic using weight and height


                if (rbtnKg.Checked && rbtnMeters.Checked)
                {
                    double Result = weight / (height * height);

                    
                    int decimalPlaces = 2;
                    double roundedResult = Math.Round(Result, decimalPlaces);
                    
                    lblResult.Text = "Your BMI Is: " + roundedResult.ToString();
                    // MessageBox.Show("Your BMI Is; " + Result);
                }
                else if (rbtnKg.Checked && rbtnCm.Checked)
                {
                    height = height / 100;
                    double Result = weight / (height * height);

                    int decimalPlaces = 2;
                    double roundedResult = Math.Round(Result, decimalPlaces);

                    lblResult.Text = "Your BMI Is: " + roundedResult.ToString();
                }
                else if (rbtnPounds.Checked && rbtnMeters.Checked)
                {
                    weight = weight * 0.45359237;
                    double Result = weight / (height * height);

                    int decimalPlaces = 2;
                    double roundedResult = Math.Round(Result, decimalPlaces);

                    lblResult.Text = "Your BMI Is: " + roundedResult.ToString();
                }
                else if(rbtnPounds.Checked && rbtnCm.Checked)
                {
                    weight = weight * 0.45359237;
                    height = height / 100;
                    double Result = weight / (height * height);

                    int decimalPlaces = 2;
                    double roundedResult = Math.Round(Result, decimalPlaces);

                    lblResult.Text = "Your BMI Is: " + roundedResult.ToString();
                }
               
            }
            else
            {
                MessageBox.Show("Invalid weight or height entered!");
            }

        }

        private void rbtnPounds_CheckedChanged(object sender, EventArgs e)
        {

            txtWeight.PlaceholderText = "Enter The Weight in Pounds!";

        }

        private void rbtnKg_CheckedChanged(object sender, EventArgs e)
        {
            txtWeight.PlaceholderText = "Enter The Weight in Kilograms!";
        }

        private void rbtnCm_CheckedChanged(object sender, EventArgs e)
        {
            txtHeight.PlaceholderText = "Enter The Height in Centimeters!";
        }

        private void rbtnMeters_CheckedChanged(object sender, EventArgs e)
        {
            txtHeight.PlaceholderText = "Enter The Height in Meters!";
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            
        }
    }
}
