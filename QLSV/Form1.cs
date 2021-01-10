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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          //  AddClassroom();
            LoadClassRoom();
        }
        /// <summary>
        /// Lấy danh sách các lớp học có trong cơ sở dữ liệu
        /// </summary>
        void LoadClassRoom()
        {
            var db = new QLSV.DAL.Model1();

            //Lấy tất cả db
            var ls = db.Classrooms.ToList();
            //e là 1 record trong classroom
            //  var ls = db.Classrooms.Where(e=>e.Room =="Lab1").ToList();
        
           
           /* var ls = db.Classrooms.Where(e => e.Room == "Lab1").
                Select(e => new 
                { 
                   TenLop = e.Name,
                   PhongHoc = e.Room, 
                   SiSo= e.Students.Count(),
                   GVCV ="Abc" 
                }).ToList();*/
            dataGridView1.DataSource = ls;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                var keyWord = txtKeyword.Text;
                var db = new Model1();
                var ls= db.Classrooms.
                    Where
                    (t => 
                        t.Name.Contains(keyWord) || t.Room.Contains(keyWord)
                    ).ToList();
                dataGridView1.DataSource = ls;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new frmThemLop();
            var rs =   f.ShowDialog();
            if(rs == DialogResult.OK)
            {
                LoadClassRoom();
            }
        }
    }
}
