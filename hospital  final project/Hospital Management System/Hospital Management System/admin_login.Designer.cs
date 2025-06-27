namespace Hospital_Management_System
{
    partial class admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1login = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btncClose = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.button1login);
            this.panel1.Location = new System.Drawing.Point(91, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 301);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Admin Login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(172, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.SystemColors.HotTrack;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 1;
            this.txtPassword.Location = new System.Drawing.Point(74, 100);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(263, 33);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMail
            // 
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMail.HintForeColor = System.Drawing.Color.Empty;
            this.txtMail.HintText = "";
            this.txtMail.isPassword = false;
            this.txtMail.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
            this.txtMail.LineIdleColor = System.Drawing.SystemColors.HotTrack;
            this.txtMail.LineMouseHoverColor = System.Drawing.SystemColors.HotTrack;
            this.txtMail.LineThickness = 1;
            this.txtMail.Location = new System.Drawing.Point(74, 44);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(263, 33);
            this.txtMail.TabIndex = 1;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMail.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // button1login
            // 
            this.button1login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1login.FlatAppearance.BorderSize = 0;
            this.button1login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1login.ForeColor = System.Drawing.Color.White;
            this.button1login.Location = new System.Drawing.Point(77, 155);
            this.button1login.Name = "button1login";
            this.button1login.Size = new System.Drawing.Size(263, 40);
            this.button1login.TabIndex = 0;
            this.button1login.Text = "LOGIN";
            this.button1login.UseVisualStyleBackColor = false;
            this.button1login.Click += new System.EventHandler(this.button1login_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btncClose);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(587, 251);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // btncClose
            // 
            this.btncClose.AutoSize = true;
            this.btncClose.BackColor = System.Drawing.Color.Transparent;
            this.btncClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncClose.Location = new System.Drawing.Point(549, 9);
            this.btncClose.Name = "btncClose";
            this.btncClose.Size = new System.Drawing.Size(26, 25);
            this.btncClose.TabIndex = 2;
            this.btncClose.Text = "X";
            this.btncClose.Click += new System.EventHandler(this.btncClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(161, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hospital Management System";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.admin_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btncClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

