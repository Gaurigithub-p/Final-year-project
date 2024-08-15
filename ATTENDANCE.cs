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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Pet_salon
{
    public partial class ATTENDANCE : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlDataReader dr;      

        public ATTENDANCE()
        {
            InitializeComponent();
            Fill_combo();
        }
        string dbConnectionString = "Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True";

        void GetAttendanceDetail()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM emp_attendance", conn);
            conn.Open();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ATTENDANCE_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
           
            comboBox1.ResetText();
            EmpNameComoBx2.ResetText();
            GetAttendanceDetail();
         //   Fill_combo();
            SearchData("");
        }

        void Fill_combo()
        {
            SqlConnection conn = new SqlConnection(dbConnectionString);
            try
            {
                conn.Open();
                string querry = "SELECT emp_name FROM employee_detail";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string emp_name = dr.GetString(0);
                    EmpNameComoBx2.Items.Add(emp_name);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CB()
        {
            EmpNameComoBx2.Items.Clear();
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
                EmpNameComoBx2.Items.Add(dr["emp_name"].ToString());
            }
            conn.Close();
        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            if (EmpNameComoBx2.Text == "")
            {
                EmpNameComoBx2.BackColor = Color.IndianRed;
                MessageBox.Show("Please select Employee name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmpNameComoBx2.Focus();
                return;
            }

            if (comboBox1.Text == "")
            {
                comboBox1.BackColor = Color.IndianRed;
                MessageBox.Show("Please select Attendance Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
                return;
            }

        //    conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            
            string querry = "SELECT COUNT(*) FROM emp_attendance WHERE date = @date AND emp_name = @emp_name";
            cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@date", DTP1.Text);
            cmd.Parameters.AddWithValue("@emp_name", EmpNameComoBx2.Text);

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            if (count > 0)
            {
                MessageBox.Show("Attendance for this employee on this date already exists.");
            }
            else
            {
                querry = "INSERT INTO emp_attendance (date,emp_name,status) values" +
                            "(@date,@emp_name,@status)";
                cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@date", DTP1.Text);
                cmd.Parameters.AddWithValue("@emp_name", EmpNameComoBx2.Text);
                cmd.Parameters.AddWithValue("@status", comboBox1.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Attendance Inserted Succesfuly.");
            }
            GetAttendanceDetail();
            comboBox1.ResetText();
            EmpNameComoBx2.ResetText();
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMINDASHBOARD D1 = new ADMINDASHBOARD();
            D1.Show();
        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM emp_attendance WHERE emp_name LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void SearchTxt1_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt1.Text);
        }

        private void EmpNameComoBx2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                comboBox1.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                EmpNameComoBx2.Focus();
            }
        }

        private void EmpNameComoBx2_TextChanged(object sender, EventArgs e)
        {
            EmpNameComoBx2.BackColor = Color.White;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           comboBox1.BackColor = Color.White;
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           // DTP1.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            EmpNameComoBx2.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();            
            comboBox1.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void ClearBtn3_Click(object sender, EventArgs e)
        {
            EmpNameComoBx2.ResetText();
            comboBox1.ResetText();
        }

        private void EmpNameComoBx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EmpNameComoBx2_KeyPress(object sender, KeyPressEventArgs e)
        {
   //         e.KeyChar = (char)0;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void DTP1_ValueChanged_1(object sender, EventArgs e)
        {
            if (DateTime.Today > DTP1.Value || DateTime.Today < DTP1.Value)
            {
                MessageBox.Show("Selected Date is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP1.Value = DateTime.Today;
            }
        }
    }      
}

