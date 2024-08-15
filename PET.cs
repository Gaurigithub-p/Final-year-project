using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_salon
{
    public partial class PET : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        double Val;
        string Id = "P";

        public PET()
        {
            InitializeComponent();
            Fill_combo();
        }

        string dbConnectionString  = "Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True";
        
        void Fill_combo()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            try 
            {
                conn.Open();
                string querry = "SELECT email_id FROM customer_detail";
                SqlCommand cmd = new SqlCommand(querry,conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read()) 
                {
                    string email_id = dr.GetString(0);  
                    MailCmboBx1.Items.Add(email_id);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }              
        }

        private void AutoNumber()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(pet_id) FROM [pet_detail]", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            PetidLbl.Text = Id + Val + i.ToString();
        }

        void GetPetDetail()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            adapter = new SqlDataAdapter("SELECT * FROM pet_detail", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void PET_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            GetPetDetail();
            AutoNumber();
            SearchData("");

            MailCmboBx1.ResetText();
            PetNameTxt1.Clear();
            TypeCmboBx2.ResetText();
            AgeTxt2.Clear();
            SizeCmboBx3.ResetText();
            BreedCmboBx4.ResetText();
            FrndCmboBx5.ResetText();
            GenderCmboBx.ResetText();
            TempCmboBx6.ResetText();
        }

        public void CB()
        {
            MailCmboBx1.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT email_id FROM customer_detail";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                MailCmboBx1.Items.Add(dr["email_id"].ToString());
            }
            conn.Close();
        }
      
        private void SaveBtn1_Click(object sender, EventArgs e)
        {
           if (MailCmboBx1.Text == "")
            {
                MailCmboBx1.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Email Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MailCmboBx1.Focus();
                return;
            }

            if (PetNameTxt1.Text == "")
            {
                PetNameTxt1.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Pet Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PetNameTxt1.Focus();
                return;
            }

            if (TypeCmboBx2.Text == "")
            {
                TypeCmboBx2.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Pet Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TypeCmboBx2.Focus();
                return;
            }

            if (AgeTxt2.Text == "")
            {
                AgeTxt2.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Pet's Age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AgeTxt2.Focus();
                return;
            }

            if (SizeCmboBx3.Text == "")
            {
                SizeCmboBx3.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Pet's Size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SizeCmboBx3.Focus();
                return;
            }

            if (BreedCmboBx4.Text == "")
            {
                BreedCmboBx4.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Breed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BreedCmboBx4.Focus();
                return;
            }

            if (DTP.Text == "")
            {
                DTP.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Valid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP.Focus();
                return;
            }

            if (FrndCmboBx5.Text == "")
            {
                FrndCmboBx5.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Pet's Behaviour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrndCmboBx5.Focus();
                return;
            }

            if (GenderCmboBx.Text == "")
            {

                MessageBox.Show("Please Select Pet's Gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TempCmboBx6.Text == "")
            {
                TempCmboBx6.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Pet's Nature.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TempCmboBx6.Focus();
                return;
            }

            conn.Open();
            SqlCommand CommandToCheckPetId = new SqlCommand("SELECT pet_id FROM pet_detail WHERE pet_id ='" + PetidLbl.Text + "'", conn);
            string Pid = (string)CommandToCheckPetId.ExecuteScalar();
            conn.Close();

            if (Pid == PetidLbl.Text)
            {
                MessageBox.Show("Pet Id Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string querry = "INSERT INTO pet_detail(email_id,pet_id,pet_name,type,age,size,breed,dob,friendly,gender,temp) values" +
               "(@email_id,@pet_id,@pet_name,@type,@age,@size,@breed,@dob,@friendly,@gender,@temp)";

                cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@email_id", MailCmboBx1.Text);
                cmd.Parameters.AddWithValue("@pet_id", PetidLbl.Text);
                cmd.Parameters.AddWithValue("@pet_name", PetNameTxt1.Text);
                cmd.Parameters.AddWithValue("@type", TypeCmboBx2.Text);
                cmd.Parameters.AddWithValue("@age", AgeTxt2.Text);
                cmd.Parameters.AddWithValue("@size", SizeCmboBx3.Text);
                cmd.Parameters.AddWithValue("@breed", BreedCmboBx4.Text);
                cmd.Parameters.AddWithValue("@dob", DTP.Value.Date);
                cmd.Parameters.AddWithValue("@friendly", FrndCmboBx5.Text);
                cmd.Parameters.AddWithValue("@gender", GenderCmboBx.Text);
                cmd.Parameters.AddWithValue("@temp", TempCmboBx6.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Pet Details Saved Succesfully.");

                GetPetDetail();
                MailCmboBx1.ResetText();
                PetNameTxt1.Clear();
                TypeCmboBx2.ResetText();
                AgeTxt2.Clear();
                SizeCmboBx3.ResetText();
                BreedCmboBx4.ResetText();
                FrndCmboBx5.ResetText();
                GenderCmboBx.ResetText();
                TempCmboBx6.ResetText();
                AutoNumber();
                CB();
            }
        }

        private void DTP_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today <= DTP.Value)
            {
                MessageBox.Show("Selected Date is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP.Value = DateTime.Today;
            }
        }

        private void PetNameTxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,Invalid Name.");
            }
        }

        private void AgeTxt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,Invalid Age.");
            }
        }

        private void MailCmboBx1_TextChanged(object sender, EventArgs e)
        {
            MailCmboBx1.BackColor = Color.White;
        }

        private void PetNameTxt1_TextChanged(object sender, EventArgs e)
        {
            PetNameTxt1.BackColor = Color.White;
        }

        private void TypeCmboBx2_TextChanged(object sender, EventArgs e)
        {
            TypeCmboBx2.BackColor = Color.White;
        }

        private void AgeTxt2_TextChanged(object sender, EventArgs e)
        {
            AgeTxt2.BackColor = Color.White;
        }

        private void SizeCmboBx3_TextChanged(object sender, EventArgs e)
        {
            SizeCmboBx3.BackColor = Color.White;
        }

        private void BreedCmboBx4_TextChanged(object sender, EventArgs e)
        {
            BreedCmboBx4.BackColor = Color.White;
        }

        private void FrndCmboBx5_TextChanged(object sender, EventArgs e)
        {
            FrndCmboBx5.BackColor = Color.White;
        }

        private void TempCmboBx6_TextChanged(object sender, EventArgs e)
        {
            TempCmboBx6.BackColor = Color.White;
        }

        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            string id = PetidLbl.Text;
            bool idExists = false;

            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (row.Cells["pet_id"].Value != null && row.Cells["pet_id"].Value.ToString() == id)
                {
                    idExists = true;
                }
            }

            if (idExists)
            {
                if (MailCmboBx1.Text != "" && PetNameTxt1.Text != "" && TypeCmboBx2.Text != "" && AgeTxt2.Text != "" && SizeCmboBx3.Text != "" && BreedCmboBx4.Text != "" && DTP.Text != "" && FrndCmboBx5.Text != "" && TempCmboBx6.Text != "")
                {
                    string querry = "UPDATE pet_detail " +
                   "SET email_id=@email_id, pet_name=@pet_name, type=@type, age=@age, size=@size, breed=@breed, dob=@dob, friendly=@friendly, gender=@gender, temp=@temp WHERE pet_id=@pet_id";

                    cmd = new SqlCommand(querry, conn);
                    cmd.Parameters.AddWithValue("@email_id", MailCmboBx1.Text);
                    cmd.Parameters.AddWithValue("@pet_id", PetidLbl.Text);
                    cmd.Parameters.AddWithValue("@pet_name", PetNameTxt1.Text);
                    cmd.Parameters.AddWithValue("@type", TypeCmboBx2.Text);
                    cmd.Parameters.AddWithValue("@age", AgeTxt2.Text);
                    cmd.Parameters.AddWithValue("@size", SizeCmboBx3.Text);
                    cmd.Parameters.AddWithValue("@breed", BreedCmboBx4.Text);
                    cmd.Parameters.AddWithValue("@dob", DTP.Text);
                    cmd.Parameters.AddWithValue("@friendly", FrndCmboBx5.Text);
                    cmd.Parameters.AddWithValue("@gender", GenderCmboBx.Text);
                    cmd.Parameters.AddWithValue("@temp", TempCmboBx6.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Pet Details Updated Succesfuly.");

                    GetPetDetail();
                    MailCmboBx1.ResetText();
                    PetNameTxt1.Clear();
                    TypeCmboBx2.ResetText();
                    AgeTxt2.Clear();
                    SizeCmboBx3.ResetText();
                    BreedCmboBx4.ResetText();
                    FrndCmboBx5.ResetText();
                    GenderCmboBx.ResetText();
                    TempCmboBx6.ResetText();
                    AutoNumber();
                    CB();
                }
                else
                {
                    MessageBox.Show("Please Enter Data To Update.");
                }
            }
            else
            {
                MessageBox.Show("Pet Id Does Not Exist.");
            }         
        }       

        private void ClearBtn3_Click(object sender, EventArgs e)
        {
            GetPetDetail();
            MailCmboBx1.ResetText();
            PetNameTxt1.Clear();
            TypeCmboBx2.ResetText();
            AgeTxt2.Clear();
            SizeCmboBx3.ResetText();
            BreedCmboBx4.ResetText();
            FrndCmboBx5.ResetText();
            TempCmboBx6.ResetText();
            AutoNumber();
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            DASHBOARD d1 = new DASHBOARD();
            d1.Show();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MailCmboBx1.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            PetidLbl.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            PetNameTxt1.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            TypeCmboBx2.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            AgeTxt2.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            SizeCmboBx3.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            BreedCmboBx4.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            DTP.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            FrndCmboBx5.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
            GenderCmboBx.Text = DataGridView1.CurrentRow.Cells[9].Value.ToString();
            TempCmboBx6.Text = DataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void SearchTxt6_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt3.Text);
        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM pet_detail WHERE email_id LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;

            AutoNumber();
            MailCmboBx1.ResetText();
            PetNameTxt1.Clear();
            TypeCmboBx2.ResetText();
            AgeTxt2.Clear();
            SizeCmboBx3.ResetText();
            BreedCmboBx4.ResetText();
            FrndCmboBx5.ResetText();
            GenderCmboBx.ResetText();
            TempCmboBx6.ResetText();
            CB();
        }


        private void MailCmboBx1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void TypeCmboBx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void PET_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void SizeCmboBx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void BreedCmboBx4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void FrndCmboBx5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void TempCmboBx6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void SearchTxt3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PetNameTxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                TypeCmboBx2.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgeTxt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SizeCmboBx3.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SearchTxt3_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void MailCmboBx1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                PetNameTxt1.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TypeCmboBx2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                AgeTxt2.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SizeCmboBx3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                BreedCmboBx4.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BreedCmboBx4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                DTP.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DTP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                FrndCmboBx5.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrndCmboBx5_KeyDown(object sender, KeyEventArgs e)
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

        private void GenderCmboBx_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        } 

        private void TempCmboBx6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SearchTxt3.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PetNameTxt1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                MailCmboBx1.Focus();
            }
        }

        private void TypeCmboBx2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                PetNameTxt1.Focus();
            }
        }

        private void AgeTxt2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                TypeCmboBx2.Focus();
            }
        }

        private void SizeCmboBx3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                AgeTxt2.Focus();
            }
        }

        private void BreedCmboBx4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                SizeCmboBx3.Focus();
            }
        }

        private void DTP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                BreedCmboBx4.Focus();
            }
        }

        private void FrndCmboBx5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                DTP.Focus();
            }
        }

        private void TempCmboBx6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                GenderCmboBx.Focus();
            }
        }

        private void MailCmboBx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TypeCmboBx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BreedCmboBx4.Items.Clear();
            SizeCmboBx3.Items.Clear();

            // Get the selected item in the first combobox
            string selectedItem = TypeCmboBx2.SelectedItem.ToString();
           

            // Add the relevant items to the second combobox based on the selected item in the first combobox
            if (selectedItem == "")
            {
                BreedCmboBx4.Items.Add("");
            }
            else if (selectedItem == "Dog")
            {
                BreedCmboBx4.Items.Add("Labrador");
                BreedCmboBx4.Items.Add("Bulldogs");
                BreedCmboBx4.Items.Add("Golden Retriver");
                BreedCmboBx4.Items.Add("German Shepered");
                BreedCmboBx4.Items.Add("Poodles");
                BreedCmboBx4.Items.Add("Beagles");
                BreedCmboBx4.Items.Add("Rottweilers");
                BreedCmboBx4.Items.Add("Others");

                SizeCmboBx3.Items.Add("Small (0-7 kgs)");
                SizeCmboBx3.Items.Add("Medium (7-15 kgs)");
                SizeCmboBx3.Items.Add("Large (15-35 kgs)");
                SizeCmboBx3.Items.Add("Extra Large (35+ kgs)");
            }
            else
            {
                BreedCmboBx4.Items.Add("Devon Rex");
                BreedCmboBx4.Items.Add("Abyssinian");
                BreedCmboBx4.Items.Add("Sphynx");
                BreedCmboBx4.Items.Add("Scottish Fold");
                BreedCmboBx4.Items.Add("American Shorthair");
                BreedCmboBx4.Items.Add("Maine Coon");
                BreedCmboBx4.Items.Add("Parsian");
                BreedCmboBx4.Items.Add("British Shorthair");
                BreedCmboBx4.Items.Add("Radgoll");
                BreedCmboBx4.Items.Add("Other");

                SizeCmboBx3.Items.Add("Small (0-3 kgs)");
                SizeCmboBx3.Items.Add("Medium (3-5 kgs)");
                SizeCmboBx3.Items.Add("Large (5-8 kgs)");
                SizeCmboBx3.Items.Add("Extra Large (8+ kgs)");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
