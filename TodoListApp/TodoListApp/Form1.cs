using System.Data;

namespace TodoListApp
{
    public partial class Todo : Form
    {
        public Todo()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        bool isEdit = false;

        private void Todo_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Title");
            dt.Columns.Add("Description");

            todoListTable.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                dt.Rows[todoListTable.CurrentCell.RowIndex]["Title"] = txtTitle.Text;
                dt.Rows[todoListTable.CurrentCell.RowIndex]["Description"] = txtDesc.Text;
            }
            else
            {
                dt.Rows.Add(txtTitle.Text, txtDesc.Text);
            }
            clearData();


        }

        void clearData()
        {
            txtDesc.Text = "";
            txtTitle.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            txtTitle.Text = dt.Rows[todoListTable.CurrentCell.RowIndex].ItemArray[0].ToString();
            txtDesc.Text = dt.Rows[todoListTable.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows[todoListTable.CurrentCell.RowIndex].Delete();

            }catch(Exception message)
            {
                Console.WriteLine("Deletion Failed !!"+ message);
            }
        }
    }
}
