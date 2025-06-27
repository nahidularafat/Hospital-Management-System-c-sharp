using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Medicines : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\hospital  final project\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");

        public Medicines()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Doctor Obj = new Doctor();
            Obj.Show();
            this.Hide();
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

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            admin_login Obj = new admin_login();
            Obj.Show();
            this.Hide();
        }

        private void btncClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void DGVMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMedicineId.Text = DGVMedicine.SelectedRows[0].Cells[0].Value.ToString();
            txtMedicineName.Text = DGVMedicine.SelectedRows[0].Cells[1].Value.ToString();
            txtMedicineType.Text = DGVMedicine.SelectedRows[0].Cells[2].Value.ToString();
            txtByDoctor.Text = DGVMedicine.SelectedRows[0].Cells[3].Value.ToString();
        }
        void populate()
        {
            Con.Open();
            string query = " select * from MedicineTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVMedicine.DataSource = ds.Tables[0];
            Con.Close();


        }
        private void Reset()
        {
            txtMedicineId.Text = "";
            txtMedicineName.Text = "";
            txtMedicineType.Text = "";
            txtByDoctor.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtMedicineId.Text == "" || txtMedicineName.Text == "" || txtMedicineType.Text == "" || txtByDoctor.Text == "")
            {
                MessageBox.Show("Missing Information ! Fill All details Carefully");
            }
            else
            {
                Con.Open();
                string query = "insert into MedicineTbl values (" + txtMedicineId.Text + ",'" + txtMedicineName.Text + "','" + txtMedicineType.Text + "','" + txtByDoctor.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Added Successfully ");
                Con.Close();
                populate();
                Reset();
            }
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update MedicineTbl set MedicineName = '" + txtMedicineName.Text + "', MedicineType = '" + txtMedicineType.Text + "', ByDoctor = '" + txtByDoctor.Text + "' where MedicineID = " + txtMedicineId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Update Successfully");
            Con.Close();
            populate();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text == "")
            {
                MessageBox.Show("Enter The Medicine ID ");
            }
            else
            {
                Con.Open();
                string query = "delete from MedicineTbl where MedicineID=" + txtMedicineId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted Successfully ");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Medicines_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
