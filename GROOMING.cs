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
using System.Text.RegularExpressions;

namespace Pet_salon
{
    
    public partial class GROOMING : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public GROOMING()
        {
            InitializeComponent();
        }

        string Price1;
        string Price2;
        double val;
        string ID = "S";
        

        private void AutoNumber()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(service_id) FROM [grooming_service]", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            GroIdLbl.Text = ID + val + i.ToString();
        }

        void GetServiceDetail()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM grooming_service", conn);
            conn.Open();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void GROOMING_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            GetServiceDetail();
            AutoNumber();
            CB();
            CB1();
            SearchData("");
            EmailIdCmboBx1.ResetText();
            PetNameCmboBx2.ResetText();
            OsClb1.ResetText();
            comboBox1.ResetText();
        }

        public void CB()
        {
            EmailIdCmboBx1.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select email_id from customer_detail";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmailIdCmboBx1.Items.Add(dr["email_id"].ToString());
            }
            conn.Close();
        }

        public void CB1()
        {
            PetNameCmboBx2.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select pet_name from pet_detail";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PetNameCmboBx2.Items.Add(dr["pet_name"].ToString());
            }
            conn.Close();
        }
        private void SaveBtn1_Click(object sender, EventArgs e)
        {

            if (EmailIdCmboBx1.Text == "")
            {
                EmailIdCmboBx1.BackColor = Color.IndianRed;
                MessageBox.Show("Please selsect Email Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailIdCmboBx1.Focus();
                return;
            }

            if (PetNameCmboBx2.Text == "")
            {
                PetNameCmboBx2.BackColor = Color.IndianRed;
                MessageBox.Show("Please select Pet name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PetNameCmboBx2.Focus();
                return;
            }

            /* if (GroupBox1.Text == "")
             {
                 GroupBox1.BackColor = Color.IndianRed;
                 MessageBox.Show("Please select data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 GroupBox1.Focus();
                 return;
             }


             if (GroupBox2.Text == "")
             {
                 GroupBox2.BackColor = Color.IndianRed;
                 MessageBox.Show("Select.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 GroupBox2.Focus();
                 return;
             }*/


            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");

            string querry = "INSERT INTO grooming_service (service_id,email_id,pet_name,spa,other_services,haircut,massage) values" +
                "(@service_id,@email_id,@pet_name,@spa,@other_services,@haircut,@massage)";

            cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@service_id", GroIdLbl.Text);
            cmd.Parameters.AddWithValue("@email_id", EmailIdCmboBx1.Text);
            cmd.Parameters.AddWithValue("@pet_name", PetNameCmboBx2.ToString());
            cmd.Parameters.AddWithValue("@spa", Price1.ToString());
            cmd.Parameters.AddWithValue("@other_services", OsClb1.ToString());
            cmd.Parameters.AddWithValue("@haircut", Price2.ToString());
            cmd.Parameters.AddWithValue("@massage", comboBox1.ToString());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Grooming Services Inserted Succesfuly.");

                GetServiceDetail();
                EmailIdCmboBx1.ResetText();
                PetNameCmboBx2.ResetText();
                OsClb1.ResetText();
                comboBox1.ResetText();
                AutoNumber();


        }

        private void ScRbtn1_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "800";
        }

        private void LcRbtn2_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "800";
        }

        private void ScRbtn3_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "950";
        }

        private void LcRbtn4_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "1000";
        }

        private void ScRbtn5_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "1100";
        }

        private void LcRbtn6_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "1200";
        }

        private void ScRbtn7_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "1800";
        }

        private void LcRbtn8_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "2000";
        }

        private void MpRbtn9_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "1300";
        }

        private void ShRbtn10_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "2500";
        }

        private void PcRbtn11_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "1150";
        }

        private void ScRbtn12_CheckedChanged(object sender, EventArgs e)
        {
            Price1 = "850";
        }

        private void ScRbtn13_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "900";
        }

        private void LcRbtn14_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "900";
        }

        private void ScRbtn15_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "1100";
        }

        private void LcRbtn16_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "1200";
        }

        private void ScRbtn17_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "1200";
        }

        private void LcRbtn18_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "1400";
        }

        private void ScRbtn19_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "2000";
        }

        private void LcRbtn20_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "2500";
        }

        private void MpRbtn21_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "1300";
        }

        private void ShRbtn22_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "2500";
        }

        private void PcRbtn23_CheckedChanged(object sender, EventArgs e)
        {
            Price2 = "1150";
        }

       

        

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            GroIdLbl.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            EmailIdCmboBx1.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            PetNameCmboBx2.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            Price1 = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            OsClb1.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            Price2 = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void BackBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            DASHBOARD d1 = new DASHBOARD();
            d1.Show();
        }

        private void EmailIdCmboBx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmailIdCmboBx1.BackColor = Color.White;
        }

        private void PetNameCmboBx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PetNameCmboBx2.BackColor = Color.White;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
           EmailIdCmboBx1.ResetText();
           PetNameCmboBx2.ResetText();
           OsClb1.ResetText();
           comboBox1.ResetText();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (EmailIdCmboBx1.Text != "" && PetNameCmboBx2.Text != "" && Price1 != "" && OsClb1.Text != "" && Price2 != "" && comboBox1.Text != "")
            {
                string querry = "UPDATE grooming_service " +
                "SET  email_id=@email_id, pet_name=@pet_name, spa=@spa, other_services=@other_services, haircut=@haircut, massage=@massage WHERE service_id=@service_id";

                cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@service_id", GroIdLbl.Text);
                cmd.Parameters.AddWithValue("@email_id", EmailIdCmboBx1.Text);
                cmd.Parameters.AddWithValue("@pet_name", PetNameCmboBx2.Text);
                cmd.Parameters.AddWithValue("@spa", Price1);
                cmd.Parameters.AddWithValue("@other_services", OsClb1.Text);
                cmd.Parameters.AddWithValue("@haircut", Price2);
                cmd.Parameters.AddWithValue("@massage", comboBox1.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Service Details Updated Succesfuly.");

                GetServiceDetail();
                EmailIdCmboBx1.ResetText();
                PetNameCmboBx2.ResetText();
                OsClb1.ResetText();
                comboBox1.ResetText();
                AutoNumber();

            }
            else
            {
                MessageBox.Show("Please Enter Data To Update.");
            }
  
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
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

        private void PetNameCmboBx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void SearchTxt6_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt6.Text);
        }

        private void SearchLbl9_Click(object sender, EventArgs e)
        {

        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM grooming_service WHERE email_id LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
            AutoNumber();
            EmailIdCmboBx1.ResetText();
            PetNameCmboBx2.ResetText();
            OsClb1.ResetText();
            comboBox1.ResetText();

        }
    }
}
