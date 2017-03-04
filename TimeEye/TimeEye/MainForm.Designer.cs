namespace TimeEye
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.progressBar_work = new System.Windows.Forms.ProgressBar();
            this.timer_work = new System.Windows.Forms.Timer(this.components);
            this.timer_remind_work = new System.Windows.Forms.Timer(this.components);
            this.timer_remind_rest = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_switch = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox_setting = new System.Windows.Forms.PictureBox();
            this.pictureBox_current = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_switch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_current)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar_work
            // 
            this.progressBar_work.Location = new System.Drawing.Point(139, 384);
            this.progressBar_work.Name = "progressBar_work";
            this.progressBar_work.Size = new System.Drawing.Size(201, 23);
            this.progressBar_work.TabIndex = 4;
            // 
            // timer_work
            // 
            this.timer_work.Interval = 60000;
            this.timer_work.Tick += new System.EventHandler(this.timer_work_Tick);
            // 
            // timer_remind_work
            // 
            this.timer_remind_work.Tick += new System.EventHandler(this.timer_remind_work_Tick);
            // 
            // timer_remind_rest
            // 
            this.timer_remind_rest.Tick += new System.EventHandler(this.timer_remind_rest_Tick);
            // 
            // pictureBox_switch
            // 
            this.pictureBox_switch.BackgroundImage = global::TimeEye.Properties.Resources.start;
            this.pictureBox_switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_switch.Location = new System.Drawing.Point(76, 367);
            this.pictureBox_switch.Name = "pictureBox_switch";
            this.pictureBox_switch.Size = new System.Drawing.Size(56, 50);
            this.pictureBox_switch.TabIndex = 3;
            this.pictureBox_switch.TabStop = false;
            this.pictureBox_switch.Click += new System.EventHandler(this.pictureBox_switch_Click);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.BackgroundImage = global::TimeEye.Properties.Resources.close;
            this.pictureBox_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_close.Location = new System.Drawing.Point(346, 366);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(57, 50);
            this.pictureBox_close.TabIndex = 2;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // pictureBox_setting
            // 
            this.pictureBox_setting.BackgroundImage = global::TimeEye.Properties.Resources.setting;
            this.pictureBox_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_setting.Location = new System.Drawing.Point(12, 366);
            this.pictureBox_setting.Name = "pictureBox_setting";
            this.pictureBox_setting.Size = new System.Drawing.Size(57, 50);
            this.pictureBox_setting.TabIndex = 1;
            this.pictureBox_setting.TabStop = false;
            this.pictureBox_setting.Click += new System.EventHandler(this.pictureBox_setting_Click);
            // 
            // pictureBox_current
            // 
            this.pictureBox_current.BackgroundImage = global::TimeEye.Properties.Resources.initial;
            this.pictureBox_current.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_current.Location = new System.Drawing.Point(12, 11);
            this.pictureBox_current.Name = "pictureBox_current";
            this.pictureBox_current.Size = new System.Drawing.Size(391, 349);
            this.pictureBox_current.TabIndex = 0;
            this.pictureBox_current.TabStop = false;
            this.pictureBox_current.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_current_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 433);
            this.Controls.Add(this.progressBar_work);
            this.Controls.Add(this.pictureBox_switch);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.pictureBox_setting);
            this.Controls.Add(this.pictureBox_current);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TimeEye";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_switch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_current)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_current;
        private System.Windows.Forms.PictureBox pictureBox_setting;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.PictureBox pictureBox_switch;
        private System.Windows.Forms.ProgressBar progressBar_work;
        private System.Windows.Forms.Timer timer_work;
        private System.Windows.Forms.Timer timer_remind_work;
        private System.Windows.Forms.Timer timer_remind_rest;
    }
}

