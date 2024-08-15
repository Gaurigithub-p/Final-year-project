namespace Pet_salon
{
    partial class CATEGORY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CATEGORY));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdLbl2 = new System.Windows.Forms.Label();
            this.NameTxt1 = new System.Windows.Forms.TextBox();
            this.NameLbl3 = new System.Windows.Forms.Label();
            this.CatIdLbl1 = new System.Windows.Forms.Label();
            this.SaveBtn1 = new System.Windows.Forms.Button();
            this.UpdateBtn2 = new System.Windows.Forms.Button();
            this.BackBtn3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClearBtn4 = new System.Windows.Forms.Button();
            this.SearchTxt6 = new System.Windows.Forms.TextBox();
            this.SearchLbl9 = new System.Windows.Forms.Label();
            this.StatusLbl4 = new System.Windows.Forms.Label();
            this.StatusCmboBx = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(276, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD SERVICE CATEGORIES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.StatusCmboBx);
            this.groupBox1.Controls.Add(this.StatusLbl4);
            this.groupBox1.Controls.Add(this.IdLbl2);
            this.groupBox1.Controls.Add(this.NameTxt1);
            this.groupBox1.Controls.Add(this.NameLbl3);
            this.groupBox1.Controls.Add(this.CatIdLbl1);
            this.groupBox1.Font = new System.Drawing.Font("Bodoni MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(243, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 620);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories Info";
            // 
            // IdLbl2
            // 
            this.IdLbl2.AutoSize = true;
            this.IdLbl2.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl2.Location = new System.Drawing.Point(59, 173);
            this.IdLbl2.Name = "IdLbl2";
            this.IdLbl2.Size = new System.Drawing.Size(47, 36);
            this.IdLbl2.TabIndex = 3;
            this.IdLbl2.Text = "....";
            // 
            // NameTxt1
            // 
            this.NameTxt1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt1.Location = new System.Drawing.Point(59, 363);
            this.NameTxt1.Name = "NameTxt1";
            this.NameTxt1.Size = new System.Drawing.Size(305, 40);
            this.NameTxt1.TabIndex = 2;
            this.NameTxt1.TextChanged += new System.EventHandler(this.NameTxt1_TextChanged);
            this.NameTxt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt1_KeyPress);
            // 
            // NameLbl3
            // 
            this.NameLbl3.AutoSize = true;
            this.NameLbl3.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl3.Location = new System.Drawing.Point(53, 300);
            this.NameLbl3.Name = "NameLbl3";
            this.NameLbl3.Size = new System.Drawing.Size(192, 34);
            this.NameLbl3.TabIndex = 1;
            this.NameLbl3.Text = "Category Name";
            // 
            // CatIdLbl1
            // 
            this.CatIdLbl1.AutoSize = true;
            this.CatIdLbl1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdLbl1.Location = new System.Drawing.Point(53, 113);
            this.CatIdLbl1.Name = "CatIdLbl1";
            this.CatIdLbl1.Size = new System.Drawing.Size(150, 34);
            this.CatIdLbl1.TabIndex = 0;
            this.CatIdLbl1.Text = "Category Id";
            // 
            // SaveBtn1
            // 
            this.SaveBtn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn1.Location = new System.Drawing.Point(921, 749);
            this.SaveBtn1.Name = "SaveBtn1";
            this.SaveBtn1.Size = new System.Drawing.Size(128, 60);
            this.SaveBtn1.TabIndex = 2;
            this.SaveBtn1.Text = "SAVE";
            this.SaveBtn1.UseVisualStyleBackColor = false;
            this.SaveBtn1.Click += new System.EventHandler(this.SaveBtn1_Click);
            // 
            // UpdateBtn2
            // 
            this.UpdateBtn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn2.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn2.Location = new System.Drawing.Point(1076, 749);
            this.UpdateBtn2.Name = "UpdateBtn2";
            this.UpdateBtn2.Size = new System.Drawing.Size(158, 60);
            this.UpdateBtn2.TabIndex = 0;
            this.UpdateBtn2.Text = "UPDATE";
            this.UpdateBtn2.UseVisualStyleBackColor = false;
            this.UpdateBtn2.Click += new System.EventHandler(this.UpdateBtn2_Click);
            // 
            // BackBtn3
            // 
            this.BackBtn3.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn3.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn3.Location = new System.Drawing.Point(1434, 749);
            this.BackBtn3.Name = "BackBtn3";
            this.BackBtn3.Size = new System.Drawing.Size(126, 60);
            this.BackBtn3.TabIndex = 0;
            this.BackBtn3.Text = "BACK";
            this.BackBtn3.UseVisualStyleBackColor = false;
            this.BackBtn3.Click += new System.EventHandler(this.BackBtn3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(916, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 540);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // ClearBtn4
            // 
            this.ClearBtn4.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClearBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn4.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn4.Location = new System.Drawing.Point(1264, 749);
            this.ClearBtn4.Name = "ClearBtn4";
            this.ClearBtn4.Size = new System.Drawing.Size(137, 60);
            this.ClearBtn4.TabIndex = 4;
            this.ClearBtn4.Text = "CLEAR";
            this.ClearBtn4.UseVisualStyleBackColor = false;
            this.ClearBtn4.Click += new System.EventHandler(this.ClearBtn4_Click);
            // 
            // SearchTxt6
            // 
            this.SearchTxt6.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTxt6.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt6.ForeColor = System.Drawing.Color.Black;
            this.SearchTxt6.Location = new System.Drawing.Point(1092, 67);
            this.SearchTxt6.Name = "SearchTxt6";
            this.SearchTxt6.Size = new System.Drawing.Size(436, 43);
            this.SearchTxt6.TabIndex = 43;
            this.SearchTxt6.TextChanged += new System.EventHandler(this.SearchTxt6_TextChanged);
            // 
            // SearchLbl9
            // 
            this.SearchLbl9.AutoSize = true;
            this.SearchLbl9.BackColor = System.Drawing.Color.Transparent;
            this.SearchLbl9.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl9.ForeColor = System.Drawing.Color.Black;
            this.SearchLbl9.Image = ((System.Drawing.Image)(resources.GetObject("SearchLbl9.Image")));
            this.SearchLbl9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchLbl9.Location = new System.Drawing.Point(909, 70);
            this.SearchLbl9.Name = "SearchLbl9";
            this.SearchLbl9.Size = new System.Drawing.Size(155, 40);
            this.SearchLbl9.TabIndex = 42;
            this.SearchLbl9.Text = "      Search";
            this.SearchLbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLbl4
            // 
            this.StatusLbl4.AutoSize = true;
            this.StatusLbl4.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl4.Location = new System.Drawing.Point(53, 453);
            this.StatusLbl4.Name = "StatusLbl4";
            this.StatusLbl4.Size = new System.Drawing.Size(197, 34);
            this.StatusLbl4.TabIndex = 4;
            this.StatusLbl4.Text = "Category Status";
            // 
            // StatusCmboBx
            // 
            this.StatusCmboBx.FormattingEnabled = true;
            this.StatusCmboBx.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.StatusCmboBx.Location = new System.Drawing.Point(59, 515);
            this.StatusCmboBx.Name = "StatusCmboBx";
            this.StatusCmboBx.Size = new System.Drawing.Size(305, 44);
            this.StatusCmboBx.TabIndex = 5;
            this.StatusCmboBx.TextChanged += new System.EventHandler(this.StatusCmboBx_TextChanged);
            // 
            // CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1821, 1028);
            this.Controls.Add(this.SearchTxt6);
            this.Controls.Add(this.SearchLbl9);
            this.Controls.Add(this.ClearBtn4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn3);
            this.Controls.Add(this.UpdateBtn2);
            this.Controls.Add(this.SaveBtn1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CATEGORY";
            this.Text = "Category_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CATEGORY_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NameTxt1;
        private System.Windows.Forms.Label NameLbl3;
        private System.Windows.Forms.Label CatIdLbl1;
        private System.Windows.Forms.Label IdLbl2;
        private System.Windows.Forms.Button SaveBtn1;
        private System.Windows.Forms.Button UpdateBtn2;
        private System.Windows.Forms.Button BackBtn3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearBtn4;
        private System.Windows.Forms.TextBox SearchTxt6;
        private System.Windows.Forms.Label SearchLbl9;
        private System.Windows.Forms.ComboBox StatusCmboBx;
        private System.Windows.Forms.Label StatusLbl4;
    }
}