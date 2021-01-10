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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowClassRoom();
            
        }

        private void ShowClassRoom()
        {
            var db = new QLSV();
            var ls = db.Classrooms.ToList();
            dataGridView1.DataSource = ls;
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String name = txtFilter.Text;
                if (name.Equals(""))
                {
                    ShowClassRoom();
                }
                else
                {
                    var db = new QLSV();
                    var ls = db.Classrooms
                                .Where(t => t.Name.Contains(name) || t.Room.Contains(name))
                                .ToList();
                    dataGridView1.DataSource = ls;
                }
               
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            var f = new AddClass();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ShowClassRoom();
            }
        }
    }
}
