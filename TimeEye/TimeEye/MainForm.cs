using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace TimeEye
{
    public partial class MainForm : Form
    {
        private static int click_count = 0;
        private static int work_count = 0;
        private static int rest_count = 0;
        private DateTime work_start;
        private DateTime work_end;
        private Utils.status current_status;
        private int remind_work = 30;//min
        private int remind_rest = 10;//min
        private XmlOperation xmlOperation;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public MainForm()
        {
            InitializeComponent();
            xmlOperation = new XmlOperation();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Utils.xmlRecordFile))
            {
                xmlOperation.CreateXMLFile(Utils.xmlRecordFile);
            }
            if (File.Exists(Utils.timeSettingFile))
            {
                xmlOperation.ReadTimeSetting(Utils.timeSettingFile);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            double screenX = Screen.GetWorkingArea(this).Width;//得到屏幕整体宽度
            this.Left = int.Parse((screenX - this.Width-10).ToString()) ;//设置窗体与左边的距离
            this.Top = 10;

            progress_set_value();
            xmlOperation.CreateMessageInfoNode(DateTime.Now.ToShortDateString(),"","");

            remind_work = Utils.time_remind_work;
            remind_rest = Utils.time_remind_rest;
            timer_remind_work.Interval = remind_work * Utils.tickUnit;
            timer_remind_rest.Interval = remind_rest * Utils.tickUnit;

            timer_work.Start();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_switch_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if(click_count % 2 == 0){//Switch to work
                this.pictureBox_current.BackgroundImage = Properties.Resources.work;
                this.pictureBox_switch.BackgroundImage = Properties.Resources.stop;
               
                if(click_count != 0)
                    xmlOperation.CreateMessageInfoNode(now.ToShortDateString(), now.ToShortTimeString(), Utils.content_rest_end);
                xmlOperation.CreateMessageInfoNode(now.ToShortDateString(), now.ToShortTimeString(), Utils.content_work_start);
                current_status = Utils.status.Wokring;
                rest_count = 0;
                timer_remind_rest.Stop();
                timer_remind_work.Start();
            }
            else{//Switch to rest
                this.pictureBox_current.BackgroundImage = Properties.Resources.rest;
                this.pictureBox_switch.BackgroundImage = Properties.Resources.start;

                xmlOperation.CreateMessageInfoNode(now.ToShortDateString(), now.ToShortTimeString(), Utils.content_work_end);
                xmlOperation.CreateMessageInfoNode(now.ToShortDateString(), now.ToShortTimeString(), Utils.content_rest_start);

                current_status = Utils.status.Resting;
                work_count = 0;
                timer_remind_work.Stop();
                timer_remind_rest.Start();
            }
            click_count++;
        }

        private void timer_work_Tick(object sender, EventArgs e)
        {
            progress_set_value();
        }


        //Set progress bar
        private void progress_set_value() {
            DateTime now = DateTime.Now;
            String[] startTime = Utils.time_start_work.Split(':');
            String[] endTime = Utils.time_end_work.Split(':');

            work_start = new DateTime(now.Year, now.Month, now.Day,
                int.Parse(startTime[0]), int.Parse(startTime[1]), int.Parse(startTime[2]));
            work_end = new DateTime(now.Year, now.Month, now.Day,
                int.Parse(endTime[0]), int.Parse(endTime[1]), int.Parse(endTime[2]));

            int prograss_max = (int)(work_end - work_start).TotalMinutes;
            if (prograss_max > 0)
            {
                progressBar_work.Maximum = prograss_max;
                int progress_value = (int)(now - work_start).TotalMinutes;
                if (progress_value > 0 && progress_value <= prograss_max)
                    progressBar_work.Value = progress_value;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime now = DateTime.Now;
            if (click_count != 0)
            {
                switch (current_status)
                {
                    case Utils.status.Wokring:
                        xmlOperation.CreateMessageInfoNode(now.ToShortDateString(), now.ToShortTimeString(), Utils.content_work_end);
                        break;
                    case Utils.status.Resting:
                        xmlOperation.CreateMessageInfoNode(now.ToShortDateString(), now.ToShortTimeString(), Utils.content_rest_end);
                        break;
                }
            }
        }

        private void timer_remind_work_Tick(object sender, EventArgs e)
        {
            work_count++;
            MessageBox.Show("你已经工作了"+remind_work*work_count+"分钟了");
        }

        private void timer_remind_rest_Tick(object sender, EventArgs e)
        {
            rest_count++;
            MessageBox.Show("你已经休息了"+remind_rest*rest_count+"分钟了");
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void pictureBox_current_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void pictureBox_current_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_setting_Click(object sender, EventArgs e)
        {
            Form_Setting fs = new Form_Setting();
            fs.ShowDialog();
        }
    }
}
