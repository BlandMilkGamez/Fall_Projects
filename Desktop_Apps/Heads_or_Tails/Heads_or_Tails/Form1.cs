using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class frmCoinToss : Form
    {
        public frmCoinToss()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            picTails.Visible = true; picHeads.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picHeads.Visible = true;

        }

        private void btnheads_Click(object sender, EventArgs e)
        {
            picHeads.Visible = true;
        }

        private void btnheads_Click_1(object sender, EventArgs e)
        {
          
         
        }

        private void btnheads_Click_2(object sender, EventArgs e)
        {
            picHeads.Visible = true;
            picTails.Visible = false;
        }
    }
}
