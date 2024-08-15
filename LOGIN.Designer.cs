namespace Pet_salon
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameLbl1 = new System.Windows.Forms.Label();
            this.UserNameTxt1 = new System.Windows.Forms.TextBox();
            this.PassLbl2 = new System.Windows.Forms.Label();
            this.TypeLbl3 = new System.Windows.Forms.Label();
            this.PassTxt2 = new System.Windows.Forms.TextBox();
            this.LoginBtn1 = new System.Windows.Forms.Button();
            this.ClearBtn2 = new System.Windows.Forms.Button();
            this.ExitBtn3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(306, 30);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(212, 153);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // UserNameLbl1
            // 
            this.UserNameLbl1.AutoSize = true;
            this.UserNameLbl1.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLbl1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl1.Location = new System.Drawing.Point(32, 213);
            this.UserNameLbl1.Name = "UserNameLbl1";
            this.UserNameLbl1.Size = new System.Drawing.Size(158, 36);
            this.UserNameLbl1.TabIndex = 1;
            this.UserNameLbl1.Text = "Username:-";
            // 
            // UserNameTxt1
            // 
            this.UserNameTxt1.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt1.Location = new System.Drawing.Point(256, 213);
            this.UserNameTxt1.Name = "UserNameTxt1";
            this.UserNameTxt1.Size = new System.Drawing.Size(394, 35);
            this.UserNameTxt1.TabIndex = 2;
            this.UserNameTxt1.TextChanged += new System.EventHandler(this.UserNameTxt1_TextChanged);
            this.UserNameTxt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameTxt1_KeyDown);
            // 
            // PassLbl2
            // 
            this.PassLbl2.AutoSize = true;
            this.PassLbl2.BackColor = System.Drawing.Color.Transparent;
            this.PassLbl2.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLbl2.Location = new System.Drawing.Point(32, 278);
            this.PassLbl2.Name = "PassLbl2";
            this.PassLbl2.Size = new System.Drawing.Size(151, 36);
            this.PassLbl2.TabIndex = 3;
            this.PassLbl2.Text = "Password:-";
            // 
            // TypeLbl3
            // 
            this.TypeLbl3.AutoSize = true;
            this.TypeLbl3.BackColor = System.Drawing.Color.Transparent;
            this.TypeLbl3.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLbl3.Location = new System.Drawing.Point(32, 352);
            this.TypeLbl3.Name = "TypeLbl3";
            this.TypeLbl3.Size = new System.Drawing.Size(158, 36);
            this.TypeLbl3.TabIndex = 4;
            this.TypeLbl3.Text = "User Type:-";
            // 
            // PassTxt2
            // 
            this.PassTxt2.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxt2.Location = new System.Drawing.Point(256, 282);
            this.PassTxt2.Name = "PassTxt2";
            this.PassTxt2.Size = new System.Drawing.Size(394, 35);
            this.PassTxt2.TabIndex = 5;
            this.PassTxt2.UseSystemPasswordChar = true;
            this.PassTxt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassTxt2_KeyDown);
            // 
            // LoginBtn1
            // 
            this.LoginBtn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn1.Location = new System.Drawing.Point(541, 527);
            this.LoginBtn1.Name = "LoginBtn1";
            this.LoginBtn1.Size = new System.Drawing.Size(118, 59);
            this.LoginBtn1.TabIndex = 6;
            this.LoginBtn1.Text = "Login";
            this.LoginBtn1.UseVisualStyleBackColor = false;
            this.LoginBtn1.Click += new System.EventHandler(this.LoginBtn1_Click);
            // 
            // ClearBtn2
            // 
            this.ClearBtn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClearBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn2.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn2.Location = new System.Drawing.Point(716, 527);
            this.ClearBtn2.Name = "ClearBtn2";
            this.ClearBtn2.Size = new System.Drawing.Size(118, 59);
            this.ClearBtn2.TabIndex = 7;
            this.ClearBtn2.Text = "Clear";
            this.ClearBtn2.UseVisualStyleBackColor = false;
            this.ClearBtn2.Click += new System.EventHandler(this.ClearBtn2_Click);
            // 
            // ExitBtn3
            // 
            this.ExitBtn3.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExitBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn3.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn3.Location = new System.Drawing.Point(888, 527);
            this.ExitBtn3.Name = "ExitBtn3";
            this.ExitBtn3.Size = new System.Drawing.Size(118, 59);
            this.ExitBtn3.TabIndex = 8;
            this.ExitBtn3.Text = "Exit";
            this.ExitBtn3.UseVisualStyleBackColor = false;
            this.ExitBtn3.Click += new System.EventHandler(this.ExitBtn3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.comboBox1.Location = new System.Drawing.Point(256, 356);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(394, 35);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(44, 128);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(243, 248);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 10;
            this.PictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.UserNameLbl1);
            this.groupBox1.Controls.Add(this.PictureBox1);
            this.groupBox1.Controls.Add(this.UserNameTxt1);
            this.groupBox1.Controls.Add(this.PassLbl2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.TypeLbl3);
            this.groupBox1.Controls.Add(this.PassTxt2);
            this.groupBox1.Location = new System.Drawing.Point(364, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 437);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bodoni MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(665, 293);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.ExitBtn3);
            this.Controls.Add(this.ClearBtn2);
            this.Controls.Add(this.LoginBtn1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label UserNameLbl1;
        private System.Windows.Forms.TextBox UserNameTxt1;
        private System.Windows.Forms.Label PassLbl2;
        private System.Windows.Forms.Label TypeLbl3;
        private System.Windows.Forms.TextBox PassTxt2;
        private System.Windows.Forms.Button LoginBtn1;
        private System.Windows.Forms.Button ClearBtn2;
        private System.Windows.Forms.Button ExitBtn3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}