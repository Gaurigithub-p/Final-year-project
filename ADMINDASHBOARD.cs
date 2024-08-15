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
    public partial class ADMINDASHBOARD : Form
    {
        public ADMINDASHBOARD()
        {
            InitializeComponent();
        }

        
        private void ADMINDASHBOARD_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void EmpBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            EMPLOYEE E1 = new EMPLOYEE();
            E1.Show();
        }

        private void AttenBtn2_Click(object sender, EventArgs e)
        {
            this.Close();
            ATTENDANCE A1 = new ATTENDANCE();
            A1.Show();
        }

        private void ServiceBtn3_Click(object sender, EventArgs e)
        {
            this.Close();
            CATEGORY C1 = new CATEGORY();
            C1.Show();
        }

        private void BillBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            Bill B1 = new Bill();
            B1.Show();
        }

        private void LogoutBtn5_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN L1 = new LOGIN();
            L1.Show();
        }

        private void ServiceBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            SERVICE S1 = new SERVICE();
            S1.Show();
        }
    }
}
