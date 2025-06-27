using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressBar1.Value = startpoint;
            if(ProgressBar1.Value == 100)
            {
                ProgressBar1.Value = 0;
                timer1.Stop();
                USER_LOGIN Page = new USER_LOGIN();
                Page.Show();
                this.Hide();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btncClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void gunaWinCircleProgressIndicator1_Load(object sender, EventArgs e)
        {

        }
    }
}
