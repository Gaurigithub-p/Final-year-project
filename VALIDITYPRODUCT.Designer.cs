namespace Pet_salon
{
    partial class VALIDITYPRODUCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VALIDITYPRODUCT));
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.CheckLbl1 = new System.Windows.Forms.Label();
            this.OutputLbl2 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackBtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(355, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT  VALIDITY  CHECK";
            // 
            // ComboBox1
            // 
            this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Valid Products",
            "Expired Products ",
            "View All Products"});
            this.ComboBox1.Location = new System.Drawing.Point(782, 217);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(371, 40);
            this.ComboBox1.TabIndex = 1;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // CheckLbl1
            // 
            this.CheckLbl1.AutoSize = true;
            this.CheckLbl1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLbl1.Image = ((System.Drawing.Image)(resources.GetObject("CheckLbl1.Image")));
            this.CheckLbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckLbl1.Location = new System.Drawing.Point(776, 169);
            this.CheckLbl1.Name = "CheckLbl1";
            this.CheckLbl1.Size = new System.Drawing.Size(139, 36);
            this.CheckLbl1.TabIndex = 2;
            this.CheckLbl1.Text = "     Check :";
            // 
            // OutputLbl2
            // 
            this.OutputLbl2.AutoSize = true;
            this.OutputLbl2.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLbl2.Location = new System.Drawing.Point(172, 250);
            this.OutputLbl2.Name = "OutputLbl2";
            this.OutputLbl2.Size = new System.Drawing.Size(39, 34);
            this.OutputLbl2.TabIndex = 3;
            this.OutputLbl2.Text = "...";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(178, 301);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(975, 367);
            this.DataGridView1.TabIndex = 4;
            // 
            // BackBtn1
            // 
            this.BackBtn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn1.ForeColor = System.Drawing.Color.Black;
            this.BackBtn1.Location = new System.Drawing.Point(618, 712);
            this.BackBtn1.Name = "BackBtn1";
            this.BackBtn1.Size = new System.Drawing.Size(151, 50);
            this.BackBtn1.TabIndex = 27;
            this.BackBtn1.Text = "BACK";
            this.BackBtn1.UseVisualStyleBackColor = false;
            this.BackBtn1.Click += new System.EventHandler(this.BackBtn1_Click);
            // 
            // VALIDITYPRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1194, 761);
            this.Controls.Add(this.BackBtn1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.OutputLbl2);
            this.Controls.Add(this.CheckLbl1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VALIDITYPRODUCT";
            this.Text = "ProductValidity_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VALIDITYPRODUCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Label CheckLbl1;
        private System.Windows.Forms.Label OutputLbl2;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button BackBtn1;
    }
}