using AutoShutdownComputer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoShutdownComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadStatusBar();
            notifyIcon1.Icon = Resources.app_icon;
            notifyIcon1.BalloonTipTitle = "AutoShutdownComputer Dashboard";
            notifyIcon1.BalloonTipText = "Ứng dụng này hiện đang chạy!";
            notifyIcon1.ShowBalloonTip(1000);
        }

        StatusBarPanel downTimePanel = new StatusBarPanel();
        StatusBarPanel barPanel = new StatusBarPanel();
        StatusBarPanel notifyDownTimePanel = new StatusBarPanel();

        decimal downTime = 0;

        decimal notifyDownTime = 0;

        void LoadStatusBar()
        {
            StatusBar status = new StatusBar();

            status.ShowPanels = true;
            status.Panels.Add(barPanel);
            status.Panels.Add(downTimePanel);
            status.Panels.Add(notifyDownTimePanel);

            downTimePanel.Text = "";
            barPanel.Text = "Ready";

            this.Controls.Add(status);
        }

        void CalculateDownTime()
        {
            downTime = nmrSeconds.Value + nmrMinutes.Value * 60 + nmrHour.Value * 60 * 60;
            notifyDownTime = nmrSecondsNotify.Value + nmrMinutesNotify.Value * 60 + nmrHourNotify.Value * 60 * 60;
        }

        void Command(string cmd)
        {
            System.Diagnostics.Process.Start("shutdown", cmd);
        }

        private void chkbNotify_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbNotify.Checked)
            {
                lblHour.Enabled = true;
                lblMinutes.Enabled = true;
                lblSeconds.Enabled = true;
                nmrHourNotify.Enabled = true;
                nmrMinutesNotify.Enabled = true;
                nmrSecondsNotify.Enabled = true;
            }
            else if (!chkbNotify.Checked)
            {
                lblHour.Enabled = false;
                lblMinutes.Enabled = false;
                lblSeconds.Enabled = false;
                nmrHourNotify.Enabled = false;
                nmrMinutesNotify.Enabled = false;
                nmrSecondsNotify.Enabled = false;
            }
        }

        private void nmrSeconds_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;

            if (box.Value >= 60)
            {
                nmrMinutes.Value++;
                box.Value = 0;
            }
        }

        private void nmrMinutes_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;

            if (box.Value >= 60)
            {
                nmrHour.Value++;
                box.Value = 0;
            }
        }

        private void nmrSecondsNotify_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown boxNotify = sender as NumericUpDown;

            if (boxNotify.Value >= 60)
            {
                nmrMinutesNotify.Value++;
                boxNotify.Value = 0;
            }
        }

        private void nmrMinutesNotify_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown boxNotify = sender as NumericUpDown;

            if (boxNotify.Value >= 60)
            {
                nmrHourNotify.Value++;
                boxNotify.Value = 0;
            }
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            if (notifyDownTime > downTime)
            {
                MessageBox.Show("Thời gian thông báo nhắc nhở không được lớn hơn thời gian hẹn giờ tắt máy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CalculateDownTime();
                timer1.Start();
                timer2.Start();
                timer3.Start();
                Command("/s /t " + downTime.ToString());
                barPanel.Text = "Shutting down...";
                Form2 frm2 = new Form2();
                frm2.Show();

            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (notifyDownTime > downTime)
            {
                MessageBox.Show("Thời gian thông báo nhắc nhở không được lớn hơn thời gian hẹn giờ tắt máy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CalculateDownTime();
                timer1.Start();
                timer2.Start();
                timer3.Start();
                Command("/r /t " + downTime.ToString());
                barPanel.Text = "Restarting...";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //if (nmrHourNotify.Value > nmrHour.Value || nmrMinutesNotify.Value > nmrMinutes.Value || nmrSecondsNotify.Value > nmrSeconds.Value)
            //{
            //    MessageBox.Show("Thời gian thông báo nhắc nhở không được lớn hơn thời gian hẹn giờ tắt máy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            Command("-a");
            barPanel.Text = "Cancelling action...";
            Thread.Sleep(TimeSpan.FromSeconds(3));
            barPanel.Text = "Ready";
            downTimePanel.Text = "";
            notifyDownTimePanel.Text = "";
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            downTime--;
            downTimePanel.Text = downTime.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (notifyDownTime == downTime)
            {
                this.Hide();
                Form2 frmNotify = new Form2();
                frmNotify.Show();
                timer2.Stop();
            }
        }

        private void mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Command("-a");
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            Application.Exit();
            foreach (var item in Process.GetProcessesByName("AutoShutdownComputer"))
            {
                item.Kill();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            //this.Show();
        }

        public delegate void SendMessage1(string dwnTime);
        public delegate void SendMessage2(string dwnTimeNotify);
        private void timer3_Tick(object sender, EventArgs e)
        {
            string downTimeStr = downTime.ToString();
            string downTimeNotifyStr = notifyDownTime.ToString();
            File.WriteAllText("strDownTime.txt", downTimeStr);
            File.WriteAllText("strDownTimeNotify.txt", downTimeNotifyStr);
        }
    }
}
