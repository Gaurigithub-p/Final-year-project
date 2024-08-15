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
    public partial class APPOINMENT : Form
    {
        public APPOINMENT()
        {
            InitializeComponent();
        }

        private void GroomBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            APGROOMING A1 = new APGROOMING();
            A1.Show();
        }

        private void BoardBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            APBOARDING B1 = new APBOARDING();
            B1.Show();
        }

        private void APPOINMENT_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
