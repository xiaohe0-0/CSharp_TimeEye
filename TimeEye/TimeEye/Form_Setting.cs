using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeEye
{
    public partial class Form_Setting : Form
    {
        private UserControl_TimeSetting userControl_TimeSetting;
        private UserControl_TimeAnalysis userControl_TimeAnalysis;
        private UserControl_Theme userControl_Theme;
        private UserControl_Backup userControl_Backup;

        public Form_Setting()
        {
            InitializeComponent();
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            userControl_TimeSetting = new UserControl_TimeSetting();
            userControl_TimeAnalysis = new UserControl_TimeAnalysis();
            userControl_Theme = new UserControl_Theme();
            userControl_Backup = new UserControl_Backup();

            Control_Tab_TimeSetting();
        }

        private void tabControl_setting_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl_setting.SelectedTab.Name) { 
                case "tab_timeSetting":
                    Control_Tab_TimeSetting();
                    break;
                case "tab_timeAnalysis":
                    Control_Tab_TimeAnalysis();
                    break;
                case "tab_theme":
                    Control_Tab_Theme();
                    break;
                case "tab_backup":
                    Control_Tab_Backup();
                    break;
            }
        }
        private void Control_Tab_TimeSetting() {
            tab_timeSetting.Controls.Clear();
            tab_timeSetting.Controls.Add(userControl_TimeSetting);
        }
        private void Control_Tab_TimeAnalysis()
        {
            tab_timeAnalysis.Controls.Clear();
            tab_timeAnalysis.Controls.Add(userControl_TimeAnalysis);
        }
        private void Control_Tab_Theme()
        {
            tab_theme.Controls.Clear();
            tab_theme.Controls.Add(userControl_Theme);
        }
        private void Control_Tab_Backup()
        {
            tab_backup.Controls.Clear();
            tab_backup.Controls.Add(userControl_Backup);
        }
    }
}
