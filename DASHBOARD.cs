using System;
using System.Data;
using System.Windows.Forms;

namespace Pet_salon
{
    public partial class DASHBOARD : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void AptBtn6_Click(object sender, EventArgs e)
        {
            this.Hide();
            APPOINMENT a1 = new APPOINMENT();
            a1.Show();
        }

        private void HomeBtn1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUSTOMER c1 = new CUSTOMER();
            c1.Show();
        }

        private void PetBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PET p1 = new PET();
            p1.Show();
        }

        private void ServiceBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            G_SERVICE A1 = new G_SERVICE();
            A1.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN l1 = new LOGIN();
            l1.Show();
        }

        private void DASHBOARD_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            query = "select count(first_name) from customer_detail";
            ds = fn.getData(query);
            setLabel(ds, label6);

            query = "select count(pet_name) from pet_detail";
            ds = fn.getData(query);
            setLabel(ds, label7);

            query = "select count(grooming_id) from apt_grooming";
            ds = fn.getData(query);
            setLabel(ds, label8);

            query = "select count(boarding_id) from apt_boarding";
            ds = fn.getData(query);
            setLabel(ds, label9);
        }

        private void setLabel(DataSet ds,Label Lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                Lbl.Text = ds.Tables[0].Rows[0][0].ToString();   
            }
            else
            {
                Lbl.Text = "0";
            }
        }
    }
}
