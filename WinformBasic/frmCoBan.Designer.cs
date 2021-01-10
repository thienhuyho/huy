namespace WinformBasic
{
    partial class frmCoBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoBan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình tính toán cơ bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(75, 71);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(270, 20);
            this.txtA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "B:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(75, 97);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(270, 20);
            this.txtB.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformBasic.Properties.Resources.math;
            this.pictureBox1.Location = new System.Drawing.Point(371, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnTru
            // 
            this.btnTru.Image = global::WinformBasic.Properties.Resources.minus20;
            this.btnTru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTru.Location = new System.Drawing.Point(211, 123);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(76, 36);
            this.btnTru.TabIndex = 3;
            this.btnTru.Text = "Trừ";
            this.btnTru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTru.UseVisualStyleBackColor = true;
            // 
            // btnCong
            // 
            this.btnCong.Image = global::WinformBasic.Properties.Resources.plus20;
            this.btnCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCong.Location = new System.Drawing.Point(145, 123);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(66, 36);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "Cộng";
            this.btnCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // frmCoBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 173);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCoBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính toán cơ bản";
            this.Load += new System.EventHandler(this.frmCoBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

