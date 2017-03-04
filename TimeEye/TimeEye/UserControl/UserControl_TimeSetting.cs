using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TimeEye
{
    public partial class UserControl_TimeSetting : UserControl
    {
        private static String[] userValues = { Utils.time_start_work, Utils.time_end_work ,
                                             Utils.time_remind_work.ToString(),
                                             Utils.time_remind_rest.ToString()};
        private XmlOperation xmlOperation;
        public UserControl_TimeSetting()
        {
            InitializeComponent();
            xmlOperation = new XmlOperation();
        }

        private void UserControl_TimeSetting_Load(object sender, EventArgs e)
        {
            this.time_start_work.Text = userValues[0];
            this.time_end_work.Text = userValues[1];
            this.time_remind_work.Text = userValues[2];
            this.time_remind_rest.Text = userValues[3]; 
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string[] values = { this.time_start_work.Text, this.time_end_work.Text ,
                              this.time_remind_work.Text,this.time_remind_rest.Text};
            if (!File.Exists(Utils.timeSettingFile))
            {
                xmlOperation.CreateXMLFile(Utils.timeSettingFile);
            }
            Boolean res = xmlOperation.WriteTimeSetting(Utils.timeSettingFile, values);
            if (res)
            {
                userValues = values;
                MessageBox.Show("保存成功，重启生效");
            }
            else {
                MessageBox.Show("保存失败");
            }

        }
    }
}
