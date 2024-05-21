namespace OpenFile_Class_Work_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtDis.Text = string.Empty;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader fileRead; 
                fileRead = File.OpenText(openFileDialog1.FileName);
                txtDis.Text = fileRead.ReadToEnd();
                fileRead.Close();

            }
        }
    }
}
