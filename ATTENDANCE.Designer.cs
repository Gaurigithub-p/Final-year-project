namespace Pet_salon
{
    partial class ATTENDANCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATTENDANCE));
            this.label1 = new System.Windows.Forms.Label();
            this.DateLbl1 = new System.Windows.Forms.Label();
            this.EmpNameLbl3 = new System.Windows.Forms.Label();
            this.EmpNameComoBx2 = new System.Windows.Forms.ComboBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveBtn1 = new System.Windows.Forms.Button();
            this.BackBtn2 = new System.Windows.Forms.Button();
            this.SearchTxt1 = new System.Windows.Forms.TextBox();
            this.SearchLbl6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.ClearBtn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(206, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE ATTENDANCE";
            // 
            // DateLbl1
            // 
            this.DateLbl1.AutoSize = true;
            this.DateLbl1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl1.Location = new System.Drawing.Point(41, 367);
            this.DateLbl1.Name = "DateLbl1";
            this.DateLbl1.Size = new System.Drawing.Size(74, 36);
            this.DateLbl1.TabIndex = 1;
            this.DateLbl1.Text = "Date";
            // 
            // EmpNameLbl3
            // 
            this.EmpNameLbl3.AutoSize = true;
            this.EmpNameLbl3.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLbl3.Location = new System.Drawing.Point(41, 477);
            this.EmpNameLbl3.Name = "EmpNameLbl3";
            this.EmpNameLbl3.Size = new System.Drawing.Size(215, 36);
            this.EmpNameLbl3.TabIndex = 3;
            this.EmpNameLbl3.Text = "Employee Name";
            // 
            // EmpNameComoBx2
            // 
            this.EmpNameComoBx2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmpNameComoBx2.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameComoBx2.FormattingEnabled = true;
            this.EmpNameComoBx2.Location = new System.Drawing.Point(322, 481);
            this.EmpNameComoBx2.Name = "EmpNameComoBx2";
            this.EmpNameComoBx2.Size = new System.Drawing.Size(257, 35);
            this.EmpNameComoBx2.TabIndex = 6;
            this.EmpNameComoBx2.SelectedIndexChanged += new System.EventHandler(this.EmpNameComoBx2_SelectedIndexChanged);
            this.EmpNameComoBx2.TextChanged += new System.EventHandler(this.EmpNameComoBx2_TextChanged);
            this.EmpNameComoBx2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmpNameComoBx2_KeyDown);
            this.EmpNameComoBx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpNameComoBx2_KeyPress);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(977, 109);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(839, 754);
            this.DataGridView1.TabIndex = 8;
            this.DataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(46, 21);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(328, 293);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 12;
            this.PictureBox1.TabStop = false;
            // 
            // SaveBtn1
            // 
            this.SaveBtn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn1.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn1.Location = new System.Drawing.Point(1125, 911);
            this.SaveBtn1.Name = "SaveBtn1";
            this.SaveBtn1.Size = new System.Drawing.Size(148, 58);
            this.SaveBtn1.TabIndex = 28;
            this.SaveBtn1.Text = "SAVE";
            this.SaveBtn1.UseVisualStyleBackColor = false;
            this.SaveBtn1.Click += new System.EventHandler(this.SaveBtn1_Click);
            // 
            // BackBtn2
            // 
            this.BackBtn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn2.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn2.ForeColor = System.Drawing.Color.Black;
            this.BackBtn2.Location = new System.Drawing.Point(1365, 911);
            this.BackBtn2.Name = "BackBtn2";
            this.BackBtn2.Size = new System.Drawing.Size(150, 58);
            this.BackBtn2.TabIndex = 34;
            this.BackBtn2.Text = "BACK";
            this.BackBtn2.UseVisualStyleBackColor = false;
            this.BackBtn2.Click += new System.EventHandler(this.BackBtn4_Click);
            // 
            // SearchTxt1
            // 
            this.SearchTxt1.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTxt1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt1.ForeColor = System.Drawing.Color.Black;
            this.SearchTxt1.Location = new System.Drawing.Point(1142, 50);
            this.SearchTxt1.Name = "SearchTxt1";
            this.SearchTxt1.Size = new System.Drawing.Size(513, 43);
            this.SearchTxt1.TabIndex = 45;
            this.SearchTxt1.TextChanged += new System.EventHandler(this.SearchTxt1_TextChanged);
            // 
            // SearchLbl6
            // 
            this.SearchLbl6.AutoSize = true;
            this.SearchLbl6.BackColor = System.Drawing.Color.Transparent;
            this.SearchLbl6.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl6.ForeColor = System.Drawing.Color.Black;
            this.SearchLbl6.Image = ((System.Drawing.Image)(resources.GetObject("SearchLbl6.Image")));
            this.SearchLbl6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchLbl6.Location = new System.Drawing.Point(970, 53);
            this.SearchLbl6.Name = "SearchLbl6";
            this.SearchLbl6.Size = new System.Drawing.Size(155, 40);
            this.SearchLbl6.TabIndex = 44;
            this.SearchLbl6.Text = "      Search";
            this.SearchLbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PRESENT",
            "ABSENT"});
            this.comboBox1.Location = new System.Drawing.Point(322, 593);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 40);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 593);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 36);
            this.label3.TabIndex = 48;
            this.label3.Text = "Attendance";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.DTP1);
            this.groupBox1.Controls.Add(this.PictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DateLbl1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.EmpNameLbl3);
            this.groupBox1.Controls.Add(this.EmpNameComoBx2);
            this.groupBox1.Location = new System.Drawing.Point(155, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 684);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // DTP1
            // 
            this.DTP1.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP1.Location = new System.Drawing.Point(322, 368);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(257, 35);
            this.DTP1.TabIndex = 50;
            this.DTP1.Value = new System.DateTime(2023, 3, 14, 0, 0, 0, 0);
            this.DTP1.ValueChanged += new System.EventHandler(this.DTP1_ValueChanged_1);
            // 
            // ClearBtn3
            // 
            this.ClearBtn3.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClearBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn3.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn3.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn3.Location = new System.Drawing.Point(1605, 911);
            this.ClearBtn3.Name = "ClearBtn3";
            this.ClearBtn3.Size = new System.Drawing.Size(150, 58);
            this.ClearBtn3.TabIndex = 50;
            this.ClearBtn3.Text = "CLEAR";
            this.ClearBtn3.UseVisualStyleBackColor = false;
            this.ClearBtn3.Click += new System.EventHandler(this.ClearBtn3_Click);
            // 
            // ATTENDANCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1030);
            this.Controls.Add(this.ClearBtn3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchTxt1);
            this.Controls.Add(this.SearchLbl6);
            this.Controls.Add(this.BackBtn2);
            this.Controls.Add(this.SaveBtn1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ATTENDANCE";
            this.Text = "Attendance_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ATTENDANCE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateLbl1;
        private System.Windows.Forms.Label EmpNameLbl3;
        private System.Windows.Forms.ComboBox EmpNameComoBx2;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button SaveBtn1;
        private System.Windows.Forms.Button BackBtn2;
        private System.Windows.Forms.TextBox SearchTxt1;
        private System.Windows.Forms.Label SearchLbl6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearBtn3;
        private System.Windows.Forms.DateTimePicker DTP1;
    }
}