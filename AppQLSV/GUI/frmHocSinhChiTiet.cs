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

namespace AppQLSV
{
    public partial class frmHocSinhChiTiet : Form
    {
        Student student;
        String IDClass;
        public frmHocSinhChiTiet(String id)
        {
            InitializeComponent();
            this.IDClass = id;
            LoadLopHoc();
        }
        public frmHocSinhChiTiet(Student Student)
        {
            InitializeComponent();
            txtMSV.ReadOnly = true;
            this.student = Student;
                txtMSV.Text = Student.ID;
                txtHo.Text = Student.FirstName;
                txtTen.Text = Student.LastName;
                txtNoiSinh.Text = Student.PlaceOfBirth;
                DTPNgaySinh.Value = (DateTime)Student.DateOfBirth;

                switch (Student.Gender)
                {
                    case (1):
                        RDBNam.Checked = true;
                        break;
                    case (0):
                        RDBNu.Checked = true;
                        break;
                    case (-1):
                        RDBOther.Checked = true;
                        break;
                }
                this.Text = "Chỉnh sửa sinh viên";
                btnThem.Text = "Sửa sinh viên";
            
       
            

            LoadLopHoc();
        }

        private void LoadLopHoc()
        {
            var db = new AppQLSVDBContext();
            var ls = db.Classrooms.Select(e=>e.Name).ToList();
            CBBoxLopHoc.DataSource = ls;
            if (student != null)
            {
            var ClassDefault = db.Classrooms.Where(e => e.ID == student.IDClassroom).FirstOrDefault();
            CBBoxLopHoc.SelectedItem = ClassDefault.Name;
            }
            if (this.IDClass != null)
            {
                var ClassDefault = db.Classrooms.Where(e => e.ID == this.IDClass).FirstOrDefault();
                CBBoxLopHoc.SelectedItem = ClassDefault.Name;
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
           

        }

        private void frmHocSinhChiTiet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            if (student == null)
            {
                var db = new AppQLSVDBContext();
                var LopDuocChon = db.Classrooms.Where(t => t.Name == CBBoxLopHoc.Text).FirstOrDefault();
                String ID = txtMSV.Text;
                String FirstName = txtHo.Text;
                String LastName = txtTen.Text;
                String DateOfBirth = DTPNgaySinh.Value.ToString("yyyy-MM-dd");
                String PlaceOfBirth = txtNoiSinh.Text;
                int Gender = RDBNam.Checked ? 1 : (RDBNu.Checked ? 0 : -1);
                String IDClassroom = LopDuocChon.ID;
                if(ID.Equals(""))
                {
                    MessageBox.Show("Bạn phải nhập mã sinh viên");
                }
                else
                {
                    var SinhVienTrung = db.Students.Where(t => t.ID == ID).FirstOrDefault();
                    if (SinhVienTrung != null)
                    {
                        MessageBox.Show("Trùng mã sinh viên");

                    }
                    else
                    {
                        var Student = new Student
                        {
                            ID = ID,
                            FirstName = FirstName,
                            LastName = LastName,
                            DateOfBirth = DateTime.Parse(DateOfBirth),
                            PlaceOfBirth = PlaceOfBirth,
                            Gender = Gender,
                            IDClassroom = IDClassroom
                        };
                        db.Students.Add(Student);
                        db.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }

                    
                }
               
            }
            else
            {
                
                var db = new AppQLSVDBContext();
                var LopDuocChon = db.Classrooms.Where(t => t.Name == CBBoxLopHoc.Text).FirstOrDefault();
                var sv = db.Students.Where(t => t.ID == student.ID).FirstOrDefault();
                String ID = txtMSV.Text;
                String FirstName = txtHo.Text;
                String LastName = txtTen.Text;
                String DateOfBirth = DTPNgaySinh.Value.ToString("yyyy-MM-dd");
                String PlaceOfBirth = txtNoiSinh.Text;
                int Gender = RDBNam.Checked ? 1 : (RDBNu.Checked ? 0 : -1);
                String IDClassroom = LopDuocChon.ID;
                sv.FirstName = FirstName;
                sv.LastName = LastName;
                sv.DateOfBirth =DateTime.Parse(DateOfBirth);
                sv.PlaceOfBirth = PlaceOfBirth;
                sv.Gender = Gender;
                sv.IDClassroom = IDClassroom;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            
           
            



        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

        }

        private void txtMSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
