using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotem_Management_System_V1._0
{
    public partial class Dash1 : Form
    {
        public Dash1()
        {
            InitializeComponent();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void Dash1_Load(object sender, EventArgs e)
        {

        }

        private void pctRegister_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Close();
        }

        private void pctReserve_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();
            reserve.Show();
            this.Close();
        }

        private void pctRestaurant_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Show();
            this.Close();
        }

        private void pctLimousine_Click(object sender, EventArgs e)
        {
            Taxi taxi = new Taxi();
            taxi.Show();
            this.Close();
        }
    }
}
