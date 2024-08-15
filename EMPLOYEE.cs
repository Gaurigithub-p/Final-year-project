using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace Pet_salon
{
    public partial class EMPLOYEE : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        double val = 0;
        string ID = "E";

        public EMPLOYEE()
        {
            InitializeComponent();
        }

        private void AutoNumber()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(emp_id) FROM [employee_detail]", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            EmpIdLbl1.Text = ID + val + i.ToString();
        }

        void GetEmployeeDetail()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM employee_detail", conn);
            conn.Open();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void EMPLOYEE_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            GetEmployeeDetail();
            AutoNumber();
            SearchData("");

            EmpNameTxt1.Clear();
            EmpSurnameTxt2.Clear();
            GenderCmboBx.ResetText();
            AgeTxt3.Clear();
            PhoneTxt4.Clear();
            MailTxt5.Clear();
            DateDTP.Value = DateTime.Today;
            AddressTxt6.Clear();
            SalaryTxt7.Clear();
        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            if (EmpNameTxt1.Text == "")
            {
                EmpNameTxt1.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmpNameTxt1.Focus();
                return;
            }

            if (EmpSurnameTxt2.Text == "")
            {
                EmpSurnameTxt2.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Surname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmpSurnameTxt2.Focus();
                return;
            }

            if (GenderCmboBx.Text == "")
            {

                MessageBox.Show("Please Select Gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateDTP.Text == "")
            {
                DateDTP.BackColor = Color.IndianRed;
                MessageBox.Show("Please Select Valid Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DateDTP.Focus();
                return;
            }

            if (AgeTxt3.Text == "")
            {
                AgeTxt3.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AgeTxt3.Focus();
                return;
            }

            if (PhoneTxt4.Text == "")
            {
                PhoneTxt4.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Phone no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneTxt4.Focus();
                return;
            }

            if (PhoneTxt4.Text.Length < 10)
            {
                PhoneTxt4.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Only 10 Digits.");
                PhoneTxt4.Focus();
                return;
            }

            if (MailTxt5.Text == "")
            {
                MailTxt5.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Email ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MailTxt5.Focus();
                return;
            }

            if (AddressTxt6.Text == "")
            {
                AddressTxt6.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddressTxt6.Focus();
                return;
            }

            if (SalaryTxt7.Text == "")
            {
                SalaryTxt7.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SalaryTxt7.Focus();
                return;
            }

            conn.Open();
            SqlCommand CommandToCheckEmployeeId = new SqlCommand("SELECT emp_id FROM employee_detail WHERE emp_id ='" + EmpIdLbl1.Text + "'", conn);
            string Eid = (string)CommandToCheckEmployeeId.ExecuteScalar();
            conn.Close();

            if (Eid == EmpIdLbl1.Text)
            {
                MessageBox.Show("Employee ID Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string querry = "INSERT INTO employee_detail(emp_id,emp_name,emp_surname,gender,date,age,phone_no,mail_id,address,salary) values" +
                "(@emp_id,@emp_name,@emp_surname,@gender,@date,@age,@phone_no,@mail_id,@address,@salary)";

                cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@emp_id", EmpIdLbl1.Text);
                cmd.Parameters.AddWithValue("@emp_name", EmpNameTxt1.Text);
                cmd.Parameters.AddWithValue("@emp_surname", EmpSurnameTxt2.Text);
                cmd.Parameters.AddWithValue("@gender", GenderCmboBx.Text);
                cmd.Parameters.AddWithValue("@date", DateDTP.Text);
                cmd.Parameters.AddWithValue("@age", AgeTxt3.Text);
                cmd.Parameters.AddWithValue("@phone_no", PhoneTxt4.Text);
                cmd.Parameters.AddWithValue("@mail_id", MailTxt5.Text);
                cmd.Parameters.AddWithValue("@address", AddressTxt6.Text);
                cmd.Parameters.AddWithValue("@salary", SalaryTxt7.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee Details Saved Succesfully.");

                GetEmployeeDetail();
                EmpNameTxt1.Clear();
                EmpSurnameTxt2.Clear();
                GenderCmboBx.ResetText();
                AgeTxt3.Clear();
                PhoneTxt4.Clear();
                MailTxt5.Clear();
                DateDTP.Value = DateTime.Today;                
                AddressTxt6.Clear();
                SalaryTxt7.Clear();
                AutoNumber();
            }
        }

        private void EmpNameTxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmpSurnameTxt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DateDTP_ValueChanged(object sender, EventArgs e)
        {
            if (DateDTP.Value > DateTime.Today)
            {
                MessageBox.Show("Selected date cannot be greater than today's date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DateDTP.Value = DateTime.Today;
            }
        }

        private void AgeTxt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,Invalid Age.");
            }
        }

        private void PhoneTxt4_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,Invalid Phone Number.");
            }
        }

        private void MailTxt5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void SalaryTxt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,Invalid Salary.");
            }
        }

        private void EmpNameTxt1_TextChanged(object sender, EventArgs e)
        {
            EmpNameTxt1.BackColor = Color.White;
        }

        private void EmpSurnameTxt2_TextChanged(object sender, EventArgs e)
        {
            EmpSurnameTxt2.BackColor = Color.White;
        }

        private void AgeTxt3_TextChanged(object sender, EventArgs e)
        {
            AgeTxt3.BackColor = Color.White;
        }

        private void PhoneTxt4_TextChanged(object sender, EventArgs e)
        {
            PhoneTxt4.BackColor = Color.White;
        }

        private void MailTxt5_TextChanged(object sender, EventArgs e)
        {
            MailTxt5.BackColor = Color.White;
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z)*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(MailTxt5.Text, pattern))
            {
                ErrorProvider1.Clear();
            }
            else
            {
                ErrorProvider1.SetError(this.MailTxt5, "Invalid Email ID.");
                return;
            }
        }

        private void SalaryTxt7_TextChanged(object sender, EventArgs e)
        {
            SalaryTxt7.BackColor = Color.White;
        }

        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            string id = EmpIdLbl1.Text;
            bool idExists = false;

            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (row.Cells["emp_id"].Value != null && row.Cells["emp_id"].Value.ToString() == id)
                {
                    idExists = true;
                }
            }

            if (idExists)
            {
                if (EmpNameTxt1.Text != "" && EmpSurnameTxt2.Text != "" && DateDTP.Text != "" && AgeTxt3.Text != "" && PhoneTxt4.Text != "" && MailTxt5.Text != "" && AddressTxt6.Text != "" && SalaryTxt7.Text != "")
                {
                    string querry = "UPDATE employee_detail " +
                    "SET emp_name=@emp_name,emp_surname=@emp_surname,gender=@gender,date=@date,age=@age,phone_no=@phone_no,mail_id=@mail_id,address=@address,salary=@salary WHERE emp_id = @emp_id";

                    cmd = new SqlCommand(querry, conn);
                    cmd.Parameters.AddWithValue("@emp_id", EmpIdLbl1.Text);
                    cmd.Parameters.AddWithValue("@emp_name", EmpNameTxt1.Text);
                    cmd.Parameters.AddWithValue("@emp_surname", EmpSurnameTxt2.Text);
                    cmd.Parameters.AddWithValue("@gender", GenderCmboBx.Text);
                    cmd.Parameters.AddWithValue("@date", DateDTP.Text);
                    cmd.Parameters.AddWithValue("@age", AgeTxt3.Text);
                    cmd.Parameters.AddWithValue("@phone_no", PhoneTxt4.Text);
                    cmd.Parameters.AddWithValue("@mail_id", MailTxt5.Text);
                    cmd.Parameters.AddWithValue("@address", AddressTxt6.Text);
                    cmd.Parameters.AddWithValue("@salary", SalaryTxt7.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Employee Details Updated Succesfuly.");

                    GetEmployeeDetail();
                    EmpNameTxt1.Clear();
                    EmpSurnameTxt2.Clear();
                    GenderCmboBx.ResetText();
                    AgeTxt3.Clear();
                    PhoneTxt4.Clear();
                    MailTxt5.Clear();
                    AddressTxt6.Clear();
                    DateDTP.Value = DateTime.Today;
                    SalaryTxt7.Clear();
                    AutoNumber();
                }
                else
                {
                    MessageBox.Show("Please Enter Data To Update.");
                }
            }
            else
            {
                MessageBox.Show("Employee ID Does Not Exist.");
            }         
        }        

        private void ClearBtn3_Click(object sender, EventArgs e)
        {
            GetEmployeeDetail();
            EmpNameTxt1.Clear();
            EmpSurnameTxt2.Clear();
            GenderCmboBx.ResetText();
            AgeTxt3.Clear();
            PhoneTxt4.Clear();
            MailTxt5.Clear();
            AddressTxt6.Clear();
            SalaryTxt7.Clear();
            DateDTP.Value = DateTime.Today;
            AutoNumber();
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMINDASHBOARD D1 = new ADMINDASHBOARD();
            D1.Show();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            EmpIdLbl1.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            EmpNameTxt1.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            EmpSurnameTxt2.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            GenderCmboBx.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            DateDTP.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            AgeTxt3.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            PhoneTxt4.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            MailTxt5.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            AddressTxt6.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
            SalaryTxt7.Text = DataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void SearchTxt6_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt6.Text);
        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM employee_detail WHERE mail_id LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
            AutoNumber();
            EmpNameTxt1.Clear();
            EmpSurnameTxt2.Clear();
            GenderCmboBx.ResetText();
            AgeTxt3.Clear();
            PhoneTxt4.Clear();
            MailTxt5.Clear();
            AddressTxt6.Clear();
            DateDTP.Value = DateTime.Today;
            //   DateDTP.Value = null;
            SalaryTxt7.Clear();
        }

        private void EmpNameTxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                EmpSurnameTxt2.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmpNameTxt1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void EmpSurnameTxt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                AgeTxt3.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgeTxt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                PhoneTxt4.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PhoneTxt4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                MailTxt5.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MailTxt5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                AddressTxt6.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddressTxt6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SalaryTxt7.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalaryTxt7_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void EmpSurnameTxt2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                EmpNameTxt1.Focus();
            }
        }

        private void AgeTxt3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                EmpSurnameTxt2.Focus();
            }
        }

        private void PhoneTxt4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                AgeTxt3.Focus();
            }
        }

        private void MailTxt5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                PhoneTxt4.Focus();
            }
        }

        private void AddressTxt6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                MailTxt5.Focus();
            }
        }

        private void SalaryTxt7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                AddressTxt6.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
