namespace _2D_array_and_Jagged_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int row = 3, col = 4;
            int[,] data = new int [row,col];

            // Assigning Values

            data[0,0] = 1;
            data[0,1] = 5;
            data[0, 2] = 4;
            data[0, 3] = 6;
            data[1, 0] = 5;
            data[1,1] = 2;
            data[2,2] = 3;
            data[2,3] = 3;
            data[2, 0] = 4;

            txtDis.Text += "Displaying One element in 2D Array:- \n";
            txtDis.Text += data[2, 0].ToString() +" \n";

            txtDis.Text += "Displaying Multiple elements in 2D Array:- \n";

            for (int r =0; r < row; r++)
            {
                for(int c =0; c < col; c++)
                {
                    txtDis.Text += data[r, c] + ", ";
                }
                txtDis.Text += "\n";
            }

            // Create Jagged array 

            int[][] jagg = new int[4][];

            jagg[0] = new int[4] { 2, 6, 7, 8 };
            jagg[1] = new int[2] { 4,9 };
            jagg[2] = new int[3] { 7,0,4 };
            jagg[3] = new int[5] { 0, 6, 7, 8,10 };

            txtDis.Text += "\nDisplaying One element in Jagged Array:- \n";
            txtDis.Text += jagg[3][2].ToString();

            txtDis.Text += "\n\nDisplaying One element in Jagged Array:- \n";


            for(int r =0; r < jagg.Length; r++)
            {
                for(int element = 0; element < jagg[r].Length; element++)
                {
                    txtDis.Text += jagg[r][element].ToString() + ", ";
                }
                txtDis.Text += "\n";
            }




        }
    }
}
