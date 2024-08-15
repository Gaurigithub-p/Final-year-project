using Microsoft.SqlServer.Server;
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
using static System.Net.WebRequestMethods;

namespace Pet_salon
{
    public partial class APBOARDING : Form
    {
        SqlConnection conn;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlDataReader dr;

        public APBOARDING()
        {
            InitializeComponent();
        }
     /*   class Program
        {
            static void Main()
            {
                string connectionString = "Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True";
                string queryString = "SELECT * FROM apt_boarding WHERE is_available = 0";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Assuming there are fields named "start_time" and "end_time"
                        DateTime startDate = reader.GetDateTime(reader.GetOrdinal("start_date"));
                        DateTime endDate = reader.GetDateTime(reader.GetOrdinal("end_date"));
                        DateTime startTime = reader.GetDateTime(reader.GetOrdinal("start_time"));
                        DateTime endTime = reader.GetDateTime(reader.GetOrdinal("end_time"));

                        Console.WriteLine("Appointment not available: {0} - {1}", startTime, endTime);
                    }

                    reader.Close();
                }
            }
        }  */

        double val = 0;
        string ID = "BA";
       
        void GetAppoinmentDetail()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            adapter = new SqlDataAdapter("SELECT * FROM apt_boarding", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void AutoNumber()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(boarding_id) FROM [apt_boarding]",conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            BorAptIdLbl.Text = ID + val + i.ToString();
        }

        private void APBOARDING_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            GetAppoinmentDetail();
            AutoNumber();
            ABC();
            SearchData("");
            
            IdCmboBx4.ResetText();
            MailCmboBx1.ResetText();
            PetNameCmboBx2.ResetText();
            EmpCmboBx3.ResetText();            
            STDTP1.CustomFormat = "";
            STDTP1.Format = DateTimePickerFormat.Custom;
            ETDTP2.CustomFormat = "";
            ETDTP2.Format = DateTimePickerFormat.Custom;
            AptStatusCmboBx5.ResetText();
            PriceTxt1.ResetText();
        }

        public void ABC()
        {
            string querry = "SELECT * FROM pet_detail";
            SqlCommand cmd1 = new SqlCommand(querry, con);
            con.Open();
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                PetNameCmboBx2.Items.Add(dr["pet_name"]);
            }
            con.Close();

