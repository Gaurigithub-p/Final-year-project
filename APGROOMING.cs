using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Pet_salon
{
    public partial class APGROOMING : Form
    {
        SqlConnection conn;     
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlDataReader dr;
        double Val;
        string Id = "GA";

        public APGROOMING()
        {
            InitializeComponent();
        }
      
        void BookGroomingAppoinment()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM apt_grooming", conn);
            conn.Open();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Close();
        }
        
        private void AutoNumber()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(grooming_id) FROM [apt_grooming]", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            AptId.Text = Id + Val + i.ToString();
        }

        private void APGROOMING_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            BookGroomingAppoinment();
            AutoNumber();
            ABC();
            SearchData("");
            IdCmboBx4.ResetText();
            NameCmboBx2.ResetText();
            EmailIdCmboBx1.ResetText();          
            EmployeeComBx4.ResetText();
            AptStatusCmboBx5.ResetText();
        }

        public void ABC()
        {
            string querry = "SELECT * FROM pet_detail";
            SqlCommand cmd1 = new SqlCommand(querry, conn);
            conn.Open();
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                NameCmboBx2.Items.Add(dr["pet_name"]);
            }
            conn.Close();

            EmailIdCmboBx1.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT emp_name FROM employee_detail";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeComBx4.Items.Add(dr["emp_name"].ToString());
            }
            conn.Close();
        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            
            if (IdCmboBx4.Text == "")
            {
                IdCmboBx4.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Pet Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdCmboBx4.Focus();
                return;
            }

            if (NameCmboBx2.Text == "")
            {
                NameCmboBx2.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Pet Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameCmboBx2.Focus();
                return;
            }

            if (EmailIdCmboBx1.Text == "")
            {
                EmailIdCmboBx1.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Email Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailIdCmboBx1.Focus();
                return;
            }
            if (DateTime.Today > DateDTP1.Value)
            {
                MessageBox.Show("Selected Date is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DateDTP1.Value = DateTime.Today;
            }

            if (DateDTP1.Text == "")
            {
                DateDTP1.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Appoinment Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DateDTP1.Focus();
                return;
            }

            if (TimeDTP2.Text == "")
            {
                TimeDTP2.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Appoinment Time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TimeDTP2.Focus();
                return;
            }

            if (AptStatusCmboBx5.Text == "")
            {
                AptStatusCmboBx5.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Appoinment Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AptStatusCmboBx5.Focus();
                return;
            }

            conn.Open();
            SqlCommand CommandToCheckCustomerId = new SqlCommand("SELECT grooming_id FROM apt_grooming WHERE grooming_id ='" + AptId.Text + "'", conn);
            string Gid = (string)CommandToCheckCustomerId.ExecuteScalar();
            conn.Close();

            if (Gid == AptId.Text)
            {
                MessageBox.Show("Grooming Appoinment Id Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string querry = "INSERT INTO apt_grooming (grooming_id,petid,pet_name,email_id,employee,date,time,status) values" +
               "(@grooming_id, @petid, @pet_name, @email_id, @employee, @date, @time, @status)";

                cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@grooming_id", AptId.Text);
                cmd.Parameters.AddWithValue("@petid", IdCmboBx4.Text);
                cmd.Parameters.AddWithValue("@pet_name", NameCmboBx2.Text);
                cmd.Parameters.AddWithValue("@email_id", EmailIdCmboBx1.Text);
                cmd.Parameters.AddWithValue("@employee", EmployeeComBx4.Text);
                cmd.Parameters.AddWithValue("@date", DateDTP1.Text);
                cmd.Parameters.AddWithValue("@time", TimeDTP2.Text);
                cmd.Parameters.AddWithValue("@status", AptStatusCmboBx5.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Grooming Appointment Booked Succesfuly.");

                BookGroomingAppoinment();
                AutoNumber();
                IdCmboBx4.ResetText();
                NameCmboBx2.ResetText();
                EmailIdCmboBx1.ResetText();
                EmployeeComBx4.ResetText();
                AptStatusCmboBx5.ResetText();
            }
        }        
        
        private void ClearBtn3_Click(object sender, EventArgs e)
        {
            BookGroomingAppoinment();
            AutoNumber();
            IdCmboBx4.ResetText();
            NameCmboBx2.ResetText();
            EmailIdCmboBx1.ResetText();
            EmployeeComBx4.ResetText();
            AptStatusCmboBx5.ResetText();
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            DASHBOARD D1 = new DASHBOARD();
            D1.Show();
        }

        private void IdCmboBx4_TextChanged(object sender, EventArgs e)
        {
            IdCmboBx4.BackColor = Color.White;
        }

        private void NameCmboBx2_TextChanged(object sender, EventArgs e)
        {
            EmployeeComBx4.BackColor = Color.White;
        }

        private void EmailIdCmboBx1_TextChanged(object sender, EventArgs e)
        {
            EmployeeComBx4.BackColor = Color.White;
        }

        private void AptStatusCmboBx5_TextChanged(object sender, EventArgs e)
        {
            AptStatusCmboBx5.BackColor = Color.White;
        }

        private void EmailIdCmboBx1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmailIdCmboBx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void NameCmboBx2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NameCmboBx2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void EmployeeComBx4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmployeeComBx4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void SearchTxt2_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt2.Text);
        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM apt_grooming WHERE date LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;

            AutoNumber();
            IdCmboBx4.ResetText();
            NameCmboBx2.ResetText();
            EmailIdCmboBx1.ResetText();
            EmployeeComBx4.ResetText();
            AptStatusCmboBx5.ResetText();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            AptId.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            IdCmboBx4.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            NameCmboBx2.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            EmailIdCmboBx1.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            EmployeeComBx4.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            DateDTP1.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            TimeDTP2.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            AptStatusCmboBx5.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();   
        }

        private void NameCmboBx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM pet_detail WHERE pet_name=@pet_name", conn);
                cmd.Parameters.AddWithValue("@pet_name", NameCmboBx2.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string pet_id = dr["pet_id"].ToString();
                    string email_id = dr["email_id"].ToString();

                    IdCmboBx4.Text = pet_id;
                    EmailIdCmboBx1.Text = email_id;
                }
                  dr.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void IdCmboBx4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AptStatusCmboBx5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void AptStatusCmboBx5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            string id = AptId.Text;
            bool idExists = false;

            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (row.Cells["grooming_id"].Value != null && row.Cells["grooming_id"].Value.ToString() == id)
                {
                    idExists = true;
                    // Check if any changes have been made
                    if (row.Cells["petid"].Value.ToString() == IdCmboBx4.Text &&
                        row.Cells["pet_name"].Value.ToString() == NameCmboBx2.Text &&
                        row.Cells["email_id"].Value.ToString() == EmailIdCmboBx1.Text &&
                        row.Cells["employee"].Value.ToString() == EmployeeComBx4.Text &&
                        row.Cells["date"].Value.ToString() == DateDTP1.Text &&
                        row.Cells["time"].Value.ToString() == TimeDTP2.Text &&
                        row.Cells["status"].Value.ToString() == AptStatusCmboBx5.Text)
                    {
                        MessageBox.Show("No changes were made to the grooming appointment.");
                        return;
                    }
                }
            }

            if (idExists)
            {
                if (IdCmboBx4.Text != "" && NameCmboBx2.Text != "" && EmailIdCmboBx1.Text != "" && EmployeeComBx4.Text != "" && AptStatusCmboBx5.Text != "")
                {
                    string querry = "UPDATE apt_grooming " +
                    "SET petid=@petid, pet_name=@pet_name, " + "email_id=@email_id, employee=@employee, " + "date=@date, time=@time, " + "status=@status WHERE grooming_id=@grooming_id";

                    cmd = new SqlCommand(querry, conn);
                    cmd.Parameters.AddWithValue("@grooming_id", AptId.Text);
                    cmd.Parameters.AddWithValue("@petid", IdCmboBx4.Text);
                    cmd.Parameters.AddWithValue("@pet_name", NameCmboBx2.Text);
                    cmd.Parameters.AddWithValue("@email_id", EmailIdCmboBx1.Text);
                    cmd.Parameters.AddWithValue("@employee", EmployeeComBx4.Text);
                    cmd.Parameters.AddWithValue("@date", DateDTP1.Text);
                    cmd.Parameters.AddWithValue("@time", TimeDTP2.Text);
                    cmd.Parameters.AddWithValue("@status", AptStatusCmboBx5.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Grooming Appointment Details Updated Successfully.");

                    BookGroomingAppoinment();
                    AutoNumber();
                    IdCmboBx4.ResetText();
                    NameCmboBx2.ResetText();
                    EmailIdCmboBx1.ResetText();
                    EmployeeComBx4.ResetText();
                    AptStatusCmboBx5.ResetText();
                }
                else
                {
                    MessageBox.Show("Please Enter Data To Update.");
                }
            }
            else
            {
                MessageBox.Show("Grooming Appointment ID Does Not Exist.");
            }
        }

        private void DateDTP1_ValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}
