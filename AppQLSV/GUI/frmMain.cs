using AppQLSV.DAL;
using AppQLSV.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            gridLopHoc.AutoGenerateColumns = false;
            GridSinhVien.AutoGenerateColumns = false;
            DanhSachLopHoc();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            var f = new frmLopChiTiet();
            if (f.ShowDialog() == DialogResult.OK)
            {
                DanhSachLopHoc();
            }
        }

        private void DanhSachLopHoc()
        {
            AppQLSVDBContext db = new AppQLSVDBContext();
            var ls = db.Classrooms.Select(e=> new ClassRoomViewModel
            {
                ID = e.ID,
                Name = e.Name,
                Room = e.Room,
                TotalStudent = e.Students.Count,
                TongNam = e.Students.Where(l=>l.Gender == 1).Count(),
                TongNu = e.Students.Where(l => l.Gender == 0).Count()

            }).OrderBy(e => e.Name).ToList();

            BDSLopHoc.DataSource = ls;
            gridLopHoc.DataSource = BDSLopHoc;


        }
        private void DanhSachSinhVien()
        {
            AppQLSVDBContext db = new AppQLSVDBContext();
            var ls = db.Students.ToList();
            bdsSinhVien.DataSource = ls;
            GridSinhVien.DataSource = bdsSinhVien;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var LopDangChon = BDSLopHoc.Current as ClassRoomViewModel;
            if (LopDangChon != null)
            {
               var rs =   MessageBox.Show("Bạn có thực sự muốn xóa không? ",
                                            "chú ý",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning);
                if(rs== DialogResult.OK)
                {
                    //Xóa lớp đang chọn
                    AppQLSVDBContext db = new AppQLSVDBContext();
                    var lop = db.Classrooms.Where(t => t.ID == LopDangChon.ID).FirstOrDefault();
                    if (lop != null)
                    {
                        
                        var HocSinh = db.Students.Where(t => t.IDClassroom == lop.ID);
                        foreach(Student student in HocSinh)
                        {
                            db.Students.Remove(student);
                        }
                      
                        db.Classrooms.Remove(lop);
                        db.SaveChanges();
                        DanhSachLopHoc();
                    }
                }

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BDSLopHoc_CurrentChanged(object sender, EventArgs e)
        {
            var LopDangChon = BDSLopHoc.Current as ClassRoomViewModel;
            if (LopDangChon != null)
            {
                var db = new AppQLSVDBContext();
                var dsSv = db.Students.Where(h => h.IDClassroom == LopDangChon.ID).ToList();

                //.Select(t => new
                // {
                //     IDClassroom = t.IDClassroom,
                //     HoTen = $"{t.FirstName} {t.LastName}"
                // }
                //)

                bdsSinhVien.DataSource = dsSv;
                GridSinhVien.DataSource = bdsSinhVien;
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            var lopDangChon = BDSLopHoc.Current as ClassRoomViewModel;
            if (lopDangChon != null)
            {
                var f = new frmLopChiTiet(lopDangChon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DanhSachLopHoc();
                }
            }
          
        }

        private void bdsSinhVien_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
            var LopDuocChon = BDSLopHoc.Current as ClassRoomViewModel;
            String ID = LopDuocChon.ID;
            var f = new frmHocSinhChiTiet(ID);
            if (f.ShowDialog() == DialogResult.OK)
            {
                DanhSachLopHoc();
            }

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSuaHocSinh_Click(object sender, EventArgs e)
        {
            var HocSinhDangChon = bdsSinhVien.Current as Student;
            if (HocSinhDangChon.ID != null)
            {
                var f = new frmHocSinhChiTiet(HocSinhDangChon);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DanhSachLopHoc();
                }
            }
          
            
        }

        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            var HocSinhDangChon = bdsSinhVien.Current as Student;
            if (HocSinhDangChon != null)
            {
               var rs= MessageBox.Show("Bạn có muốn xóa sinh viên này không ?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ;
               if(rs == DialogResult.OK)
                {
                    var db = new AppQLSVDBContext();
                    var Student = db.Students.Where(t => t.ID == HocSinhDangChon.ID).FirstOrDefault();
                    if(Student!=null)
                    db.Students.Remove(Student);
                    db.SaveChanges();
                    DanhSachLopHoc();
                }
               
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var LopDuocChon = BDSLopHoc.Current as ClassRoomViewModel;
            String ID = LopDuocChon.ID;
            var f = new frmEcxel(ID);
            if(f.ShowDialog() == DialogResult.OK)
            {
                DanhSachLopHoc();
            }
         
        }
    }
}
