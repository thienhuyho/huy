using QLSV_O_nha.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_O_nha
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Name = textBox1.Text;
            String Room = textBox2.Text;
            var db = new QLSV();
            var obj = db.Classrooms.Where(t => t.Name.Equals(Name)).FirstOrDefault();
            if (obj == null)
            {
                db.Classrooms.Add(new Classroom
                {
                    ID = Guid.NewGuid().ToString(),
                    Name= Name,
                    Room = Room
                });
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Đã tồn tại lớp");
            }
        }
    }
}
