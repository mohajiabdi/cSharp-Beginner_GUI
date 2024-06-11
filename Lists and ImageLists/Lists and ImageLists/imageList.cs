using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists_and_ImageLists
{
    public partial class imageList : Form
    {
        public imageList()
        {
            InitializeComponent();
        }
        int initialimg = 0;
        private void btnChange_Click(object sender, EventArgs e)
        {
            picSHow.Image = imgLists.Images[initialimg];
            //initialimg++;

            if (initialimg == imgLists.Images.Count - 1)
            {
                initialimg = 0;
            }
            else
            {
                initialimg++;
            }
        }
        int initialSec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            picSHow.Image = imgLists.Images[initialSec];
            //initialSec++;
            if(initialSec ==  imgLists.Images.Count - 1) { initialSec = 0;
            }
            else
            {
                initialSec++;
            }
        }
    }
}
