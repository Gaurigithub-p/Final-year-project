using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using System.Configuration;

namespace Pet_salon
{
    public partial class CUSTOMER : Form
    {
        SqlConnection conn;
        SqlCommand cmd;        
        SqlDataAdapter adapter;
        DataTable dt; 

        public CUSTOMER()
        {
            InitializeComponent();
        }

        double val;
        string ID = "C";
        
        private void AutoNumber()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(customer_id) FROM [customer_detail]", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            CustomerIdLbl.Text = ID+val+i.ToString(); 
        } 

        void GetCustomerDetail()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            adapter = new SqlDataAdapter("SELECT * FROM customer_detail", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Close();
        }       

        private void CUSTOMER_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            GetCustomerDetail();
            AutoNumber();
            SearchData("");

            CustomerNameTxt1.Clear();
            LastNameTxt2.Clear();
            GenderCmboBx.ResetText();
            ContactTxt3.Clear();
            MailTxt4.Clear();
            AddressTxt5.Clear();
                   
        }

        private void SearchTxt6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }   

        private void SearchTxt6_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNameTxt1.Text == "")
            {   
                CustomerNameTxt1.BackColor= Color.IndianRed;    
                MessageBox.Show("Please Enter First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerNameTxt1.Focus();
                return;
            }

            if (LastNameTxt2.Text == "")
            {
                LastNameTxt2.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTxt2.Focus();
                return;
            }

            if (GenderCmboBx.Text == "")
            {
                
                MessageBox.Show("Please Select Gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ContactTxt3.Text == "")
            {
                ContactTxt3.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Phone no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContactTxt3.Focus();
                return;
            }

            if (ContactTxt3.Text.Length < 10)
            {
                ContactTxt3.BackColor = Color.IndianRed;
                MessageBox.Show("Plaease Enter Only 10 Digits.");
                ContactTxt3.Focus();
                return;
            }

            if (MailTxt4.Text == "")
            {
                MailTxt4.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Email ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MailTxt4.Focus();
                return;
            }

            if (AddressTxt5.Text == "")
            {
                AddressTxt5.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddressTxt5.Focus();
                return;
            }

            conn.Open();
            SqlCommand CommandToCheckCustomerId = new SqlCommand("SELECT customer_id FROM customer_detail WHERE customer_id ='" + CustomerIdLbl.Text +"'",conn);
            string Cid = (string)CommandToCheckCustomerId.ExecuteScalar();
            conn.Close();

            if (Cid == CustomerIdLbl.Text)
            {
                MessageBox.Show("Customer ID Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string querry = "INSERT INTO customer_detail (customer_id, first_name, last_name, gender, contact, email_id, address, date) values" +
                    "(@customer_id, @first_name, @last_name, @gender, @contact, @email_id, @Address, @date)";

                cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@customer_id", CustomerIdLbl.Text);
                cmd.Parameters.AddWithValue("@first_name", CustomerNameTxt1.Text.ToString());
                cmd.Parameters.AddWithValue("@last_name", LastNameTxt2.Text.ToString());
                cmd.Parameters.AddWithValue("@gender", GenderCmboBx.Text);
                cmd.Parameters.AddWithValue("@contact", ContactTxt3.Text);
                cmd.Parameters.AddWithValue("@email_id", MailTxt4.Text);
                cmd.Parameters.AddWithValue("@address", AddressTxt5.Text);
                cmd.Parameters.AddWithValue("@date", DTP1.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Customer Details Inserted SuccesfuLly.");

                GetCustomerDetail();
                CustomerNameTxt1.Clear();
                LastNameTxt2.Clear();
                GenderCmboBx.ResetText();
                ContactTxt3.Clear();
                MailTxt4.Clear();
                AddressTxt5.Clear();
                AutoNumber();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string id = CustomerIdLbl.Text;
            bool idExists = false;
            bool dataChanged = false;

            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (row.Cells["customer_id"].Value != null && row.Cells["customer_id"].Value.ToString() == id)
                {
                    idExists = true;

                    if (row.Cells["first_name"].Value.ToString() != CustomerNameTxt1.Text
                        || row.Cells["last_name"].Value.ToString() != LastNameTxt2.Text
                        || row.Cells["gender"].Value.ToString() != GenderCmboBx.Text
                        || row.Cells["contact"].Value.ToString() != ContactTxt3.Text
                        || row.Cells["email_id"].Value.ToString() != MailTxt4.Text
                        || row.Cells["address"].Value.ToString() != AddressTxt5.Text
                        || row.Cells["date"].Value.ToString() != DTP1.Text)
                    {
                        dataChanged = true;
                    }
                }
            }

            if (idExists)
            {
                if (dataChanged)
                {
                    if (CustomerNameTxt1.Text != "" && LastNameTxt2.Text != "" && ContactTxt3.Text != "" && MailTxt4.Text != "" && AddressTxt5.Text != "" && DTP1.Text != "")
                    {
                        string querry = "UPDATE customer_detail " +
                            "SET first_name=@first_name, last_name=@last_name, gender=@gender, contact=@contact, email_id=@email_id, address=@address, date=@date WHERE customer_id=@customer_id";

                        cmd = new SqlCommand(querry, conn);
                        cmd.Parameters.AddWithValue("@customer_id", CustomerIdLbl.Text);
                        cmd.Parameters.AddWithValue("@first_name", CustomerNameTxt1.Text);
                        cmd.Parameters.AddWithValue("@last_name", LastNameTxt2.Text);
                        cmd.Parameters.AddWithValue("@gender", GenderCmboBx.Text);
                        cmd.Parameters.AddWithValue("@contact", ContactTxt3.Text);
                        cmd.Parameters.AddWithValue("@email_id", MailTxt4.Text);
                        cmd.Parameters.AddWithValue("@address", AddressTxt5.Text);
                        cmd.Parameters.AddWithValue("@date", DTP1.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Customer Details Updated Successfully.");

                        GetCustomerDetail();
                        CustomerNameTxt1.Clear();
                        LastNameTxt2.Clear();
                        GenderCmboBx.ResetText();
                        ContactTxt3.Clear();
                        MailTxt4.Clear();
                        AddressTxt5.Clear();
                        AutoNumber();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Data To Update.");
                    }
                }
                else
                {
                    MessageBox.Show("No changes has made to the customer data.");
                }
            }
            else
            {
                MessageBox.Show("Customer ID Does Not Exist.");
            }
        }

        private void ClearBtn4_Click(object sender, EventArgs e)
        {
            GetCustomerDetail();
            CustomerNameTxt1.Clear();
            LastNameTxt2.Clear();
            GenderCmboBx.ResetText();
            ContactTxt3.Clear();
            MailTxt4.Clear();
            AddressTxt5.Clear();
            AutoNumber();
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            DASHBOARD D1 = new DASHBOARD();
            D1.Show();
        }

        private void CustomerNameTxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LastNameTxt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ContactTxt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,Invalid Phone Number.");
            }
        }

        private void CustomerNameTxt1_TextChanged(object sender, EventArgs e)
        {
            CustomerNameTxt1.BackColor = Color.White;
        }

        private void LastNameTxt2_TextChanged(object sender, EventArgs e)
        {
            LastNameTxt2.BackColor = Color.White;
        }

        private void ContactTxt3_TextChanged(object sender, EventArgs e)
        {
            ContactTxt3.BackColor = Color.White;
        }

        private void MailTxt4_TextChanged(object sender, EventArgs e)
        {
            MailTxt4.BackColor = Color.White;
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z)*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(MailTxt4.Text, pattern))
            {
                ErrorProvider1.Clear();
            }
            else
            {
                ErrorProvider1.SetError(this.MailTxt4, "Invalid Email ID.");
                return;
            }
        }

        private void AddressTxt5_TextChanged(object sender, EventArgs e)
        {
            AddressTxt5.BackColor = Color.White;
        }

         private void DTP1_ValueChanged(object sender, EventArgs e)
         {
            if(DateTime.Today < DTP1.Value)
            {
                MessageBox.Show("Selected Date is Invalid","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP1.Value =DateTime.Today;
            }
         }
        
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdLbl.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            CustomerNameTxt1.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            LastNameTxt2.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            GenderCmboBx.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            ContactTxt3.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            MailTxt4.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            AddressTxt5.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            DTP1.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void CustomerNameTxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                LastNameTxt2.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.","Disable",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void LastNameTxt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                GenderCmboBx.Focus();
            }

            
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ContactTxt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                MailTxt4.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MailTxt4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                AddressTxt5.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddressTxt5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                DTP1.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchTxt6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       

        private void SearchTxt6_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt6.Text);
        } 
        
        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM customer_detail WHERE email_id LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
            AutoNumber();
            CustomerNameTxt1.Clear();
            LastNameTxt2.Clear();
         //   Gender1.Clone();
            ContactTxt3.Clear();
            MailTxt4.Clear();
            AddressTxt5.Clear();
        }

        private void CustomerNameTxt1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void LastNameTxt2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                CustomerNameTxt1.Focus();
            }
        }

        private void ContactTxt3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                GenderCmboBx.Focus();
            }
        }

        private void MailTxt4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ContactTxt3.Focus();
            }
        }

        private void AddressTxt5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                MailTxt4.Focus();
            }
        }

        private void DTP1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                AddressTxt5.Focus();
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void GenderCmboBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.KeyCode == Keys.Down)
            {
                ContactTxt3.Focus();
            }
        }

        private void GenderCmboBx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                LastNameTxt2.Focus();
            }
        }

        private void GenderCmboBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }
    }  
}