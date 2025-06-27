using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Diagn : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\hospital  final project\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");

        public Diagn()
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
        private void btncClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populateId()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatientId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CbPatientId.ValueMember = "PatientId";
                CbPatientId.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        string PatientName;
        void fecthpatientname()
        {
            Con.Open();
            string mysql = "select * from PatientTbl where PatientId =" + CbPatientId.SelectedValue.ToString() + " ";
            SqlCommand cmd = new SqlCommand(@mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatientName = dr["PatientName"].ToString();
                txtPatientName.Text = PatientName;
            }
            Con.Close();

        }
        void populate()
        {
            Con.Open();
            string query = " select * from DiagnosisTbl ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGDaignosis.DataSource = ds.Tables[0];
            Con.Close();
        }

        /* void populate()
         {
             Con.Open();
             string query = " select * from DiagnosisTbl ";
             SqlDataAdapter da = new SqlDataAdapter(query, Con);
             SqlCommandBuilder builder = new SqlCommandBuilder(da);
             var ds = new DataSet();
             da.Fill(ds);
             DGDaignosis.DataSource = ds.Tables[0];
             Con.Close();
         }
         private void Reset()
         {
             txtDiagnosisId.Text = "";
             txtPatientName.Text = "";
             txtSymptoms.Text = "";
             txtDiagmosis.Text = "";
             txtMedicine.Text = "";
            // txtMajorDisease.Text = "";

         }
        */
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDiagnosisId.Text == "" || txtPatientName.Text == "" || txtSymptoms.Text == "" || txtDiagmosis.Text == "" || txtMedicine.Text == "")
            {
                MessageBox.Show("Missing Information ! Fill All details Carefully");
            }

            // '" + CbPatientId.SelectedItem.ToString() + "', /
            else
            {
                Con.Open();

                string query = "insert into DiagnosisTbl values(" + txtDiagnosisId.Text + "," + CbPatientId.SelectedValue.ToString() + " ,'" + txtPatientName.Text + "' , '" + txtSymptoms.Text + "' ,'" + txtDiagmosis.Text + "', '" + txtMedicine.Text + "' )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis ADDED Successfuly !");
                Con.Close();
                // populate();
                //  Reset();
            }
            /* if (txtDiagnosisId.Text == "" || txtPatientName.Text == "" || txtSymptoms.Text == "" || txtDiagmosis.Text == "" || txtMedicine.Text == "")
             {
                 MessageBox.Show("Missing Information ! Fill All details Carefully");
             }

            // '" + CbPatientId.SelectedItem.ToString() + "', /
             else
             {
                 Con.Open();
                 string query = "insert into DiagnosisTbl values(" + txtDiagnosisId.Text + ", '" + txtPatientName.Text + "','" + txtSymptoms.Text + "','" + txtDiagmosis.Text + "','" + txtMedicine.Text + "')";
                 SqlCommand cmd = new SqlCommand(query, Con);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Diagnosis ADDED Successfuly !");
                 Con.Close();
                 populate();
                 Reset();
             }
            */
        }

        private void Diagn_Load(object sender, EventArgs e)
        {
            populateId();
            populate();
        }
        private void CbPatientId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fecthpatientname();
        }

        private void txtDiagnosisId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Con.Open();
            string query = "update DiagnosisTbl set PatientName = '" + txtPatientName.Text + "', Symptoms='" + txtSymptoms.Text + "', Diagnosis = '" + txtDiagmosis.Text + "', Medicine = '" + txtMedicine.Text + "'  where DiagnosisId = " + txtDiagnosisId.Text + "";
          


            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Update successfully");
            Con.Close();
            populate();
            //Reset();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDiagnosisId.Text == "")
                MessageBox.Show("Enter the Diagnosis id");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagnosisId = " + txtDiagnosisId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis deleted successfully");
                Con.Close();
                populate();
            }
        }
        private void DGDaignosis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiagnosisId.Text = DGDaignosis.SelectedRows[0].Cells[0].Value.ToString();
            CbPatientId.SelectedValue = DGDaignosis.SelectedRows[0].Cells[1].Value.ToString();
            txtPatientName.Text = DGDaignosis.SelectedRows[0].Cells[2].Value.ToString();
            txtSymptoms.Text = DGDaignosis.SelectedRows[0].Cells[3].Value.ToString();
            txtDiagmosis.Text = DGDaignosis.SelectedRows[0].Cells[4].Value.ToString();
            txtMedicine.Text = DGDaignosis.SelectedRows[0].Cells[5].Value.ToString();
            //  txtMajorDisease.Text = DGDaignosis.SelectedRows[0].Cells[7].Value.ToString();
            lvl1.Text = DGDaignosis.SelectedRows[0].Cells[1].Value.ToString();
            lvl2.Text = DGDaignosis.SelectedRows[0].Cells[2].Value.ToString();
            lvl3.Text = DGDaignosis.SelectedRows[0].Cells[3].Value.ToString();
            lvl4.Text = DGDaignosis.SelectedRows[0].Cells[4].Value.ToString();

            // print hardcopy code of lvl1 3 and 3

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
          //  e.Graphics.DrawString(txtSummery.Text + lvl1.Text + lvl2.Text + lvl3.Text + lvl4.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130));

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             e.Graphics.DrawString(txtSummery.Text +"\n\n\n\n\n\n\n\n", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));

             e.Graphics.DrawString( lvl1.Text +"\n"+ lvl2.Text +"\n"+ lvl3.Text +"\n"+ lvl4.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130));
            
         /*   string summary = txtSymptoms.Text + "\n" +
                      txtDiagmosis.Text + "\n" +
                      txtMedicine.Text;

            e.Graphics.DrawString(summary, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(100, 100));
         */
        }

        private void lvl3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
