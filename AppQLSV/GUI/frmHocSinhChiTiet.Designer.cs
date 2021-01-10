namespace AppQLSV
{
    partial class frmHocSinhChiTiet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDBOther = new System.Windows.Forms.RadioButton();
            this.RDBNu = new System.Windows.Forms.RadioButton();
            this.RDBNam = new System.Windows.Forms.RadioButton();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.CBBoxLopHoc = new System.Windows.Forms.ComboBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.DTPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDBOther);
            this.groupBox1.Controls.Add(this.RDBNu);
            this.groupBox1.Controls.Add(this.RDBNam);
            this.groupBox1.Controls.Add(this.btnCancle);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.CBBoxLopHoc);
            this.groupBox1.Controls.Add(this.txtNoiSinh);
            this.groupBox1.Controls.Add(this.DTPNgaySinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Location = new System.Drawing.Point(34, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // RDBOther
            // 
            this.RDBOther.AutoSize = true;
            this.RDBOther.Location = new System.Drawing.Point(554, 267);
            this.RDBOther.Name = "RDBOther";
            this.RDBOther.Size = new System.Drawing.Size(61, 21);
            this.RDBOther.TabIndex = 0;
            this.RDBOther.Text = "Khác";
            this.RDBOther.UseVisualStyleBackColor = true;
            // 
            // RDBNu
            // 
            this.RDBNu.AutoSize = true;
            this.RDBNu.Location = new System.Drawing.Point(501, 267);
            this.RDBNu.Name = "RDBNu";
            this.RDBNu.Size = new System.Drawing.Size(47, 21);
            this.RDBNu.TabIndex = 8;
            this.RDBNu.Text = "Nữ";
            this.RDBNu.UseVisualStyleBackColor = true;
            // 
            // RDBNam
            // 
            this.RDBNam.AutoSize = true;
            this.RDBNam.Checked = true;
            this.RDBNam.Location = new System.Drawing.Point(437, 267);
            this.RDBNam.Name = "RDBNam";
            this.RDBNam.Size = new System.Drawing.Size(58, 21);
            this.RDBNam.TabIndex = 7;
            this.RDBNam.TabStop = true;
            this.RDBNam.Text = "Nam";
            this.RDBNam.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(580, 322);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(97, 40);
            this.btnCancle.TabIndex = 10;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(437, 322);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 40);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm sinh viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBBoxLopHoc
            // 
            this.CBBoxLopHoc.FormattingEnabled = true;
            this.CBBoxLopHoc.Location = new System.Drawing.Point(150, 260);
            this.CBBoxLopHoc.Name = "CBBoxLopHoc";
            this.CBBoxLopHoc.Size = new System.Drawing.Size(121, 24);
            this.CBBoxLopHoc.TabIndex = 5;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(150, 187);
            this.txtNoiSinh.Multiline = true;
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(485, 50);
            this.txtNoiSinh.TabIndex = 4;
            // 
            // DTPNgaySinh
            // 
            this.DTPNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.DTPNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPNgaySinh.Location = new System.Drawing.Point(150, 138);
            this.DTPNgaySinh.Name = "DTPNgaySinh";
            this.DTPNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.DTPNgaySinh.TabIndex = 3;
            this.DTPNgaySinh.Value = new System.DateTime(1999, 11, 19, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lớp học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nơi sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Họ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Sinh viên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(525, 87);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(119, 22);
            this.txtTen.TabIndex = 2;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(150, 87);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(274, 22);
            this.txtHo.TabIndex = 1;
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(150, 36);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(162, 22);
            this.txtMSV.TabIndex = 0;
            this.txtMSV.TextChanged += new System.EventHandler(this.txtMSV_TextChanged);
            // 
            // frmHocSinhChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(792, 452);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHocSinhChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmHocSinhChiTiet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTPNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBBoxLopHoc;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RDBOther;
        private System.Windows.Forms.RadioButton RDBNu;
        private System.Windows.Forms.RadioButton RDBNam;
    }
}