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
    public partial class frmCoBan3 : Form
    {
        double minutes = 0.5;//30 giây
        double currentSecond;
        public frmCoBan3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentSecond--;
            lblClock.Text =
                $"{(int)(currentSecond / 60):0#}:{currentSecond % 60:0#}";
            if (currentSecond == 0)
            {
                timer1.Stop();
                var f = new frmEndGame();
                f.ShowDialog();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (currentSecond == 0)
                currentSecond = getStartSecond();
            timer1.Start();
        }

        int getStartSecond()
        {
            var _minutes = numMinutes.Value;
            var _second = numSecond.Value;
            return (int) (_minutes * 60 + _second);
        }

        private void numMinutes_ValueChanged(object sender, EventArgs e)
        {
            showStartClock();
        }

        private void numSecond_ValueChanged(object sender, EventArgs e)
        {
            showStartClock();
        }
        void showStartClock()
        {
            var _minutes = numMinutes.Value;
            var _second = numSecond.Value;
            lblClock.Text =
                $"{(int)(_minutes):0#}:{(int)_second:0#}";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblClock.Text = $"00:00";
            currentSecond = 0;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
