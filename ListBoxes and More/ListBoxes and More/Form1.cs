namespace ListBoxes_and_More
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCountry.Text == "")
            {
                lblMessage.Text = "Write a Country Name in the TextBox!...";
                
            }
            else
            {

                lstCountryNames.Items.Add(txtCountry.Text);
               
            }
            txtCountry.Text = "";
            txtCountry.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCountryNames.Items.Clear();
            txtCountry.Text = "";
            txtCountry.Focus();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "The Total List is: " + lstCountryNames.Items.Count.ToString();
            txtCountry.Text = "";
            txtCountry.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int index = lstCountryNames.SelectedIndex;
            index = lstCountryNames.FindString(txtCountry.Text);


            if (index != ListBox.NoMatches && txtCountry.Text != "")
            {

                string foundItemText = lstCountryNames.Items[index].ToString();
                lblMessage.Text = "Found Item is : " + foundItemText;


            }
            else
            {
               

                lblMessage.Text = "Item Not Found";

            }
            txtCountry.Text = "";
            txtCountry.Focus();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCountryNames.SelectedItem != null)
            {
                lstCountryNames.Items.Remove(lstCountryNames.SelectedItem);
                lblMessage.Text = "Selected Item Removed!...";
            }
            else
            {
                lblMessage.Text = "No Item Selected!...";
            }
            txtCountry.Text = "";
            txtCountry.Focus();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lstCountryNames.SelectedIndex != ListBox.NoMatches)
            {
                if (txtCountry.Text != "")
                {
                    lstCountryNames.Items.Insert(lstCountryNames.SelectedIndex, txtCountry.Text);
                    
                    lblMessage.Text = "New Item Inserted!...";
                    int index = lstCountryNames.SelectedIndex;
                    index -= 1;
                    lblMessage.Text = "New Country Name: "+ txtCountry.Text +" At Index: "+ index;

                }
                else
                {
                    lblMessage.Text = "Write a Country Name in the TextBox!...";
                }
            }
            else
            {
                lblMessage.Text = "Please Select An Item!..";
            }
            txtCountry.Text = "";
            txtCountry.Focus();
        }

        private void btnSelectedItem_Click(object sender, EventArgs e)
        {
            int index = lstCountryNames.SelectedIndex;

            if (index != ListBox.NoMatches)
            {

                string foundItemText = lstCountryNames.Items[index].ToString();
                lblMessage.Text = "Selected Item is : " + foundItemText;
                txtCountry.Text = "";
                txtCountry.Focus();

            }
            else
            {
                lblMessage.Text = "No Item Selected!..";
                txtCountry.Text = "";
                txtCountry.Focus();
            }
        }

        private void btnSelectedIndex_Click(object sender, EventArgs e)
        {
            int index = lstCountryNames.SelectedIndex;

            if (index != ListBox.NoMatches)
            {


                lblMessage.Text = "Selected Index is: " + index;
                txtCountry.Text = "";
                txtCountry.Focus();

            }
            else
            {
                lblMessage.Text = "No Item Selected!...";
                txtCountry.Text = "";
                txtCountry.Focus();
            }
        }

        private void lstCountryNames_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstCountryNames.SelectedIndex = -1;
        }
    }
}
