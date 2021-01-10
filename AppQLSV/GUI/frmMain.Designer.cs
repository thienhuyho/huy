namespace AppQLSV
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.gridLopHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnSuaLop = new System.Windows.Forms.ToolStripButton();
            this.btnThemLop = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridSinhVien = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnXoaHocSinh = new System.Windows.Forms.ToolStripButton();
            this.btnSuaHocSinh = new System.Windows.Forms.ToolStripButton();
            this.btnThemHocSinh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.BDSLopHoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHoc)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSinhVien)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDSLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.Controls.Add(this.gridLopHoc);
            this.PanelLeft.Controls.Add(this.toolStrip2);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(641, 559);
            this.PanelLeft.TabIndex = 0;
            // 
            // gridLopHoc
            // 
            this.gridLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.TongNam,
            this.TongNu,
            this.Column9});
            this.gridLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLopHoc.Location = new System.Drawing.Point(0, 31);
            this.gridLopHoc.Name = "gridLopHoc";
            this.gridLopHoc.RowHeadersWidth = 51;
            this.gridLopHoc.RowTemplate.Height = 24;
            this.gridLopHoc.Size = new System.Drawing.Size(641, 528);
            this.gridLopHoc.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên Lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room";
            this.Column2.HeaderText = "Phòng Học";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // TongNam
            // 
            this.TongNam.DataPropertyName = "TongNam";
            this.TongNam.HeaderText = "Tong Nam";
            this.TongNam.MinimumWidth = 6;
            this.TongNam.Name = "TongNam";
            this.TongNam.Width = 60;
            // 
            // TongNu
            // 
            this.TongNu.DataPropertyName = "TongNu";
            this.TongNu.HeaderText = "TongNu";
            this.TongNu.MinimumWidth = 6;
            this.TongNu.Name = "TongNu";
            this.TongNu.Width = 60;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TotalStudent";
            this.Column9.HeaderText = "TSSV";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 60;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnSuaLop,
            this.btnThemLop,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(641, 31);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 28);
            this.toolStripButton1.Text = "Xóa";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaLop.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLop.Image")));
            this.btnSuaLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(58, 24);
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemLop.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLop.Image")));
            this.btnThemLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(70, 24);
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(131, 24);
            this.toolStripLabel1.Text = "Danh sách lớp học";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridSinhVien);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(641, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 559);
            this.panel1.TabIndex = 1;
            // 
            // GridSinhVien
            // 
            this.GridSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8});
            this.GridSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSinhVien.Location = new System.Drawing.Point(0, 31);
            this.GridSinhVien.Name = "GridSinhVien";
            this.GridSinhVien.RowHeadersWidth = 51;
            this.GridSinhVien.RowTemplate.Height = 24;
            this.GridSinhVien.Size = new System.Drawing.Size(841, 528);
            this.GridSinhVien.TabIndex = 0;
            this.GridSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ID";
            this.Column3.HeaderText = "Mã Sinh viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FullName";
            this.Column4.HeaderText = "Họ Tên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DateOfBirth";
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PlaceOfBirth";
            this.Column7.HeaderText = "Nơi Sinh";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "GenderString";
            this.Column8.HeaderText = "Giới Tính";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoaHocSinh,
            this.btnSuaHocSinh,
            this.btnThemHocSinh,
            this.toolStripLabel2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(841, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnXoaHocSinh
            // 
            this.btnXoaHocSinh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHocSinh.Image")));
            this.btnXoaHocSinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaHocSinh.Name = "btnXoaHocSinh";
            this.btnXoaHocSinh.Size = new System.Drawing.Size(59, 24);
            this.btnXoaHocSinh.Text = "Xóa";
            this.btnXoaHocSinh.Click += new System.EventHandler(this.btnXoaHocSinh_Click);
            // 
            // btnSuaHocSinh
            // 
            this.btnSuaHocSinh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHocSinh.Image")));
            this.btnSuaHocSinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaHocSinh.Name = "btnSuaHocSinh";
            this.btnSuaHocSinh.Size = new System.Drawing.Size(58, 24);
            this.btnSuaHocSinh.Text = "Sửa";
            this.btnSuaHocSinh.Click += new System.EventHandler(this.btnSuaHocSinh_Click);
            // 
            // btnThemHocSinh
            // 
            this.btnThemHocSinh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHocSinh.Image")));
            this.btnThemHocSinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemHocSinh.Name = "btnThemHocSinh";
            this.btnThemHocSinh.Size = new System.Drawing.Size(70, 24);
            this.btnThemHocSinh.Text = "Thêm";
            this.btnThemHocSinh.Click += new System.EventHandler(this.btnThemHocSinh_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(138, 24);
            this.toolStripLabel2.Text = "Danh sách sinh viên";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(115, 24);
            this.toolStripButton2.Text = "Thêm từ File";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // BDSLopHoc
            // 
            this.BDSLopHoc.CurrentChanged += new System.EventHandler(this.BDSLopHoc_CurrentChanged);
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.CurrentChanged += new System.EventHandler(this.bdsSinhVien_CurrentChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelLeft);
            this.MaximumSize = new System.Drawing.Size(1800, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHoc)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSinhVien)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDSLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridLopHoc;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnSuaLop;
        private System.Windows.Forms.ToolStripButton btnThemLop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView GridSinhVien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnXoaHocSinh;
        private System.Windows.Forms.ToolStripButton btnSuaHocSinh;
        private System.Windows.Forms.ToolStripButton btnThemHocSinh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.BindingSource BDSLopHoc;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

