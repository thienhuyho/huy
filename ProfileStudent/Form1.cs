
using ProfileStudent.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileStudent
{
    public partial class Form1 : Form
    {
        Student student;
        public Form1()
        {
            InitializeComponent();
            student = Student.CreateFakeStudent();
           
            txtID.Text = student.ID;
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtPlaceOfBirth.Text = student.POB;
            dtpBirthDay.Value = student.DOB;
            switch (student.Sexual)
            {
                case SEXUAL.Male:
                    rdbMale.Checked = true; break;
                case SEXUAL.Female:
                    rdbFemale.Checked = true; break;
                case SEXUAL.Other:
                    rdbOtherSexual.Checked = true; break;
            }
            if (!string.IsNullOrEmpty(student.PathAvatar))
                picAvatar.ImageLocation = student.PathAvatar;
            gridHistory.AutoGenerateColumns = false;
            gridHistory.DataSource = student.ListLearningHistory;
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File ảnh|*.jpg;*.png";
            dialog.Title = "Chọn ảnh cho sinh viên";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picAvatar.ImageLocation = dialog.FileName;
            }
        }
    }
}
