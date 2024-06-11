namespace Lists_and_ImageLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Making List In Public 
        List<string> magacyo = new List<string>();


        private void Form1_Load(object sender, EventArgs e)
        {
           

            magacyo.Add("Ahmed");
            magacyo.Add("Geedi");
            magacyo.Add("Raage");
            magacyo.Add("Salma");
            magacyo.Add("Safiyo");
            magacyo.Add("Asho");


            //Innser Method 
            magacyo.Insert(0, "Farhiyo");
            magacyo.Insert(4, "Asma");


            //Removing items from the list:-
            //Using Remove 
            magacyo.Remove("Ahmed");
            //Using RemoveAt
            magacyo.RemoveAt(4);


            


            foreach (string magac in magacyo)
            {
                txtDis.Text += magac.ToString() + ", ";
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //Using Count Method
            txtDis.Text += "------------------------\n";
            txtDis.Text += "Total Count is: " + magacyo.Count().ToString() + "\n \n";

        }
    }
}
