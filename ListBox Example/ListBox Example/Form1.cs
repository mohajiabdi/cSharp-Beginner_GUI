using System.Windows.Forms;

namespace ListBox_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbCountries.Items.Add(txtCountries.Text);

            txtCountries.Text = string.Empty;

            txtCountries.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Create a list to store the selected indices
            List<int> indicesToRemove = new List<int>();

            // Add the selected indices to the list You Created in reverse order
            for (int i = lbCountries.SelectedIndices.Count - 1; i >= 0; i--)
            {
                indicesToRemove.Add(lbCountries.SelectedIndices[i]);
            }

            // Remove the selected items from the ListBox You created in reverse order
            foreach (int indexToRemove in indicesToRemove)
            {
                lbCountries.Items.RemoveAt(indexToRemove);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbCountries.Items.Count.ToString());
        }

        private void btnSorted_Click(object sender, EventArgs e)
        {
            //lbCountries.Sorted = true;

            // Convert ListBox items to a List<string>
            List<string> items = new List<string>(lbCountries.Items.Cast<string>());

            // Sort the items in descending order
            items.Sort((a, b) => b.CompareTo(a));

            // Clear the ListBox
            lbCountries.Items.Clear();

            // Add the sorted items back to the ListBox
            lbCountries.Items.AddRange(items.ToArray());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbCountries.Items.Clear();
        }
    }
}
