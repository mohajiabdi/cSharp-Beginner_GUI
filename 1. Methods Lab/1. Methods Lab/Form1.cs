using System.Diagnostics;

namespace _1._Methods_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sum_Avg(10, 20, 30, 40);

            //txtDis.Text = OddEven(6).ToString();
            //txtDis.Text = speed(23, 2).ToString() + " KM/HR";

            //loops(100, 50);

            int num1 = 5000;
            int num2 = 200;
            int num3 = 30;


            order(ref num1, ref num2, ref num3);
            txtDis.Text += num1.ToString() +" "+ num2.ToString()+ " " + num3.ToString();
        }
        
        public void Sum_Avg(int a,  int b, int c, int d) {

            int sum = a + b + c + d;
            int avg = sum / 4;

            txtDis.Text = "The Sum is: "+ sum + "\n\n The Avg is: "+avg;
        }

        public string OddEven(int a)
        {
            if (a % 2 == 0)
            {
                return a+" is Even Number";
            }
            else
            {
                return a+" is Odd Number" ;
            }

        }

        public double speed(double distance, double time)
        {
            double speed = distance / time;

            return speed;
        }

        public void loops(int start, int end)
        {
            if (start > end)
            {
                for (int i = end; i <= start; i--)
                {
                    txtDis.Text += i.ToString() + " ";
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    txtDis.Text += i.ToString() + " ";
                }
            }
           
        }

        public void order(ref int a,ref int b,ref int c)
        {
            if (a >b) {
                int temp = a; 
                a = b;
                b = temp;
            }
         if ( a > c)
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
        }
    }
}
