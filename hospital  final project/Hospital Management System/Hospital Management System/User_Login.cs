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

namespace Hospital_Management_System
{
    public partial class USER_LOGIN : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\hospital  final project\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");
        public USER_LOGIN()
        {
            InitializeComponent();
        }

        private void btncClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1login_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter the user name and password to proceed");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DoctorsTbl where DoctorName= '"+txtUsername.Text+"' and DoctorPassword = '"+txtPassword.Text+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                   Doctor Page = new Doctor(); 
                    Page.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong user name and password");
                }
                Con.Close();
                
            }
        }

        private void USER_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            admin_login page = new admin_login();
            page.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
