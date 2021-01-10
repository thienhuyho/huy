namespace AppQLSV.GUI
{
    partial class frmLopChiTiet
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
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblPhongHoc = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtPhongHoc = new System.Windows.Forms.TextBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(45, 35);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(56, 17);
            this.lblTenLop.TabIndex = 0;
            this.lblTenLop.Text = "Tên lớp";
            // 
            // lblPhongHoc
            // 
            this.lblPhongHoc.AutoSize = true;
            this.lblPhongHoc.Location = new System.Drawing.Point(45, 82);
            this.lblPhongHoc.Name = "lblPhongHoc";
            this.lblPhongHoc.Size = new System.Drawing.Size(76, 17);
            this.lblPhongHoc.TabIndex = 0;
            this.lblPhongHoc.Text = "Phòng học";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLop.Location = new System.Drawing.Point(162, 35);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(400, 22);
            this.txtTenLop.TabIndex = 0;
            // 
            // txtPhongHoc
            // 
            this.txtPhongHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhongHoc.Location = new System.Drawing.Point(162, 77);
            this.txtPhongHoc.Name = "txtPhongHoc";
            this.txtPhongHoc.Size = new System.Drawing.Size(400, 22);
            this.txtPhongHoc.TabIndex = 1;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.Location = new System.Drawing.Point(375, 133);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(91, 38);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.Location = new System.Drawing.Point(482, 133);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(80, 38);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // frmLopChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(600, 199);
            this.ControlBox = false;
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.txtPhongHoc);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.lblPhongHoc);
            this.Controls.Add(this.lblTenLop);
            this.Name = "frmLopChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm hoặc sửa lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblPhongHoc;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtPhongHoc;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDongY;
    }
}