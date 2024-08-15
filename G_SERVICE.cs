using DGVPrinterHelper;
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
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Pet_salon
{

    public partial class G_SERVICE : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        function fn = new function();
        String query;
        double val;
        string ID = "Bill-";

        public G_SERVICE()
        {
            InitializeComponent();
            Fill_combo();
        }
           
        string dbConnectionString = "Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True";

        void Fill_combo()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            try
            {
                conn.Open();
                string querry = "SELECT category_name FROM add_category WHERE category_status='Active' ";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string category_name = dr.GetString(0);
                    CatCmboBx1.Items.Add(category_name);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AutoNumber()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(bill_id) FROM [bill]", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            IdLbl.Text = ID + val + i.ToString();
        }

        public void CB()
        {
            EmailCmboBx.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT email_id FROM customer_detail";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmailCmboBx.Items.Add(dr["email_id"].ToString());
            }
            conn.Close();
        }

        private void G_SERVICE_Load(object sender, EventArgs e)
        {
            AutoNumber();
            CatCmboBx1.ResetText();
            listBox1.Items.Clear();
            EmailCmboBx.ResetText();
            ServiceNameTxt.Clear();
            PriceTxt.Clear();
            CB();

            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void ShowItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            query = "SELECT service_name FROM add_service WHERE service_status='Active' ";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void CatCmboBx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Category = CatCmboBx1.Text;
            query = "SELECT service_name FROM add_service WHERE category_name = '" + Category + "' AND service_status='Active' ";
            ShowItemList(query);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DASHBOARD D1 = new DASHBOARD();
            D1.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            ServiceNameTxt.Text = text;
            query = "SELECT price FROM add_service WHERE service_name= '" + text + "' ";
            DataSet ds = fn.getData(query);
            try
            {
                PriceTxt.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {
            PriceTxt.BackColor = Color.White;

            if (Int64.TryParse(PriceTxt.Text, out Int64 Price))
            {

                // Parsing successful, do something with the Price variable
                // label9.Text = (Price + Price).ToString();
            }
            else
            {
               // MessageBox.Show("Price must be greater than zero.","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Parsing failed, handle the error
            }

            // Int64 Price = Int64.Parse(PriceTxt.Text);
            // label9.Text = (Price + Price).ToString();
        }

        private void PetNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void ServiceNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void PriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
   //         e.KeyChar = (char)0;
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
   //         e.KeyChar = (char)0;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There Is No Data To Print", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string dateTime = DateTime.Now.ToString();
            string billid = IdLbl.Text;
            string email = EmailCmboBx.Text;

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "FURRY - Pet Salon Bill";
            printer.SubTitle = string.Format("Date: {0}\nBill ID: {1}\nCustomer Email: {2}", dateTime, billid, email);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment= StringAlignment.Center;
            printer.Footer = "Total Payable Amount : " + PriceLbl.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
            total = 0;
            dataGridView1.Rows.Clear();
            PriceLbl.Text = "Rs. " + total;
            IdLbl.Text = "";
            EmailCmboBx.Text = "";
        }

        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            catch 
            {
                
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch
            {

            }
            total -= amount;
            PriceLbl.Text = "Rs. " + total;
        }

        protected int n, total = 0;

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmailCmboBx.Text == "")
            {
                EmailCmboBx.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Customer's Email ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailCmboBx.Focus();
                return;
            }

            if (ServiceNameTxt.Text == "")
            {
                ServiceNameTxt.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServiceNameTxt.Focus();
                return;
            }

            if (PriceTxt.Text == "")
            {
                PriceTxt.BackColor = Color.IndianRed;
                MessageBox.Show("Please Insert Price .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriceTxt.Focus();
                return;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (PriceLbl.Text != "0" && PriceLbl.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to Proceed?", "Data insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        SqlCommand CommandToCheckPetId = new SqlCommand("SELECT bill_id FROM bill WHERE bill_id ='" + IdLbl.Text + "'", conn);
                        string Pid = (string)CommandToCheckPetId.ExecuteScalar();
                        conn.Close();

                        if (Pid == IdLbl.Text)
                        {
                            MessageBox.Show("Bill Id Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string querry = "INSERT INTO bill(bill_id, email_id, date, total) values" +
                           "(@bill_id, @email_id, @date, @total)";

                            cmd = new SqlCommand(querry, conn);
                            cmd.Parameters.AddWithValue("@bill_id", IdLbl.Text);
                            cmd.Parameters.AddWithValue("@email_id", EmailCmboBx.Text);
                            cmd.Parameters.AddWithValue("@date", DTP1.Text);
                            cmd.Parameters.AddWithValue("@total", PriceLbl.Text);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Bill Details Saved Succesfully.");

                            CatCmboBx1.ResetText();
                            listBox1.Items.Clear();
                            ServiceNameTxt.Clear();
                            //  EmailCmboBx.ResetText();
                            PriceTxt.Clear();
                            CB();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Fill All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record not inserted.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select Atleast 1 Service.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            EmailCmboBx.Enabled = true;

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CatCmboBx1.ResetText();
            listBox1.Items.Clear();
            ServiceNameTxt.Clear();
            EmailCmboBx.ResetText();
            PriceTxt.Clear();
        }

        private void EmailCmboBx_TextChanged(object sender, EventArgs e)
        {
            emailSelected = true;
            EmailCmboBx.BackColor = Color.White;
        }

        private void DTP1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > DTP1.Value || DateTime.Today < DTP1.Value)
            {
                MessageBox.Show("Selected Date is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP1.Value = DateTime.Today;
            }
        }

        private void ServiceNameTxt_TextChanged(object sender, EventArgs e)
        {
            ServiceNameTxt.BackColor = Color.White;
        }

        private void PriceLbl_Click(object sender, EventArgs e)
        {

        }

        bool emailSelected = false;

        private void EmailCmboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmailCmboBx.Enabled = false;
        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            if (EmailCmboBx.Enabled)
            {
                // The user has not selected an email yet
                MessageBox.Show("Please select a customer's email ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PriceTxt.Text != "0" && PriceTxt.Text != "")
            {
                // Check if an email has already been selected
                if (!emailSelected)
                {
                    // Prompt the user to select an email if one hasn't been selected yet
                    MessageBox.Show("Please select an email before adding to cart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = CatCmboBx1.Text;
                dataGridView1.Rows[n].Cells[1].Value = ServiceNameTxt.Text;
                dataGridView1.Rows[n].Cells[2].Value = PriceTxt.Text;

                total += int.Parse(PriceTxt.Text);
                PriceLbl.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Select Atleast 1 Service.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
