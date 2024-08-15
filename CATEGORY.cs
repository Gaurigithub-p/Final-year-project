using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_salon
{
    public partial class CATEGORY : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public CATEGORY()
        {
            InitializeComponent();
        }

        double val;
        string ID = "SC";

        private void AutoNumber()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(category_id) FROM [add_category]", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            IdLbl2.Text = ID + val + i.ToString();
        }

        void GetCategoryDetails()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            adapter = new SqlDataAdapter("SELECT * FROM add_Category", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void CATEGORY_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            GetCategoryDetails();
            AutoNumber();
            SearchData("");

            NameTxt1.Clear();
            StatusCmboBx.ResetText();
        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {

            if (NameTxt1.Text == "")
            {
                NameTxt1.BackColor = Color.IndianRed;
                MessageBox.Show("Please Enter Category Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameTxt1.Focus();
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
            SqlCommand CommandToCheckCustomerId = new SqlCommand("SELECT category_id FROM add_category WHERE category_id ='" + IdLbl2.Text + "'", conn);
            string SCid = (string)CommandToCheckCustomerId.ExecuteScalar();
            conn.Close();

            if (SCid == IdLbl2.Text)
            {
                MessageBox.Show("Category ID Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string querry = "INSERT INTO add_category (category_id, category_name, category_status) values" +
                    "(@category_id, @category_name, @category_status)";

                cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@category_id", IdLbl2.Text);
                cmd.Parameters.AddWithValue("@category_name", NameTxt1.Text);
                cmd.Parameters.AddWithValue("@category_status", StatusCmboBx.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Category Details Inserted SuccesfuLly.");

                GetCategoryDetails();
                AutoNumber();
                NameTxt1.Clear();
                StatusCmboBx.ResetText();
            }
        }

        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            string id = IdLbl2.Text;
            bool idExists = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["category_id"].Value != null && row.Cells["category_id"].Value.ToString() == id)
                {
                     idExists = true;
                }
            }

            if (idExists)
            {    
                if (NameTxt1.Text != "" && StatusCmboBx.Text != "")
                {
                    string querry = "UPDATE add_category " +
                       "SET category_name=@category_name, category_status=@category_status WHERE category_id=@category_id";

                    cmd = new SqlCommand(querry, conn);
                    cmd.Parameters.AddWithValue("@category_id", IdLbl2.Text);
                    cmd.Parameters.AddWithValue("@category_name", NameTxt1.Text);
                    cmd.Parameters.AddWithValue("@category_status", StatusCmboBx.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Category Details Updated Succesfuly.");

                    GetCategoryDetails();
                    AutoNumber();
                    NameTxt1.Clear();
                    StatusCmboBx.ResetText();
                }
                else
                {
                    MessageBox.Show("Please Enter Data To Update.");
                }
            }
            else
            {
                MessageBox.Show("Category ID does not exist.");
            }
        }

        private void BackBtn3_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMINDASHBOARD D1 = new ADMINDASHBOARD();
            D1.Show();
        }

        private void NameTxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void NameTxt1_TextChanged(object sender, EventArgs e)
        {
            NameTxt1.BackColor = Color.White;
        }

        private void StatusCmboBx_TextChanged(object sender, EventArgs e)
        {
            StatusCmboBx.BackColor = Color.White;
        }

        private void SearchTxt6_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt6.Text);
        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM add_category WHERE category_name LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            AutoNumber();
            NameTxt1.Clear();
            StatusCmboBx.ResetText();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            IdLbl2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NameTxt1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            StatusCmboBx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void ClearBtn4_Click(object sender, EventArgs e)
        {
            GetCategoryDetails();
            NameTxt1.Clear();
            StatusCmboBx.ResetText();
            AutoNumber();
        }
    }
}
