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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;         

namespace Pet_salon
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {  /*
            if (PassTxt2.PasswordChar =='*')
            {
                HideBtn.BringToFront();
                PassTxt2.PasswordChar ='\0';
            }  */
        }

        private void HideBtn_Click(object sender, EventArgs e)
        { /*
            if (PassTxt2.PasswordChar =='\0')
            {
                ShowBtn.BringToFront();
                PassTxt2.PasswordChar ='*';
            }  */
        }   

        private void LoginBtn1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("F:\\Pet_salon\\Pet_salon\\bin\\Debug\\Dog.wav");
            player.Play();
            System.Threading.Thread.Sleep(1000);
            player.Stop();
             
            string str = "Data Source=DESKTOP-BB9JAJN\\SQLEXPRESS;Initial Catalog=Pet_salon;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM login_details WHERE username='" + UserNameTxt1.Text + "' and pass='" + PassTxt2.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (comboBox1.Text == "")
            {                
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdItemValue = comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["utype"].ToString() == cmdItemValue)
                    {
                        
                        MessageBox.Show("You are logged in as " + dt.Rows[i][2]);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            ADMINDASHBOARD A = new ADMINDASHBOARD();
                            A.Show();
                            this.Hide();
                        }
                        else
                        {
                            DASHBOARD D = new DASHBOARD();
                            D.Show();
                            this.Hide(); 
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please select correct UserType");
                    }

                }
            }
            else
            {              
                MessageBox.Show("Please enter correct Username or Password");
            }
            con.Close();           
        }

        private void ExitBtn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearBtn2_Click(object sender, EventArgs e)
        {
            UserNameTxt1.Clear();
            PassTxt2.Clear();
            comboBox1.ResetText();
        }

        private void UserNameTxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
 //           UserNameTxt1.Focus();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void UserNameTxt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                PassTxt2.Focus();
            }

            if (e.Control == true)
            {
                MessageBox.Show("Copy & Paste has been disabled.", "Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PassTxt2_KeyDown(object sender, KeyEventArgs e)
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

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                LoginBtn1.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                PassTxt2.UseSystemPasswordChar= false;
            }
            else
            {
                PassTxt2.UseSystemPasswordChar = true;
            }
        }
    }    
}
