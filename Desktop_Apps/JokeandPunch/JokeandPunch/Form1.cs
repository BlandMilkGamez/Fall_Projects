using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeandPunch
{
    public partial class frmJoke : Form
    {
        public frmJoke()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btwSetup_Click(object sender, EventArgs e)
        {
            lblJoke.Text = "Guess Who?";
        }

        private void btnPunchLine_Click(object sender, EventArgs e)
        {
            lblJoke.Text = "Chicken Poo";
        }
    }
}
