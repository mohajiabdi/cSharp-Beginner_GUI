using System.IO;
namespace System_File_IO_2_Lap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //StreamWriter fileW;
            ////OPen File
            //fileW = File.AppendText("test.txt");

            //// Process 
            //fileW.WriteLine("Hello ");
            //fileW.WriteLine("Dariskeena ");
            //fileW.WriteLine("Alxamdulilaah!");

            ////close()
            //fileW.Close();




            //StreamReader fileR;
            ////Open File
            //fileR = File.OpenText("test.txt");
            //// process read file
            //txtDis.Text = fileR.ReadToEnd();

            //// CLose..
            //fileR.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fileWrite;
                fileWrite = File.AppendText(saveFileDialog1.FileName);
                fileWrite.WriteLine(txtDis.Text);
                fileWrite.Close();
                MessageBox.Show("FIle Has Been Saved!!");
                txtDis.Text = "";
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
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
