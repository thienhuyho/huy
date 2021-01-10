using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmThemLop : Form
    {
        public frmThemLop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClassroom();
            
        }
        void AddClassroom()
        {

            Classroom classroom = new Classroom
            {
                ID = Guid.NewGuid().ToString(),
                Name = txtTenLop.Text,
                Room = txtPhongHoc.Text
            };
            var db = new Model1();
            var obj = db.Classrooms.
                Where(e => e.Name == classroom.Name).
                FirstOrDefault();
            if (obj == null)
            {
                try
                {
                    db.Classrooms.Add(classroom);
                    db.SaveChanges();
                    MessageBox.Show("đã thêm thành công");
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Bạn nhập dữ liệu sai");
                }
               
               
            }
            else
            {
                MessageBox.Show("bạn không thể thêm lớp này được");
            }

        }
    }
}
