using AppQLSV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV.GUI
{
    public partial class frmLopChiTiet : Form
    {
        ClassRoomViewModel lopHoc;
        public frmLopChiTiet()
        {   //thêm mới
            InitializeComponent();
            this.Text = "Thêm mới lớp học";
        }
        public frmLopChiTiet(ClassRoomViewModel lopHoc)
        {
            //chỉnh sửa
            InitializeComponent();
            this.lopHoc = lopHoc;
            this.Text = "Chỉnh sửa lớp học";
            txtPhongHoc.Text = this.lopHoc.Room;
            txtTenLop.Text = this.lopHoc.Name;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var TenLop = txtTenLop.Text;
            var PhongHoc = txtPhongHoc.Text;
            if (this.lopHoc == null)
            {
            
                //thêm lớp

                var lop = new Classroom
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = TenLop,
                    Room = PhongHoc
                };
                var db = new AppQLSVDBContext();
                try
                {
                    db.Classrooms.Add(lop);
                    db.SaveChanges();
                    //nếu thêm thành công thì 
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ nội dung");
                }

              

            }
            else
            {
                var db = new AppQLSVDBContext();
                var lop = db.Classrooms.Where(v => v.ID == lopHoc.ID).FirstOrDefault();
                try
                {
                    lop.Name = TenLop;
                    lop.Room = PhongHoc;
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                }
                   
                
            }
         
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            
        }
    }
}
