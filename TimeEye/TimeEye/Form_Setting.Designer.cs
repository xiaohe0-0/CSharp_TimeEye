namespace TimeEye
{
    partial class Form_Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Setting));
            this.tabControl_setting = new System.Windows.Forms.TabControl();
            this.tab_timeSetting = new System.Windows.Forms.TabPage();
            this.tab_timeAnalysis = new System.Windows.Forms.TabPage();
            this.tab_theme = new System.Windows.Forms.TabPage();
            this.tab_backup = new System.Windows.Forms.TabPage();
            this.tabControl_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_setting
            // 
            this.tabControl_setting.Controls.Add(this.tab_timeSetting);
            this.tabControl_setting.Controls.Add(this.tab_timeAnalysis);
            this.tabControl_setting.Controls.Add(this.tab_theme);
            this.tabControl_setting.Controls.Add(this.tab_backup);
            this.tabControl_setting.Location = new System.Drawing.Point(3, 12);
            this.tabControl_setting.Name = "tabControl_setting";
            this.tabControl_setting.SelectedIndex = 0;
            this.tabControl_setting.Size = new System.Drawing.Size(766, 589);
            this.tabControl_setting.TabIndex = 0;
            this.tabControl_setting.Tag = "";
            this.tabControl_setting.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_setting_Selected);
            // 
            // tab_timeSetting
            // 
            this.tab_timeSetting.Location = new System.Drawing.Point(4, 28);
            this.tab_timeSetting.Name = "tab_timeSetting";
            this.tab_timeSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tab_timeSetting.Size = new System.Drawing.Size(758, 557);
            this.tab_timeSetting.TabIndex = 0;
            this.tab_timeSetting.Text = "时间设置";
            this.tab_timeSetting.UseVisualStyleBackColor = true;
            // 
            // tab_timeAnalysis
            // 
            this.tab_timeAnalysis.Location = new System.Drawing.Point(4, 28);
            this.tab_timeAnalysis.Name = "tab_timeAnalysis";
            this.tab_timeAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tab_timeAnalysis.Size = new System.Drawing.Size(758, 557);
            this.tab_timeAnalysis.TabIndex = 1;
            this.tab_timeAnalysis.Text = "时间分析";
            this.tab_timeAnalysis.UseVisualStyleBackColor = true;
            // 
            // tab_theme
            // 
            this.tab_theme.Location = new System.Drawing.Point(4, 28);
            this.tab_theme.Name = "tab_theme";
            this.tab_theme.Size = new System.Drawing.Size(758, 557);
            this.tab_theme.TabIndex = 2;
            this.tab_theme.Text = "主题";
            this.tab_theme.UseVisualStyleBackColor = true;
            // 
            // tab_backup
            // 
            this.tab_backup.Location = new System.Drawing.Point(4, 28);
            this.tab_backup.Name = "tab_backup";
            this.tab_backup.Size = new System.Drawing.Size(758, 557);
            this.tab_backup.TabIndex = 3;
            this.tab_backup.Text = "备份";
            this.tab_backup.UseVisualStyleBackColor = true;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 613);
            this.Controls.Add(this.tabControl_setting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            this.tabControl_setting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_setting;
        private System.Windows.Forms.TabPage tab_timeSetting;
        private System.Windows.Forms.TabPage tab_timeAnalysis;
        private System.Windows.Forms.TabPage tab_theme;
        private System.Windows.Forms.TabPage tab_backup;
    }
}