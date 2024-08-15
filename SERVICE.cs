using System;
using System.Collections;
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
    public partial class SERVICE : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public SERVICE()
        {
            InitializeComponent();
            Fill_combo();
        }

        double val;
        string ID = "S";

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
                    CatCombox.Items.Add(category_name);
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
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(service_id) FROM [add_service]", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            IdLbl.Text = ID + val + i.ToString();
        }

        void GetServiceDetail()
        {
           /* string connectionString = "Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM add_service WHERE category_name IN (SELECT category_name FROM add_category WHERE category_status = 'Active')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Add data to DataGridView
                        }
                    }

                    reader.Close();
                }
            }  

            string connectionString = "Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True";
            string query = "SELECT * FROM add_service WHERE category_name IN (SELECT category_name FROM add_category WHERE category_status = Active ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }  */

                 conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
                 adapter = new SqlDataAdapter("SELECT * FROM add_service", conn);
                 dt = new DataTable();
                 conn.Open();
                 adapter.Fill(dt);
                 dataGridView1.DataSource = dt;
                 conn.Close();  
        }

        private void SERVICE_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            GetServiceDetail();
            AutoNumber();
            SearchData("");

            CatCombox.ResetText();
            ServiceTxt.Clear();
            PriceTxt.Clear();
            StatusCmboBx.ResetText();
        }

        public void CB()
        {
            CatCombox.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT category_name FROM add_category WHERE category_status= 'Active' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CatCombox.Items.Add(dr["category_name"].ToString());
            }
            conn.Close();
        }
        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            if (CatCombox.Text == "")
            {
                CatCombox.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CatCombox.Focus();
                return;
            }

            if (ServiceTxt.Text == "")
            {
                ServiceTxt.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Service Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServiceTxt.Focus();
                return;
            }

            if (PriceTxt.Text == "")
            {
                PriceTxt.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriceTxt.Focus();
                return;
            }

            if (StatusCmboBx.Text == "")
            {
                StatusCmboBx.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Activity Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StatusCmboBx.Focus();
                return;
            }

            conn.Open();
            SqlCommand CommandToCheckCustomerId = new SqlCommand("SELECT service_id FROM add_service WHERE service_id ='" + IdLbl.Text + "'", conn);
            string Sid = (string)CommandToCheckCustomerId.ExecuteScalar();
            conn.Close();

            if (Sid == IdLbl.Text)
            {
                MessageBox.Show("Service ID Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string querry = "INSERT INTO add_service (category_name,service_id, service_name,price,service_status) values" +
                    "(@category_name, @service_id, @service_name, @price, @service_status)";

                cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@category_name",CatCombox.Text);
                cmd.Parameters.AddWithValue("@service_id", IdLbl.Text);
                cmd.Parameters.AddWithValue("@service_name",ServiceTxt.Text);
                cmd.Parameters.AddWithValue("@price", PriceTxt.Text);
                cmd.Parameters.AddWithValue("@service_status", StatusCmboBx.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Service Details Inserted SuccesfuLly.");

                GetServiceDetail();
                AutoNumber();
                CatCombox.ResetText();
                ServiceTxt.Clear();
                PriceTxt.Clear();
                StatusCmboBx.ResetText();
                CB();
            }
        }

        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            string id = IdLbl.Text;
            bool idExists = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["service_id"].Value != null && row.Cells["service_id"].Value.ToString() == id)
                {
                    idExists = true;
                }
            }

            if (idExists)
            {
                if (CatCombox.Text != "" && ServiceTxt.Text != "" && PriceTxt.Text != "" && StatusCmboBx.Text !="")
                {
                    string querry = "UPDATE add_service " +
                   "SET category_name=@category_name, service_name=@service_name, " + "price=@price, service_status=@service_status  WHERE service_id=@service_id";


                    cmd = new SqlCommand(querry, conn);
                    cmd.Parameters.AddWithValue("@service_id", IdLbl.Text);
                    cmd.Parameters.AddWithValue("@category_name", CatCombox.Text);
                    cmd.Parameters.AddWithValue("@service_name", ServiceTxt.Text);
                    cmd.Parameters.AddWithValue("@price", PriceTxt.Text);
                    cmd.Parameters.AddWithValue("@service_status", StatusCmboBx.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Service Details Updated Succesfuly.");

                    GetServiceDetail();
                    AutoNumber();
                    CatCombox.ResetText();
                    ServiceTxt.Clear();
                    PriceTxt.Clear();
                    StatusCmboBx.ResetText();
                }
                else
                {
                    MessageBox.Show("Please Enter Data To Update.");
                }
            }
            else
            {
                MessageBox.Show("Service ID Does Not Exist.");
            }
        }

        private void ClearBtn3_Click(object sender, EventArgs e)
        {
            GetServiceDetail();
            AutoNumber();
            CatCombox.ResetText();
            ServiceTxt.Clear();
            PriceTxt.Clear();
            StatusCmboBx.ResetText();
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMINDASHBOARD A1 = new ADMINDASHBOARD();
            A1.Show();
        }       

        private void PriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;             
            }
        }

        private void CatCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatCombox.BackColor = Color.White;
        }

        private void ServiceTxt_TextChanged(object sender, EventArgs e)
        {
            ServiceTxt.BackColor = Color.White;
        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {
            PriceTxt.BackColor = Color.White;
        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM add_service WHERE service_name LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            AutoNumber();

            CatCombox.ResetText();
            ServiceTxt.Clear();
            PriceTxt.Clear();
        }

        private void SearchTxt6_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt6.Text);
        }

        private void CatCombox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ServiceTxt.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ServiceTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                PriceTxt.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PriceTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                StatusCmboBx.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StatusCmboBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PriceTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ServiceTxt.Focus();
            }
        }

        private void ServiceTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                CatCombox.Focus();
            }
        }

        private void StatusCmboBx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                PriceTxt.Focus();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CatCombox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            IdLbl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ServiceTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PriceTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            StatusCmboBx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void CatCombox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void StatusCmboBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }
    }
}
