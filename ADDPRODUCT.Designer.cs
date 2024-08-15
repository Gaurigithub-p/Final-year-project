namespace Pet_salon
{
    partial class ADDPRODUCT
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
            this.label1 = new System.Windows.Forms.Label();
            this.PBrandLbl1 = new System.Windows.Forms.Label();
            this.QuantityLbl4 = new System.Windows.Forms.Label();
            this.PriceLbl5 = new System.Windows.Forms.Label();
            this.PriceTxt1 = new System.Windows.Forms.TextBox();
            this.PBrandCmboBx1 = new System.Windows.Forms.ComboBox();
            this.ClearBtn3 = new System.Windows.Forms.Button();
            this.SaveBtn1 = new System.Windows.Forms.Button();
            this.UpdateBtn2 = new System.Windows.Forms.Button();
            this.BackBtn4 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.PNameLbl6 = new System.Windows.Forms.Label();
            this.PNameTxt2 = new System.Windows.Forms.TextBox();
            this.SNameLbl7 = new System.Windows.Forms.Label();
            this.SNameTxt3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(631, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT DETAILS (FOOD)";
            // 
            // PBrandLbl1
            // 
            this.PBrandLbl1.AutoSize = true;
            this.PBrandLbl1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBrandLbl1.Location = new System.Drawing.Point(194, 184);
            this.PBrandLbl1.Name = "PBrandLbl1";
            this.PBrandLbl1.Size = new System.Drawing.Size(196, 36);
            this.PBrandLbl1.TabIndex = 1;
            this.PBrandLbl1.Text = "Product Brand";
            // 
            // QuantityLbl4
            // 
            this.QuantityLbl4.AutoSize = true;
            this.QuantityLbl4.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl4.Location = new System.Drawing.Point(194, 507);
            this.QuantityLbl4.Name = "QuantityLbl4";
            this.QuantityLbl4.Size = new System.Drawing.Size(124, 36);
            this.QuantityLbl4.TabIndex = 4;
            this.QuantityLbl4.Text = "Quantity";
            // 
            // PriceLbl5
            // 
            this.PriceLbl5.AutoSize = true;
            this.PriceLbl5.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl5.Location = new System.Drawing.Point(194, 573);
            this.PriceLbl5.Name = "PriceLbl5";
            this.PriceLbl5.Size = new System.Drawing.Size(78, 36);
            this.PriceLbl5.TabIndex = 5;
            this.PriceLbl5.Text = "Price";
            // 
            // PriceTxt1
            // 
            this.PriceTxt1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxt1.Location = new System.Drawing.Point(537, 585);
            this.PriceTxt1.Name = "PriceTxt1";
            this.PriceTxt1.Size = new System.Drawing.Size(229, 40);
            this.PriceTxt1.TabIndex = 9;
            this.PriceTxt1.TextChanged += new System.EventHandler(this.PriceTxt1_TextChanged);
            this.PriceTxt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTxt1_KeyPress);
            // 
            // PBrandCmboBx1
            // 
            this.PBrandCmboBx1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PBrandCmboBx1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBrandCmboBx1.FormattingEnabled = true;
            this.PBrandCmboBx1.Items.AddRange(new object[] {
            "ROYAL CANIN",
            "IAMS",
            "SUPERCOAT",
            "N&D"});
            this.PBrandCmboBx1.Location = new System.Drawing.Point(537, 181);
            this.PBrandCmboBx1.Name = "PBrandCmboBx1";
            this.PBrandCmboBx1.Size = new System.Drawing.Size(229, 40);
            this.PBrandCmboBx1.TabIndex = 10;
            this.PBrandCmboBx1.TextChanged += new System.EventHandler(this.PBrandCmboBx1_TextChanged);
            // 
            // ClearBtn3
            // 
            this.ClearBtn3.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClearBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn3.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn3.Location = new System.Drawing.Point(1392, 710);
            this.ClearBtn3.Name = "ClearBtn3";
            this.ClearBtn3.Size = new System.Drawing.Size(147, 57);
            this.ClearBtn3.TabIndex = 11;
            this.ClearBtn3.Text = "CLEAR";
            this.ClearBtn3.UseVisualStyleBackColor = false;
            this.ClearBtn3.Click += new System.EventHandler(this.ClearBtn3_Click);
            // 
            // SaveBtn1
            // 
            this.SaveBtn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn1.Location = new System.Drawing.Point(968, 710);
            this.SaveBtn1.Name = "SaveBtn1";
            this.SaveBtn1.Size = new System.Drawing.Size(147, 57);
            this.SaveBtn1.TabIndex = 12;
            this.SaveBtn1.Text = "SAVE";
            this.SaveBtn1.UseVisualStyleBackColor = false;
            this.SaveBtn1.Click += new System.EventHandler(this.SaveBtn1_Click);
            // 
            // UpdateBtn2
            // 
            this.UpdateBtn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn2.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn2.Location = new System.Drawing.Point(1174, 710);
            this.UpdateBtn2.Name = "UpdateBtn2";
            this.UpdateBtn2.Size = new System.Drawing.Size(174, 57);
            this.UpdateBtn2.TabIndex = 13;
            this.UpdateBtn2.Text = "UPDATE";
            this.UpdateBtn2.UseVisualStyleBackColor = false;
            this.UpdateBtn2.Click += new System.EventHandler(this.UpdateBtn2_Click);
            // 
            // BackBtn4
            // 
            this.BackBtn4.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn4.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn4.ForeColor = System.Drawing.Color.Black;
            this.BackBtn4.Location = new System.Drawing.Point(1591, 710);
            this.BackBtn4.Name = "BackBtn4";
            this.BackBtn4.Size = new System.Drawing.Size(151, 57);
            this.BackBtn4.TabIndex = 27;
            this.BackBtn4.Text = "BACK";
            this.BackBtn4.UseVisualStyleBackColor = false;
            this.BackBtn4.Click += new System.EventHandler(this.BackBtn4_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(866, 181);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(987, 483);
            this.DataGridView1.TabIndex = 28;
            this.DataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter_1);
            // 
            // PNameLbl6
            // 
            this.PNameLbl6.AutoSize = true;
            this.PNameLbl6.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNameLbl6.Location = new System.Drawing.Point(194, 248);
            this.PNameLbl6.Name = "PNameLbl6";
            this.PNameLbl6.Size = new System.Drawing.Size(146, 36);
            this.PNameLbl6.TabIndex = 29;
            this.PNameLbl6.Text = "Product Id";
            // 
            // PNameTxt2
            // 
            this.PNameTxt2.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNameTxt2.Location = new System.Drawing.Point(537, 241);
            this.PNameTxt2.Name = "PNameTxt2";
            this.PNameTxt2.Size = new System.Drawing.Size(229, 40);
            this.PNameTxt2.TabIndex = 30;
            this.PNameTxt2.TextChanged += new System.EventHandler(this.PNameTxt2_TextChanged);
            this.PNameTxt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PNameTxt2_KeyPress);
            // 
            // SNameLbl7
            // 
            this.SNameLbl7.AutoSize = true;
            this.SNameLbl7.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNameLbl7.Location = new System.Drawing.Point(196, 309);
            this.SNameLbl7.Name = "SNameLbl7";
            this.SNameLbl7.Size = new System.Drawing.Size(194, 36);
            this.SNameLbl7.TabIndex = 31;
            this.SNameLbl7.Text = "Supplier Name";
            // 
            // SNameTxt3
            // 
            this.SNameTxt3.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNameTxt3.Location = new System.Drawing.Point(537, 309);
            this.SNameTxt3.Name = "SNameTxt3";
            this.SNameTxt3.Size = new System.Drawing.Size(229, 40);
            this.SNameTxt3.TabIndex = 32;
            this.SNameTxt3.TextChanged += new System.EventHandler(this.SNameTxt3_TextChanged);
            this.SNameTxt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SNameTxt3_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(537, 507);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 40);
            this.textBox1.TabIndex = 33;
            // 
            // ADDPRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 865);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SNameTxt3);
            this.Controls.Add(this.SNameLbl7);
            this.Controls.Add(this.PNameTxt2);
            this.Controls.Add(this.PNameLbl6);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.BackBtn4);
            this.Controls.Add(this.UpdateBtn2);
            this.Controls.Add(this.SaveBtn1);
            this.Controls.Add(this.ClearBtn3);
            this.Controls.Add(this.PBrandCmboBx1);
            this.Controls.Add(this.PriceTxt1);
            this.Controls.Add(this.PriceLbl5);
            this.Controls.Add(this.QuantityLbl4);
            this.Controls.Add(this.PBrandLbl1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDPRODUCT";
            this.Text = "Add_Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ADDPRODUCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PBrandLbl1;
        private System.Windows.Forms.Label QuantityLbl4;
        private System.Windows.Forms.Label PriceLbl5;
        private System.Windows.Forms.TextBox PriceTxt1;
        private System.Windows.Forms.ComboBox PBrandCmboBx1;
        private System.Windows.Forms.Button ClearBtn3;
        private System.Windows.Forms.Button SaveBtn1;
        private System.Windows.Forms.Button UpdateBtn2;
        private System.Windows.Forms.Button BackBtn4;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label PNameLbl6;
        private System.Windows.Forms.TextBox PNameTxt2;
        private System.Windows.Forms.Label SNameLbl7;
        private System.Windows.Forms.TextBox SNameTxt3;
        private System.Windows.Forms.TextBox textBox1;
    }
}