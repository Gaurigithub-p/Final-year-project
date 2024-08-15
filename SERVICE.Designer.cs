namespace Pet_salon
{
    partial class SERVICE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SERVICE));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.ServiceTxt = new System.Windows.Forms.TextBox();
            this.CatCombox = new System.Windows.Forms.ComboBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.ServiceLbl = new System.Windows.Forms.Label();
            this.SNameLbl = new System.Windows.Forms.Label();
            this.CatNameLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.SaveBtn1 = new System.Windows.Forms.Button();
            this.UpdateBtn2 = new System.Windows.Forms.Button();
            this.ClearBtn3 = new System.Windows.Forms.Button();
            this.BackBtn4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchTxt6 = new System.Windows.Forms.TextBox();
            this.SearchLbl9 = new System.Windows.Forms.Label();
            this.StatusCmboBx = new System.Windows.Forms.ComboBox();
            this.StatusLbl4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(370, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD SERVICES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.StatusCmboBx);
            this.groupBox1.Controls.Add(this.StatusLbl4);
            this.groupBox1.Controls.Add(this.PriceTxt);
            this.groupBox1.Controls.Add(this.ServiceTxt);
            this.groupBox1.Controls.Add(this.CatCombox);
            this.groupBox1.Controls.Add(this.PriceLbl);
            this.groupBox1.Controls.Add(this.ServiceLbl);
            this.groupBox1.Controls.Add(this.SNameLbl);
            this.groupBox1.Controls.Add(this.CatNameLbl);
            this.groupBox1.Controls.Add(this.IdLbl);
            this.groupBox1.Font = new System.Drawing.Font("Bodoni MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(193, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 596);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Info";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxt.Location = new System.Drawing.Point(301, 394);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(277, 40);
            this.PriceTxt.TabIndex = 8;
            this.PriceTxt.TextChanged += new System.EventHandler(this.PriceTxt_TextChanged);
            this.PriceTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceTxt_KeyDown);
            this.PriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTxt_KeyPress);
            this.PriceTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PriceTxt_KeyUp);
            // 
            // ServiceTxt
            // 
            this.ServiceTxt.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceTxt.Location = new System.Drawing.Point(301, 307);
            this.ServiceTxt.Name = "ServiceTxt";
            this.ServiceTxt.Size = new System.Drawing.Size(277, 40);
            this.ServiceTxt.TabIndex = 7;
            this.ServiceTxt.TextChanged += new System.EventHandler(this.ServiceTxt_TextChanged);
            this.ServiceTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ServiceTxt_KeyDown);
            this.ServiceTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ServiceTxt_KeyUp);
            // 
            // CatCombox
            // 
            this.CatCombox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CatCombox.Font = new System.Drawing.Font("Bodoni MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCombox.FormattingEnabled = true;
            this.CatCombox.Location = new System.Drawing.Point(301, 113);
            this.CatCombox.Name = "CatCombox";
            this.CatCombox.Size = new System.Drawing.Size(277, 40);
            this.CatCombox.TabIndex = 6;
            this.CatCombox.SelectedIndexChanged += new System.EventHandler(this.CatCombox_SelectedIndexChanged);
            this.CatCombox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatCombox_KeyDown);
            this.CatCombox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CatCombox_KeyPress);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(57, 394);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(78, 36);
            this.PriceLbl.TabIndex = 5;
            this.PriceLbl.Text = "Price";
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLbl.Location = new System.Drawing.Point(57, 213);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(135, 36);
            this.ServiceLbl.TabIndex = 2;
            this.ServiceLbl.Text = "Service Id";
            // 
            // SNameLbl
            // 
            this.SNameLbl.AutoSize = true;
            this.SNameLbl.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNameLbl.Location = new System.Drawing.Point(57, 307);
            this.SNameLbl.Name = "SNameLbl";
            this.SNameLbl.Size = new System.Drawing.Size(180, 36);
            this.SNameLbl.TabIndex = 4;
            this.SNameLbl.Text = "Service Name";
            // 
            // CatNameLbl
            // 
            this.CatNameLbl.AutoSize = true;
            this.CatNameLbl.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameLbl.Location = new System.Drawing.Point(57, 113);
            this.CatNameLbl.Name = "CatNameLbl";
            this.CatNameLbl.Size = new System.Drawing.Size(203, 36);
            this.CatNameLbl.TabIndex = 0;
            this.CatNameLbl.Text = "Category Name";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.Location = new System.Drawing.Point(305, 213);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(47, 36);
            this.IdLbl.TabIndex = 3;
            this.IdLbl.Text = "....";
            // 
            // SaveBtn1
            // 
            this.SaveBtn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn1.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn1.Location = new System.Drawing.Point(169, 826);
            this.SaveBtn1.Name = "SaveBtn1";
            this.SaveBtn1.Size = new System.Drawing.Size(134, 58);
            this.SaveBtn1.TabIndex = 2;
            this.SaveBtn1.Text = "SAVE";
            this.SaveBtn1.UseVisualStyleBackColor = false;
            this.SaveBtn1.Click += new System.EventHandler(this.SaveBtn1_Click);
            // 
            // UpdateBtn2
            // 
            this.UpdateBtn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn2.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn2.Location = new System.Drawing.Point(347, 826);
            this.UpdateBtn2.Name = "UpdateBtn2";
            this.UpdateBtn2.Size = new System.Drawing.Size(179, 58);
            this.UpdateBtn2.TabIndex = 3;
            this.UpdateBtn2.Text = "UPDATE";
            this.UpdateBtn2.UseVisualStyleBackColor = false;
            this.UpdateBtn2.Click += new System.EventHandler(this.UpdateBtn2_Click);
            // 
            // ClearBtn3
            // 
            this.ClearBtn3.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClearBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn3.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn3.Location = new System.Drawing.Point(573, 826);
            this.ClearBtn3.Name = "ClearBtn3";
            this.ClearBtn3.Size = new System.Drawing.Size(150, 58);
            this.ClearBtn3.TabIndex = 4;
            this.ClearBtn3.Text = "CLEAR";
            this.ClearBtn3.UseVisualStyleBackColor = false;
            this.ClearBtn3.Click += new System.EventHandler(this.ClearBtn3_Click);
            // 
            // BackBtn4
            // 
            this.BackBtn4.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn4.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn4.Location = new System.Drawing.Point(763, 826);
            this.BackBtn4.Name = "BackBtn4";
            this.BackBtn4.Size = new System.Drawing.Size(142, 58);
            this.BackBtn4.TabIndex = 5;
            this.BackBtn4.Text = "BACK";
            this.BackBtn4.UseVisualStyleBackColor = false;
            this.BackBtn4.Click += new System.EventHandler(this.BackBtn4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(965, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 736);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // SearchTxt6
            // 
            this.SearchTxt6.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTxt6.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt6.ForeColor = System.Drawing.Color.Black;
            this.SearchTxt6.Location = new System.Drawing.Point(1141, 116);
            this.SearchTxt6.Name = "SearchTxt6";
            this.SearchTxt6.Size = new System.Drawing.Size(479, 43);
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
            this.SearchLbl9.Location = new System.Drawing.Point(958, 119);
            this.SearchLbl9.Name = "SearchLbl9";
            this.SearchLbl9.Size = new System.Drawing.Size(155, 40);
            this.SearchLbl9.TabIndex = 42;
            this.SearchLbl9.Text = "      Search";
            this.SearchLbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusCmboBx
            // 
            this.StatusCmboBx.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.StatusCmboBx.FormattingEnabled = true;
            this.StatusCmboBx.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.StatusCmboBx.Location = new System.Drawing.Point(301, 478);
            this.StatusCmboBx.Name = "StatusCmboBx";
            this.StatusCmboBx.Size = new System.Drawing.Size(277, 40);
            this.StatusCmboBx.TabIndex = 10;
            this.StatusCmboBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatusCmboBx_KeyDown);
            this.StatusCmboBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StatusCmboBx_KeyPress);
            this.StatusCmboBx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StatusCmboBx_KeyUp);
            // 
            // StatusLbl4
            // 
            this.StatusLbl4.AutoSize = true;
            this.StatusLbl4.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl4.Location = new System.Drawing.Point(57, 484);
            this.StatusLbl4.Name = "StatusLbl4";
            this.StatusLbl4.Size = new System.Drawing.Size(176, 34);
            this.StatusLbl4.TabIndex = 9;
            this.StatusLbl4.Text = "Service Status";
            // 
            // SERVICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1910, 993);
            this.Controls.Add(this.SearchTxt6);
            this.Controls.Add(this.SearchLbl9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn4);
            this.Controls.Add(this.ClearBtn3);
            this.Controls.Add(this.UpdateBtn2);
            this.Controls.Add(this.SaveBtn1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SERVICE";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SERVICE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CatNameLbl;
        private System.Windows.Forms.Label ServiceLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label SNameLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.TextBox ServiceTxt;
        private System.Windows.Forms.ComboBox CatCombox;
        private System.Windows.Forms.Button SaveBtn1;
        private System.Windows.Forms.Button UpdateBtn2;
        private System.Windows.Forms.Button ClearBtn3;
        private System.Windows.Forms.Button BackBtn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchTxt6;
        private System.Windows.Forms.Label SearchLbl9;
        private System.Windows.Forms.ComboBox StatusCmboBx;
        private System.Windows.Forms.Label StatusLbl4;
    }
}