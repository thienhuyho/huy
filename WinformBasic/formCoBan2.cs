using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBasic
{
    public partial class formCoBan2 : Form
    {
        public formCoBan2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var t = Age(dtpNgaySinh.Value);
            var rs = $"Tuổi của bạn là {t}";
            MessageBox.Show(rs);
        }
        int Age(DateTime birthDay)
        {
            var age = DateTime.Now.Year - birthDay.Year;
            return age;
        }

        private void trbCanNang_Scroll(object sender, EventArgs e)
        {
            lblCanNang.Text =$"{trbCanNang.Value.ToString("N0")}g";
        }
    }
}
