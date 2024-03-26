using System.Diagnostics;

namespace Pizaa_Paradise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            String pizzaSize = "";
            String toppingType = "";
            double price = 0;
            int phone;

            if (rbSmall.Checked)
            {

                pizzaSize = "Small";
                price = 5;
                txtPrice.Text = price.ToString();

            }
            if (rbMedium.Checked)
            {

                pizzaSize = "Medium";
                price = 7;
                txtPrice.Text = price.ToString();

            }

            if (rbLarge.Checked)
            {

                pizzaSize = "Large";
                price = 10;
                txtPrice.Text = price.ToString();

            }

            if (pizzaSize == "") MessageBox.Show("Select Pizza Size..");

            if (chMushroms.Checked)
            {

                toppingType += "Mushroms, ";
                price += 0.5;
                txtPrice.Text = price.ToString();

            }
            if (chOnions.Checked)
            {

                toppingType += "Onions, ";
                price += 0.4;
                txtPrice.Text = price.ToString();

            }
            if (chCorn.Checked)
            {

                toppingType += "Corns, ";
                price += 0.7;
                txtPrice.Text = price.ToString();

            }

            if (toppingType == "") MessageBox.Show("Select Topping Type..");

            int quantiity = (int)nmQuantity.Value;
            double total = price * quantiity;
            double finalPrice = Math.Round(total, 2);
            //txtPrice.Text = finalPrice.ToString();

            String message = "\tTotal Summry:"
                + "\nCustomer Name: " + txtName.Text
                + "\nCutomer Phone: " + txtPhone.Text
                + "\nPizza Size: " + pizzaSize
                + "\nPizaa Toppings: " + toppingType
                + "\nPizza Quantity: " + quantiity
                + "\nTotal Price: " + finalPrice;



            txtPrice.Text = finalPrice.ToString()+ "$";

            if (int.TryParse(txtPhone.Text, out phone))
            {

                MessageBox.Show(message +"$");

            }
            else
            {
                MessageBox.Show("Invalid Phone Number!...");
            }

            ClearData();






        }

        private void nmQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nmQuantity.Value = 1;
            nmQuantity.Minimum = 1;
            nmQuantity.Maximum = 25;

            txtName.PlaceholderText = "Enter The Customer Name ";
            txtPhone.PlaceholderText = "Enter The Phone Number  ";
            txtPrice.PlaceholderText = "Total Price ";
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }
        void ClearData()
        {
            txtPrice.Text = "";
            txtName.Text = "";
            txtPhone.Text = string.Empty;
            chMushroms.Checked = false;
            chCorn.Checked = false;
            chOnions.Checked= false;
            rbLarge.Checked = false;
            rbSmall.Checked = false;
            rbMedium.Checked = false;
            nmQuantity.Value =1;
            rbSmall.Focus();
        }
    }
}
