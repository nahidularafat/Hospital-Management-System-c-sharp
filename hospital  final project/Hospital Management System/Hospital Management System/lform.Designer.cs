namespace Hospital_Management_System
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btncClose = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.gunaWinCircleProgressIndicator1 = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.btncClose);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(571, 96);
            this.bunifuGradientPanel1.TabIndex = 9;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(76, 28);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(418, 40);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Hospital Management System";
            // 
            // btncClose
            // 
            this.btncClose.AutoSize = true;
            this.btncClose.BackColor = System.Drawing.Color.Transparent;
            this.btncClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncClose.Location = new System.Drawing.Point(542, 9);
            this.btncClose.Name = "btncClose";
            this.btncClose.Size = new System.Drawing.Size(26, 25);
            this.btncClose.TabIndex = 2;
            this.btncClose.Text = "X";
            this.btncClose.Click += new System.EventHandler(this.btncClose_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar1.Location = new System.Drawing.Point(0, 461);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(571, 23);
            this.ProgressBar1.TabIndex = 12;
            this.ProgressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // gunaWinCircleProgressIndicator1
            // 
            this.gunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaWinCircleProgressIndicator1.Location = new System.Drawing.Point(192, 158);
            this.gunaWinCircleProgressIndicator1.Name = "gunaWinCircleProgressIndicator1";
            this.gunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.gunaWinCircleProgressIndicator1.Size = new System.Drawing.Size(193, 184);
            this.gunaWinCircleProgressIndicator1.TabIndex = 11;
            this.gunaWinCircleProgressIndicator1.Load += new System.EventHandler(this.gunaWinCircleProgressIndicator1_Load);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(89, 397);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(391, 33);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Loading Application Please wait.....";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(571, 484);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.gunaWinCircleProgressIndicator1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.RightToLeftLayout = true;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label btncClose;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator gunaWinCircleProgressIndicator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}