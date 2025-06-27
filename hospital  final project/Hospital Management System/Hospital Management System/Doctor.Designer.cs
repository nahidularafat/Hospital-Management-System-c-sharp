namespace Hospital_Management_System
{
    partial class Doctor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.DGVdoctors = new Guna.UI.WinForms.GunaDataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDoctorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDoctorId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton6 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton5 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtYearsofExperience = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnReload = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btncClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdoctors)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVdoctors
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVdoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVdoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVdoctors.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVdoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVdoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVdoctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVdoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVdoctors.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVdoctors.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVdoctors.EnableHeadersVisualStyles = false;
            this.DGVdoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVdoctors.Location = new System.Drawing.Point(373, 360);
            this.DGVdoctors.Name = "DGVdoctors";
            this.DGVdoctors.RowHeadersVisible = false;
            this.DGVdoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVdoctors.Size = new System.Drawing.Size(847, 334);
            this.DGVdoctors.TabIndex = 11;
            this.DGVdoctors.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVdoctors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVdoctors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVdoctors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVdoctors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVdoctors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVdoctors.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVdoctors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVdoctors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVdoctors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVdoctors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVdoctors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVdoctors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVdoctors.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVdoctors.ThemeStyle.ReadOnly = false;
            this.DGVdoctors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVdoctors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVdoctors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVdoctors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVdoctors.ThemeStyle.RowsStyle.Height = 22;
            this.DGVdoctors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVdoctors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVdoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdoctors_CellContentClick_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(408, 130);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(111, 13);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "DOCTORS DETAILS:";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 4;
            this.txtPassword.Location = new System.Drawing.Point(664, 16);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(163, 44);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.ForeColor = System.Drawing.Color.Black;
            this.txtDoctorName.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorName.HintText = "Doctor Name";
            this.txtDoctorName.isPassword = false;
            this.txtDoctorName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorName.LineThickness = 4;
            this.txtDoctorName.Location = new System.Drawing.Point(225, 16);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(191, 44);
            this.txtDoctorName.TabIndex = 4;
            this.txtDoctorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorId.ForeColor = System.Drawing.Color.Black;
            this.txtDoctorId.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorId.HintText = "Doctor ID";
            this.txtDoctorId.isPassword = false;
            this.txtDoctorId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorId.LineThickness = 4;
            this.txtDoctorId.Location = new System.Drawing.Point(17, 16);
            this.txtDoctorId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(186, 44);
            this.txtDoctorId.TabIndex = 2;
            this.txtDoctorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoctorId.OnValueChanged += new System.EventHandler(this.txtDoctorId_OnValueChanged);
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.CheckedImage")));
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.Image")));
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.RoyalBlue;
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(24, 430);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(278, 76);
            this.gunaAdvenceButton4.TabIndex = 9;
            this.gunaAdvenceButton4.Text = "Medicines";
            this.gunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton4.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.Image")));
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.RoyalBlue;
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(24, 266);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(278, 76);
            this.gunaAdvenceButton3.TabIndex = 8;
            this.gunaAdvenceButton3.Text = "Patients";
            this.gunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton3.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.RoyalBlue;
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(24, 348);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(278, 76);
            this.gunaAdvenceButton2.TabIndex = 7;
            this.gunaAdvenceButton2.Text = "Diagnosis";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // gunaAdvenceButton6
            // 
            this.gunaAdvenceButton6.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton6.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton6.BaseColor = System.Drawing.SystemColors.HotTrack;
            this.gunaAdvenceButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton6.CheckedImage")));
            this.gunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton6.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton6.Image")));
            this.gunaAdvenceButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton6.LineColor = System.Drawing.Color.RoyalBlue;
            this.gunaAdvenceButton6.Location = new System.Drawing.Point(73, 670);
            this.gunaAdvenceButton6.Name = "gunaAdvenceButton6";
            this.gunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.OnHoverImage = null;
            this.gunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.gunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.Radius = 15;
            this.gunaAdvenceButton6.Size = new System.Drawing.Size(174, 47);
            this.gunaAdvenceButton6.TabIndex = 6;
            this.gunaAdvenceButton6.Text = "Logout";
            this.gunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton6.Click += new System.EventHandler(this.gunaAdvenceButton6_Click);
            // 
            // gunaAdvenceButton5
            // 
            this.gunaAdvenceButton5.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton5.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaAdvenceButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaAdvenceButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton5.CheckedImage")));
            this.gunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton5.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton5.Image")));
            this.gunaAdvenceButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton5.LineColor = System.Drawing.Color.RoyalBlue;
            this.gunaAdvenceButton5.Location = new System.Drawing.Point(-3, 828);
            this.gunaAdvenceButton5.Name = "gunaAdvenceButton5";
            this.gunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.OnHoverImage = null;
            this.gunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.gunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.Size = new System.Drawing.Size(348, 55);
            this.gunaAdvenceButton5.TabIndex = 5;
            this.gunaAdvenceButton5.Text = "Logout";
            this.gunaAdvenceButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.CheckedImage")));
            this.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.LineColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(280, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 15;
            this.btnUpdate.Size = new System.Drawing.Size(122, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(121, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 15;
            this.btnAdd.Size = new System.Drawing.Size(122, 37);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtYearsofExperience
            // 
            this.txtYearsofExperience.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYearsofExperience.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearsofExperience.ForeColor = System.Drawing.Color.Black;
            this.txtYearsofExperience.HintForeColor = System.Drawing.Color.Empty;
            this.txtYearsofExperience.HintText = "Year of experience";
            this.txtYearsofExperience.isPassword = false;
            this.txtYearsofExperience.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtYearsofExperience.LineIdleColor = System.Drawing.Color.Gray;
            this.txtYearsofExperience.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtYearsofExperience.LineThickness = 4;
            this.txtYearsofExperience.Location = new System.Drawing.Point(461, 17);
            this.txtYearsofExperience.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearsofExperience.Name = "txtYearsofExperience";
            this.txtYearsofExperience.Size = new System.Drawing.Size(163, 44);
            this.txtYearsofExperience.TabIndex = 13;
            this.txtYearsofExperience.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.RoyalBlue;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(24, 184);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(278, 76);
            this.gunaAdvenceButton1.TabIndex = 0;
            this.gunaAdvenceButton1.Text = "Doctors";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReload
            // 
            this.btnReload.AnimationHoverSpeed = 0.07F;
            this.btnReload.AnimationSpeed = 0.03F;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnReload.BorderColor = System.Drawing.Color.Black;
            this.btnReload.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReload.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReload.CheckedForeColor = System.Drawing.Color.White;
            this.btnReload.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnReload.CheckedImage")));
            this.btnReload.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.FocusedColor = System.Drawing.Color.Empty;
            this.btnReload.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReload.LineColor = System.Drawing.Color.RoyalBlue;
            this.btnReload.Location = new System.Drawing.Point(603, 90);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnReload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReload.OnHoverImage = null;
            this.btnReload.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.btnReload.OnPressedColor = System.Drawing.Color.Black;
            this.btnReload.Radius = 15;
            this.btnReload.Size = new System.Drawing.Size(122, 37);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtYearsofExperience);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtDoctorName);
            this.panel3.Controls.Add(this.txtDoctorId);
            this.panel3.Location = new System.Drawing.Point(392, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 153);
            this.panel3.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.CheckedImage")));
            this.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(446, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.Yellow;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 15;
            this.btnDelete.Size = new System.Drawing.Size(122, 37);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(269, 35);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(418, 40);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Hospital Management System";
            // 
            // btncClose
            // 
            this.btncClose.AutoSize = true;
            this.btncClose.BackColor = System.Drawing.Color.Transparent;
            this.btncClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncClose.Location = new System.Drawing.Point(870, 8);
            this.btncClose.Name = "btncClose";
            this.btncClose.Size = new System.Drawing.Size(33, 31);
            this.btncClose.TabIndex = 3;
            this.btncClose.Text = "X";
            this.btncClose.Click += new System.EventHandler(this.btncClose_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.btncClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(348, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 122);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.gunaAdvenceButton4);
            this.panel1.Controls.Add(this.gunaAdvenceButton3);
            this.panel1.Controls.Add(this.gunaAdvenceButton2);
            this.panel1.Controls.Add(this.gunaAdvenceButton6);
            this.panel1.Controls.Add(this.gunaAdvenceButton5);
            this.panel1.Controls.Add(this.gunaAdvenceButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 729);
            this.panel1.TabIndex = 7;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(754, 329);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(88, 13);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "DOCTOR\'S LIST";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.DGVdoctors);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdoctors)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView DGVdoctors;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorId;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton6;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton5;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtYearsofExperience;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnReload;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label btncClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}