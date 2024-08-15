using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_salon
{
    public partial class VALIDITYPRODUCT : Form
    {

        function fn = new function();
        string query;
        public VALIDITYPRODUCT()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {

                query = "Select * from addproducts  where manufacturing_date >= getdate()";
                setDataGrideview(query, "Valid Products", Color.Blue);
            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                query = "select * from  addproducts  where expiry_date <= getdate()";
                setDataGrideview(query, "Expired Products", Color.Red);
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                query = "select * from  addproducts";
                setDataGrideview(query, "View All Products", Color.Blue);
            }
        }

        private void setDataGrideview(string query,string LabelName,Color col )
        {
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
            OutputLbl2.Text = LabelName;
            OutputLbl2.ForeColor = col;
        }

        private void VALIDITYPRODUCT_Load(object sender, EventArgs e)
        {
            //MaximizeBox = false;
            //MinimizeBox = false;
            OutputLbl2.Text = "";
        }

        private void BackBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            DASHBOARD D1 = new DASHBOARD();
            D1.Show();
        }

    }
}
