namespace TimeEye
{
    partial class UserControl_TimeSetting
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_start_work = new System.Windows.Forms.Label();
            this.label_end_work = new System.Windows.Forms.Label();
            this.time_start_work = new System.Windows.Forms.DateTimePicker();
            this.time_end_work = new System.Windows.Forms.DateTimePicker();
            this.label_remind_work = new System.Windows.Forms.Label();
            this.label_remind_rest = new System.Windows.Forms.Label();
            this.label_min1 = new System.Windows.Forms.Label();
            this.label_min2 = new System.Windows.Forms.Label();
            this.time_remind_rest = new TimeEye.NumberTextbox();
            this.time_remind_work = new TimeEye.NumberTextbox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_start_work
            // 
            this.label_start_work.AutoSize = true;
            this.label_start_work.Location = new System.Drawing.Point(60, 46);
            this.label_start_work.Name = "label_start_work";
            this.label_start_work.Size = new System.Drawing.Size(134, 18);
            this.label_start_work.TabIndex = 0;
            this.label_start_work.Text = "开始工作时间：";
            // 
            // label_end_work
            // 
            this.label_end_work.AutoSize = true;
            this.label_end_work.Location = new System.Drawing.Point(60, 103);
            this.label_end_work.Name = "label_end_work";
            this.label_end_work.Size = new System.Drawing.Size(134, 18);
            this.label_end_work.TabIndex = 1;
            this.label_end_work.Text = "结束工作时间：";
            // 
            // time_start_work
            // 
            this.time_start_work.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_start_work.Location = new System.Drawing.Point(200, 42);
            this.time_start_work.Name = "time_start_work";
            this.time_start_work.ShowUpDown = true;
            this.time_start_work.Size = new System.Drawing.Size(200, 28);
            this.time_start_work.TabIndex = 2;
            // 
            // time_end_work
            // 
            this.time_end_work.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_end_work.Location = new System.Drawing.Point(200, 98);
            this.time_end_work.Name = "time_end_work";
            this.time_end_work.ShowUpDown = true;
            this.time_end_work.Size = new System.Drawing.Size(200, 28);
            this.time_end_work.TabIndex = 3;
            // 
            // label_remind_work
            // 
            this.label_remind_work.AutoSize = true;
            this.label_remind_work.Location = new System.Drawing.Point(60, 162);
            this.label_remind_work.Name = "label_remind_work";
            this.label_remind_work.Size = new System.Drawing.Size(134, 18);
            this.label_remind_work.TabIndex = 4;
            this.label_remind_work.Text = "工作时长提醒：";
            // 
            // label_remind_rest
            // 
            this.label_remind_rest.AutoSize = true;
            this.label_remind_rest.Location = new System.Drawing.Point(60, 224);
            this.label_remind_rest.Name = "label_remind_rest";
            this.label_remind_rest.Size = new System.Drawing.Size(134, 18);
            this.label_remind_rest.TabIndex = 6;
            this.label_remind_rest.Text = "休息时长提醒：";
            // 
            // label_min1
            // 
            this.label_min1.AutoSize = true;
            this.label_min1.Location = new System.Drawing.Point(366, 162);
            this.label_min1.Name = "label_min1";
            this.label_min1.Size = new System.Drawing.Size(44, 18);
            this.label_min1.TabIndex = 8;
            this.label_min1.Text = "分钟";
            // 
            // label_min2
            // 
            this.label_min2.AutoSize = true;
            this.label_min2.Location = new System.Drawing.Point(366, 221);
            this.label_min2.Name = "label_min2";
            this.label_min2.Size = new System.Drawing.Size(44, 18);
            this.label_min2.TabIndex = 9;
            this.label_min2.Text = "分钟";
            // 
            // time_remind_rest
            // 
            this.time_remind_rest.Location = new System.Drawing.Point(200, 218);
            this.time_remind_rest.Name = "time_remind_rest";
            this.time_remind_rest.Size = new System.Drawing.Size(160, 28);
            this.time_remind_rest.TabIndex = 7;
            // 
            // time_remind_work
            // 
            this.time_remind_work.Location = new System.Drawing.Point(200, 157);
            this.time_remind_work.Name = "time_remind_work";
            this.time_remind_work.Size = new System.Drawing.Size(160, 28);
            this.time_remind_work.TabIndex = 5;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(189, 305);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(88, 42);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // UserControl_TimeSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label_min2);
            this.Controls.Add(this.label_min1);
            this.Controls.Add(this.time_remind_rest);
            this.Controls.Add(this.label_remind_rest);
            this.Controls.Add(this.time_remind_work);
            this.Controls.Add(this.label_remind_work);
            this.Controls.Add(this.time_end_work);
            this.Controls.Add(this.time_start_work);
            this.Controls.Add(this.label_end_work);
            this.Controls.Add(this.label_start_work);
            this.Name = "UserControl_TimeSetting";
            this.Size = new System.Drawing.Size(620, 529);
            this.Load += new System.EventHandler(this.UserControl_TimeSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_start_work;
        private System.Windows.Forms.Label label_end_work;
        private System.Windows.Forms.DateTimePicker time_start_work;
        private System.Windows.Forms.DateTimePicker time_end_work;
        private System.Windows.Forms.Label label_remind_work;
        private NumberTextbox time_remind_work;
        private System.Windows.Forms.Label label_remind_rest;
        private NumberTextbox time_remind_rest;
        private System.Windows.Forms.Label label_min1;
        private System.Windows.Forms.Label label_min2;
        private System.Windows.Forms.Button btn_ok;

    }
}
