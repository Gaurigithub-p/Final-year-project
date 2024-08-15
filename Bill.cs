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

namespace Pet_salon
{
    public partial class Bill : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public Bill()
        {
            InitializeComponent();
        }

        void GetBillDetail()
        {
            conn = new SqlConnection("Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True");
            adapter = new SqlDataAdapter("SELECT * FROM bill ORDER BY date ASC", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            GetBillDetail();
            SearchData("");
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            this.Close();
            DASHBOARD d1 = new DASHBOARD();
            d1.Show();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchTxt.Text);
        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM bill WHERE date LIKE '%" + ValueToSearch + "%' ";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
