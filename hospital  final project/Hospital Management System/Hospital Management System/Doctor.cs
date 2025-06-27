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
    public partial class Doctor : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\hospital  final project\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");
        public Doctor()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btncClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            patient Obj = new patient();
            Obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Diagn Obj = new Diagn();
            Obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Medicines Obj = new Medicines();
            Obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            admin_login Obj = new admin_login();
            Obj.Show();
            this.Hide();
        }
        void populate()
        {
            Con.Open();
            string query = " select * from DoctorsTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVdoctors.DataSource = ds.Tables[0];
            Con.Close();
            

        }
        private void Reset()
        {
            txtDoctorId.Text = "";
            txtDoctorId.Text = "";
            txtYearsofExperience.Text = "";
            txtPassword.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtDoctorId.Text == "" || txtDoctorName.Text == "" || txtYearsofExperience.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information ! Fill All details Carefully");
            }
            else
            {
                Con.Open();
                string query = "insert into DoctorsTbl values (" + txtDoctorId.Text + ",'" + txtDoctorName.Text + "'," + txtYearsofExperience.Text + ",'" + txtPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Added Successfully ");
                Con.Close();
                populate();
                Reset();
            }
        }
        private void DGVdoctors_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtDoctorId.Text = DGVdoctors.SelectedRows[0].Cells[0].Value.ToString();
            txtDoctorName.Text = DGVdoctors.SelectedRows[0].Cells[1].Value.ToString();
            txtYearsofExperience.Text = DGVdoctors.SelectedRows[0].Cells[2].Value.ToString();
            txtPassword.Text = DGVdoctors.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

            populate();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DoctorsTbl set DoctorName = '" + txtDoctorName.Text + "', DoctorExp = '" + txtYearsofExperience.Text + "', DoctorPassword = '" + txtPassword.Text + "' where DoctorID = " + txtDoctorId.Text+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Update Successfully");
            Con.Close();
            populate();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDoctorId.Text == "")
            {
                MessageBox.Show("Enter The Doctor ID ");
            }
            else
            {
                Con.Open();
                string query = "delete from DoctorsTbl where DoctorId=" + txtDoctorId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctors Deleted Successfully ");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void txtDoctorId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
