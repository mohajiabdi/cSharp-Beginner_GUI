using System.Windows.Forms;

namespace File_System_IO_Beginner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Made by Mo Haji Abdi Raage 
            //    Stduent from Jamhurya
            // File System Read and Write to files txt type
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean test = txtFullName.Text != "" && txtAge.Text != "" && txtRegion.Text != ""
                && txtTel.Text != "" && comboGender.SelectedIndex != -1;
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("Info.txt");

                if (test)
                {
                    outputFile.WriteLine("\n");
                    outputFile.Write(txtFullName.Text + ", ");
                    outputFile.Write(txtMother.Text + ", ");
                    outputFile.Write(txtAge.Text + ", ");
                    outputFile.Write(txtRegion.Text + ", ");
                    outputFile.Write(txtAddress.Text + ", ");
                    outputFile.Write(txtTel.Text + ", ");
                    outputFile.Write(comboGender.SelectedItem);


                    outputFile.Close();
                    ClearData();

                }
                else
                {
                    MessageBox.Show("Fill The Compulsury TextBoes.\nFullname\nAge\nRegion\nTelephone\nGender");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFullName.Focus();
            comboGender.SelectedIndex = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath = "Info.txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    lstInfo.Items.Clear();

                    // Read and add each line of the file to the ListBox
                    while ((line = reader.ReadLine()) != null)
                    {
                        
                        lstInfo.Items.Add(line);
                    }
                   

                }
                ClearData(); 
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file: " + ex.Message);
            }
        }
        void ClearData()
        {
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtMother.Text = "";
            txtTel.Text = "";
            txtRegion.Text = "";
            txtAge.Text = "";
            comboGender.SelectedIndex = 0;
        }
    }
}
