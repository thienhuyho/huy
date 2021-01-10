using AppQLSV.DAL;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV.GUI
{
    public partial class frmEcxel : Form
    {
        String id;
        public frmEcxel()
        {
            
            InitializeComponent();
        }
        public frmEcxel(String ID)
        {
            InitializeComponent();
            var db =new AppQLSVDBContext();
            var ls = db.Classrooms.Select(e => e.Name).ToList();
            cbbLopHoc.DataSource = ls;
            this.id = ID;
            if (this.id != null)
            {
                var ClassDefault = db.Classrooms.Where(e => e.ID == this.id).FirstOrDefault();
                cbbLopHoc.SelectedItem = ClassDefault.Name;
            }


        }
        DataTableCollection tableCollection;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() {  })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                   ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true}
                            });
                            tableCollection = result.Tables;
                           CBOSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                CBOSheet.Items.Add(table.TableName);

                        }
                    }

                }
            }
        }

        private void CBOSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[CBOSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var db = new AppQLSVDBContext();
            var LopDuocChon = db.Classrooms.Where(t => t.Name == cbbLopHoc.Text).FirstOrDefault();



            for (int rows = 1; rows < dataGridView1.Rows.Count; rows++)
            {
                if (dataGridView1.Rows[rows].Cells[0].Value != null)
                {

                    var Student = new Student
                    {
                        ID = dataGridView1.Rows[rows].Cells[0].Value.ToString(),
                        FirstName = dataGridView1.Rows[rows].Cells[1].Value.ToString(),
                        LastName = dataGridView1.Rows[rows].Cells[2].Value.ToString(),
                        DateOfBirth = DateTime.Parse(dataGridView1.Rows[rows].Cells[3].Value.ToString()),
                        PlaceOfBirth = dataGridView1.Rows[rows].Cells[4].Value.ToString(),
                        Gender = int.Parse(dataGridView1.Rows[rows].Cells[5].Value.ToString()),
                        IDClassroom = LopDuocChon.ID
                    };
                    db.Students.Add(Student);

                }
               

            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Dữ liệu không đúng hoặc trùng mã sinh viên");
            }
            
        }

        private void CBBLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
