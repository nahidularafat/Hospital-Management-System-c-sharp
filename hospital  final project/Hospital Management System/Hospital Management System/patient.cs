using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class patient : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\hospital  final project\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");

        public patient()
        {
            InitializeComponent();
        }

       

        private void btncClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Doctor Obj = new Doctor();
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
            string query = " select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVpatients.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            txtPatientID.Text = "";
            txtPatientName.Text= "";
            txtPatientAdress.Text = "";
            txtPhoneNumber.Text = "";
            txtPatientAge.Text = "";
            txtMajorDisease.Text="";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text == "" || txtPatientName.Text == "" || txtPatientAdress.Text == "" || txtPhoneNumber.Text == "" || txtPatientAge.Text == "" || txtMajorDisease.Text=="")
            {
                MessageBox.Show("Missing Information ! see Carefully");
            }
            else
            {
                Con.Open();
                string query = "insert into PatientTbl values("+txtPatientID.Text+", '"+txtPatientName.Text+"', '"+txtPatientAdress.Text+"','"+txtPhoneNumber.Text+"',"+txtPatientAge.Text+", '"+CbGender.SelectedItem.ToString()+"','"+CbBloodGroup.SelectedItem.ToString()+"','"+txtMajorDisease.Text+"')";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient ADDED Successfuly !");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void DGVpatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPatientID.Text = DGVpatients.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientName.Text = DGVpatients.SelectedRows[0].Cells[1].Value.ToString();
            txtPatientAdress.Text = DGVpatients.SelectedRows[0].Cells[2].Value.ToString();
            txtPhoneNumber.Text = DGVpatients.SelectedRows[0].Cells[3].Value.ToString();
            txtPatientAge.Text = DGVpatients.SelectedRows[0].Cells[4].Value.ToString();
            txtMajorDisease.Text = DGVpatients.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void patient_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTbl set PatientName = '" + txtPatientName.Text + "', PatientAdress='" + txtPatientAdress.Text + "', PatientPhone = '" + txtPhoneNumber.Text + "', PatientAge = " + txtPatientAge.Text + ", PatientDisease='" + txtMajorDisease.Text + "' where PatientId = " + txtPatientID.Text + "";

            SqlCommand cmd = new SqlCommand(query,Con); 
            cmd.ExecuteNonQuery();
            MessageBox.Show("patient Update successfully");
            Con.Close();
            populate();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text == "")
                MessageBox.Show("Enter the patient id");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatientId = " + txtPatientID.Text + "";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient deleted successfully"); 
                Con.Close();
                populate();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPatientID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPatientName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPatientAdress_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
