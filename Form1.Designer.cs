namespace License_Plate_Detection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Open_btn = new System.Windows.Forms.Button();
            this.Gray_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Otsu_btn = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 418);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(377, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(365, 418);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Open_btn
            // 
            this.Open_btn.Location = new System.Drawing.Point(922, 9);
            this.Open_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(82, 22);
            this.Open_btn.TabIndex = 2;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // Gray_btn
            // 
            this.Gray_btn.Location = new System.Drawing.Point(922, 35);
            this.Gray_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gray_btn.Name = "Gray_btn";
            this.Gray_btn.Size = new System.Drawing.Size(82, 22);
            this.Gray_btn.TabIndex = 3;
            this.Gray_btn.Text = "Gray";
            this.Gray_btn.UseVisualStyleBackColor = true;
            this.Gray_btn.Click += new System.EventHandler(this.Gray_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(747, 356);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(257, 71);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Otsu_btn
            // 
            this.Otsu_btn.Location = new System.Drawing.Point(922, 62);
            this.Otsu_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Otsu_btn.Name = "Otsu_btn";
            this.Otsu_btn.Size = new System.Drawing.Size(82, 26);
            this.Otsu_btn.TabIndex = 5;
            this.Otsu_btn.Text = "Otsu";
            this.Otsu_btn.UseVisualStyleBackColor = true;
            this.Otsu_btn.Click += new System.EventHandler(this.Otsu_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 444);
            this.Controls.Add(this.Otsu_btn);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Gray_btn);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Open_btn;
        private Button Gray_btn;
        private PictureBox pictureBox3;
        private Button Otsu_btn;
        private Emgu.CV.UI.HistogramBox histogramBox1;
    }
}