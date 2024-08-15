using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_salon
{
    public partial class SPLASH : Form
    {
        public SPLASH()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            if(progressBar1.Value == 100)
            {
                timer1.Enabled = false;

                this.Hide();
                DASHBOARD D1 = new DASHBOARD();
                D1.ShowDialog();               
            }
        }
        
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void LoadLb1_Click(object sender, EventArgs e)
        {

        }
    }
}
