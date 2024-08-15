namespace Pet_salon
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackBtn4 = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Bodoni MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(177, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BILL LIST";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // BackBtn4
            // 
            this.BackBtn4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn4.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn4.ForeColor = System.Drawing.Color.Black;
            this.BackBtn4.Location = new System.Drawing.Point(635, 730);
            this.BackBtn4.Name = "BackBtn4";
            this.BackBtn4.Size = new System.Drawing.Size(148, 57);
            this.BackBtn4.TabIndex = 36;
            this.BackBtn4.Text = "BACK";
            this.BackBtn4.UseVisualStyleBackColor = false;
            this.BackBtn4.Click += new System.EventHandler(this.BackBtn4_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTxt.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt.ForeColor = System.Drawing.Color.Black;
            this.SearchTxt.Location = new System.Drawing.Point(492, 66);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(513, 43);
            this.SearchTxt.TabIndex = 45;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.BackColor = System.Drawing.Color.Transparent;
            this.SearchLbl.Font = new System.Drawing.Font("Bodoni MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl.ForeColor = System.Drawing.Color.Black;
            this.SearchLbl.Image = ((System.Drawing.Image)(resources.GetObject("SearchLbl.Image")));
            this.SearchLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchLbl.Location = new System.Drawing.Point(316, 66);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(155, 40);
            this.SearchLbl.TabIndex = 44;
            this.SearchLbl.Text = "      Search";
            this.SearchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1346, 787);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.BackBtn4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bill";
            this.Text = "Bill_List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bill_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BackBtn4;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label SearchLbl;
    }
}