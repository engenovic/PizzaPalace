using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPalace
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
       int counter;
        private void loader_Tick(object sender, EventArgs e)
        {
            pgBarSPlash.Increment(1);
            gunaLabel2.Text = pgBarSPlash.ProgressPercentText;
            counter++;
            if (counter >= 150)
           {
                loader.Enabled = false;
               this.Hide();
               frmDashb dashb = new frmDashb();
               dashb.Show();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            pgBarSPlash.Value = 0;
            loader.Start();
        }
    }
}