            MailCmboBx1.Items.Clear();
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
                EmpCmboBx3.Items.Add(dr["emp_name"].ToString());
            }
            conn.Close();
        }  

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            if (STDTP1.Value >= ETDTP2.Value)
            {
                MessageBox.Show("Please Select Valid Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (PetNameCmboBx2.Text == "")
            {
                PetNameCmboBx2.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Pet Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PetNameCmboBx2.Focus();
                return;
            }

            if (STDTP1.Text == "")
            {
                STDTP1.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Start Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                STDTP1.Focus();
                return;
            }

            if (ETDTP2.Text == "")
            {
                ETDTP2.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select End Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ETDTP2.Focus();
                return;
            }

            if (STDTP3.Text == "")
            {
                STDTP3.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Start Time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                STDTP3.Focus();
                return;
            }

            if (ETDTP4.Text == "")
            {
                ETDTP4.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select End Time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ETDTP4.Focus();
                return;
            }

            if (AptStatusCmboBx5.Text == "")
            {
                AptStatusCmboBx5.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Appointment Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AptStatusCmboBx5.Focus();
                return;
            }

            conn.Open();
            SqlCommand CommandToCheckCustomerId = new SqlCommand("SELECT boarding_id FROM apt_boarding WHERE boarding_id ='" + BorAptIdLbl.Text + "'", conn);
            string BAId = (string)CommandToCheckCustomerId.ExecuteScalar();
            conn.Close();

            if (BAId == BorAptIdLbl.Text)
            {
                MessageBox.Show("Boarding Appointment Id Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string querry = "INSERT INTO apt_boarding (boarding_id, petid, email, pet_name, employee, start_date, end_date, start_time, end_time, status, price) values" +
                    "(@boarding_id, @petid, @email, @pet_name, @employee, @start_date, @end_date, @start_time, @end_time, @status, @price)";

                cmd = new SqlCommand(querry,conn);               
                cmd.Parameters.AddWithValue("@boarding_id", BorAptIdLbl.Text);
                cmd.Parameters.AddWithValue("@petid", IdCmboBx4.Text);
                cmd.Parameters.AddWithValue("@email", MailCmboBx1.Text);
                cmd.Parameters.AddWithValue("@pet_name", PetNameCmboBx2.Text);
                cmd.Parameters.AddWithValue("@employee", EmpCmboBx3.Text);
                cmd.Parameters.AddWithValue("@start_date", STDTP1.Text);
                cmd.Parameters.AddWithValue("@end_date", ETDTP2.Text);
                cmd.Parameters.AddWithValue("@start_time", STDTP3.Text);
                cmd.Parameters.AddWithValue("@end_time", ETDTP4.Text);
                cmd.Parameters.AddWithValue("@status", AptStatusCmboBx5.Text);
                cmd.Parameters.AddWithValue("@price", PriceTxt1.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Boarding Appointment Booked SuccesfuLly.");

                GetAppoinmentDetail();
                IdCmboBx4.ResetText();
                MailCmboBx1.ResetText();
                PetNameCmboBx2.ResetText();
                EmpCmboBx3.ResetText();
                STDTP1.CustomFormat = "";
                STDTP1.Format = DateTimePickerFormat.Custom;
                ETDTP2.CustomFormat = "";
                ETDTP2.Format = DateTimePickerFormat.Custom;
                AptStatusCmboBx5.ResetText();
                PriceTxt1.ResetText();
                AutoNumber();
                ABC();
            }
        }
        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            string id = BorAptIdLbl.Text;
            bool idExists = false;

            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (row.Cells["boarding_id"].Value != null && row.Cells["boardnig_id"].Value.ToString() == id)
                {
                    idExists = true;
                }
            }

            if (idExists)
            {
                if (MailCmboBx1.Text != "" && PetNameCmboBx2.Text != "" && EmpCmboBx3.Text != "" && STDTP1.Text != "" && ETDTP2.Text != "" && AptStatusCmboBx5.Text != "")
                {
                    string querry = "UPDATE apt_boarding " +
                   "SET petid=@petid, pet_name=@pet_name, " + "email=@email, pet_name=@pet_name, " + "employee=@employee, start_date=@start_date, " + "end_date=@end_date, start_time=@start_time, " + "end_time=@end_time, status=@status WHERE boarding_id=@boarding_id";

                    cmd = new SqlCommand(querry, conn);
                    cmd.Parameters.AddWithValue("@boarding_id", BorAptIdLbl.Text);
                    cmd.Parameters.AddWithValue("@petid", IdCmboBx4.Text);
                    cmd.Parameters.AddWithValue("@email", MailCmboBx1.Text);
                    cmd.Parameters.AddWithValue("@pet_name", PetNameCmboBx2.Text);
                    cmd.Parameters.AddWithValue("@employee", EmpCmboBx3.Text);
                    cmd.Parameters.AddWithValue("@start_date", STDTP1.Text);
                    cmd.Parameters.AddWithValue("@end_date", ETDTP2.Text);
                    cmd.Parameters.AddWithValue("@start_time", STDTP3.Text);
                    cmd.Parameters.AddWithValue("@end_time", ETDTP4.Text);
                    cmd.Parameters.AddWithValue("@status", AptStatusCmboBx5.Text);
                    cmd.Parameters.AddWithValue("@price", PriceTxt1.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Boarding Appointment Details Updated Succesfuly.");

                    GetAppoinmentDetail();
                    IdCmboBx4.ResetText();
                    MailCmboBx1.ResetText();
                    PetNameCmboBx2.ResetText();
                    EmpCmboBx3.ResetText();
                    STDTP1.CustomFormat = "";
                    STDTP1.Format = DateTimePickerFormat.Custom;
                    ETDTP2.CustomFormat = "";
                    ETDTP2.Format = DateTimePickerFormat.Custom;
                    AptStatusCmboBx5.ResetText();
                    PriceTxt1.ResetText();
                    AutoNumber();
                }
                else
                {
                    MessageBox.Show("Please Enter Data To Update.");
                }
            }
            else
            {
                MessageBox.Show("Boarding Appointment ID Does Not Exist.");
            }
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            DASHBOARD d1 = new DASHBOARD();
            d1.Show();
        }

        private void PetNameCmboBx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM pet_detail WHERE pet_name=@pet_name", con);
            cmd.Parameters.AddWithValue("@pet_name", PetNameCmboBx2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string pet_id = dr["pet_id"].ToString();
                string email_id = dr["email_id"].ToString();

                IdCmboBx4.Text = pet_id;
                MailCmboBx1.Text = email_id;
            }
            con.Close();

            PetNameCmboBx2.Text = PetNameCmboBx2.GetItemText(PetNameCmboBx2.SelectedItem);
        }

        private void MailCmboBx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailCmboBx1.Text = PetNameCmboBx2.GetItemText(PetNameCmboBx2.SelectedItem);
        }

        private void EmpCmboBx3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpCmboBx3.Text = PetNameCmboBx2.GetItemText(PetNameCmboBx2.SelectedItem);
        }

        private void PetNameCmboBx2_TextChanged(object sender, EventArgs e)
        {
            PetNameCmboBx2.BackColor = Color.White;
        }

        private void EmpCmboBx3_TextChanged(object sender, EventArgs e)
        {
            EmpCmboBx3.BackColor = Color.White;
        }

        private void AptStatusCmboBx5_TextChanged(object sender, EventArgs e)
        {
            AptStatusCmboBx5.BackColor = Color.White;
        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM apt_boarding WHERE start_date LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;

            AutoNumber();
            IdCmboBx4.ResetText();
            MailCmboBx1.ResetText();
            PetNameCmboBx2.ResetText();
            EmpCmboBx3.ResetText();
            STDTP1.CustomFormat = "";
            STDTP1.Format = DateTimePickerFormat.Custom;
            ETDTP2.CustomFormat = "";
            ETDTP2.Format = DateTimePickerFormat.Custom;
            AptStatusCmboBx5.ResetText();
            PriceTxt1.ResetText();
        }

        private void SearchTxt6_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt6.Text);
        }

        private void IdCmboBx4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void EmpCmboBx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void MailCmboBx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void AptStatusCmboBx5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            BorAptIdLbl.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            IdCmboBx4.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            PetNameCmboBx2.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            MailCmboBx1.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            EmpCmboBx3.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            //STDTP1.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            //ETDTP2.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            //STDTP3.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            //ETDTP4.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
            AptStatusCmboBx5.Text = DataGridView1.CurrentRow.Cells[9].Value.ToString();
            PriceTxt1.Text = DataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void IdCmboBx4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MailCmboBx1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmpCmboBx3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PetNameCmboBx2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AptStatusCmboBx5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PriceTxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void STDTP1_ValueChanged(object sender, EventArgs e)
        {
           /* if (STDTP1.Value >= ETDTP2.Value)
            {
                MessageBox.Show("Please Select Valid Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    */

            if (DateTime.Today >= STDTP1.Value)
            {
                MessageBox.Show("Selected Date is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                STDTP1.Value = DateTime.Today;
            }
        }

        private void ETDTP2_ValueChanged(object sender, EventArgs e)
        {
           /* if (STDTP1.Value >= ETDTP2.Value)
            {
                MessageBox.Show("Please Select Valid Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           */
            if (DateTime.Today >= ETDTP2.Value)
            {
                MessageBox.Show("Selected Date is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ETDTP2.Value = DateTime.Today;
            }
        }

        private void ClearBtn3_Click_1(object sender, EventArgs e)
        {           
            GetAppoinmentDetail();
            IdCmboBx4.ResetText();
            MailCmboBx1.ResetText();
            PetNameCmboBx2.ResetText();
            EmpCmboBx3.ResetText();
            STDTP1.CustomFormat = "";
            STDTP1.Format = DateTimePickerFormat.Custom;
            ETDTP2.CustomFormat = "";
            ETDTP2.Format = DateTimePickerFormat.Custom;
            AptStatusCmboBx5.ResetText();
            PriceTxt1.ResetText();
            AutoNumber();           
        }

        private void PriceTxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,Invalid Price.");
            }
        }
    }
}
