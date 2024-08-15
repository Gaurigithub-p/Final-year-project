using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_salon
{
    public partial class ADDPRODUCT : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public ADDPRODUCT()
        {
            InitializeComponent();
        }

        void GetProductDetails()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM addproducts", conn);
            conn.Open();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ADDPRODUCT_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            GetProductDetails();
            PBrandCmboBx1.ResetText();
            PNameTxt2.Clear();
            SNameTxt3.Clear();
         //   QuantityCmboBx2.ResetText();
            PriceTxt1.Clear();
        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            if (PBrandCmboBx1.Text == "")
            {
                PBrandCmboBx1.BackColor = Color.IndianRed;
                MessageBox.Show("Please select Product Brand Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PBrandCmboBx1.Focus();
                return;
            }

            if (PNameTxt2.Text == "")
            {
                PNameTxt2.BackColor = Color.IndianRed;
                MessageBox.Show("Please enter Product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PNameTxt2.Focus();
                return;
            }

            if (SNameTxt3.Text == "")
            {
                SNameTxt3.BackColor = Color.IndianRed;
                MessageBox.Show("Please enter Supplier Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SNameTxt3.Focus();
                return;
            }

            if (PriceTxt1.Text == "")
            {
                PriceTxt1.BackColor = Color.IndianRed;
                MessageBox.Show("Please enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriceTxt1.Focus();
                return;
            }

            string querry = "INSERT INTO addproducts (product_brand,product_name,supplier_name,manufacturing_date,expiry_date,quantity,price) values" +
                "(@product_brand,@product_name,@supplier_name,@manufacturing_date,@expiry_date,@quantity,@price)";

            cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@product_brand", PBrandCmboBx1.Text);
            cmd.Parameters.AddWithValue("@product_name", PNameTxt2.Text);
            cmd.Parameters.AddWithValue("@supplier_name", SNameTxt3.Text);
            cmd.Parameters.AddWithValue("@price", PriceTxt1.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product Details Inserted Succesfuly.");
            GetProductDetails();
        }

        private void PNameTxt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SNameTxt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PriceTxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PBrandCmboBx1_TextChanged(object sender, EventArgs e)
        {
            PBrandCmboBx1.BackColor = Color.White;
        }

        private void PNameTxt2_TextChanged(object sender, EventArgs e)
        {
            PNameTxt2.BackColor = Color.White;
        }

        private void SNameTxt3_TextChanged(object sender, EventArgs e)
        {
            SNameTxt3.BackColor = Color.White;
        }

        private void PriceTxt1_TextChanged(object sender, EventArgs e)
        {
            PriceTxt1.BackColor = Color.White;
        }    

        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE addproducts " +
               "SET product_brand=@product_brand,product_name=@product_name,supplier_name=@supplier_name, manufacturing_date=@manufacturing_date, expiry_date=@expiry_date, quantity=@quantity, price=@price WHERE product_brand=@product_brand";

            cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@product_brand", PBrandCmboBx1.Text);
            cmd.Parameters.AddWithValue("@product_name", PNameTxt2.Text);
            cmd.Parameters.AddWithValue("@supplier_name", SNameTxt3.Text);
            cmd.Parameters.AddWithValue("@price", PriceTxt1.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product Details Updated Succesfuly.");

            GetProductDetails();
            PBrandCmboBx1.ResetText();
            PNameTxt2.Clear();
            SNameTxt3.Clear();
         //   QuantityCmboBx2.ResetText();
            PriceTxt1.Clear();
        }

        private void ClearBtn3_Click(object sender, EventArgs e)
        {
            GetProductDetails();
            PBrandCmboBx1.ResetText();
            PNameTxt2.Clear();
            SNameTxt3.Clear();
         //   QuantityCmboBx2.ResetText();
            PriceTxt1.Clear();
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            DASHBOARD d1 = new DASHBOARD();
            d1.Show();
        }

        private void DataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            PBrandCmboBx1.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            PNameTxt2.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            SNameTxt3.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
       //     QuantityCmboBx2.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            PriceTxt1.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void QuantityCmboBx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
