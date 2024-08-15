namespace Pet_salon
{
    partial class APPOINMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APPOINMENT));
            this.BoardBtn1 = new System.Windows.Forms.Button();
            this.GroomBtn1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BoardBtn1
            // 
            this.BoardBtn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BoardBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoardBtn1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardBtn1.ForeColor = System.Drawing.Color.Navy;
            this.BoardBtn1.Location = new System.Drawing.Point(1176, 516);
            this.BoardBtn1.Name = "BoardBtn1";
            this.BoardBtn1.Size = new System.Drawing.Size(264, 59);
            this.BoardBtn1.TabIndex = 1;
            this.BoardBtn1.Text = "BOARDING";
            this.BoardBtn1.UseVisualStyleBackColor = false;
            this.BoardBtn1.Click += new System.EventHandler(this.BoardBtn1_Click);
            // 
            // GroomBtn1
            // 
            this.GroomBtn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GroomBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroomBtn1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroomBtn1.ForeColor = System.Drawing.Color.Navy;
            this.GroomBtn1.Location = new System.Drawing.Point(627, 516);
            this.GroomBtn1.Name = "GroomBtn1";
            this.GroomBtn1.Size = new System.Drawing.Size(288, 59);
            this.GroomBtn1.TabIndex = 0;
            this.GroomBtn1.Text = "GROOMING";
            this.GroomBtn1.UseVisualStyleBackColor = false;
            this.GroomBtn1.Click += new System.EventHandler(this.GroomBtn1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1176, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // APPOINMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 732);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BoardBtn1);
            this.Controls.Add(this.GroomBtn1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "APPOINMENT";
            this.Text = "Appoinment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.APPOINMENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BoardBtn1;
        private System.Windows.Forms.Button GroomBtn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}