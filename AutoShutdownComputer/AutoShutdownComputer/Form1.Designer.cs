namespace AutoShutdownComputer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmrSecondsNotify = new System.Windows.Forms.NumericUpDown();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.nmrMinutesNotify = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.nmrHourNotify = new System.Windows.Forms.NumericUpDown();
            this.lblHour = new System.Windows.Forms.Label();
            this.chkbNotify = new System.Windows.Forms.CheckBox();
            this.nmrSeconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrMinutes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSecondsNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinutesNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHourNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHour)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmrSecondsNotify);
            this.groupBox1.Controls.Add(this.lblSeconds);
            this.groupBox1.Controls.Add(this.nmrMinutesNotify);
            this.groupBox1.Controls.Add(this.lblMinutes);
            this.groupBox1.Controls.Add(this.nmrHourNotify);
            this.groupBox1.Controls.Add(this.lblHour);
            this.groupBox1.Controls.Add(this.chkbNotify);
            this.groupBox1.Controls.Add(this.nmrSeconds);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nmrMinutes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmrHour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hẹn giờ tắt máy tính";
            // 
            // nmrSecondsNotify
            // 
            this.nmrSecondsNotify.Enabled = false;
            this.nmrSecondsNotify.Location = new System.Drawing.Point(460, 129);
            this.nmrSecondsNotify.Name = "nmrSecondsNotify";
            this.nmrSecondsNotify.Size = new System.Drawing.Size(120, 26);
            this.nmrSecondsNotify.TabIndex = 12;
            this.nmrSecondsNotify.ValueChanged += new System.EventHandler(this.nmrSecondsNotify_ValueChanged);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Enabled = false;
            this.lblSeconds.Location = new System.Drawing.Point(409, 131);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(45, 20);
            this.lblSeconds.TabIndex = 11;
            this.lblSeconds.Text = "Giây:";
            // 
            // nmrMinutesNotify
            // 
            this.nmrMinutesNotify.Enabled = false;
            this.nmrMinutesNotify.Location = new System.Drawing.Point(257, 129);
            this.nmrMinutesNotify.Name = "nmrMinutesNotify";
            this.nmrMinutesNotify.Size = new System.Drawing.Size(120, 26);
            this.nmrMinutesNotify.TabIndex = 10;
            this.nmrMinutesNotify.ValueChanged += new System.EventHandler(this.nmrMinutesNotify_ValueChanged);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Enabled = false;
            this.lblMinutes.Location = new System.Drawing.Point(205, 131);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(46, 20);
            this.lblMinutes.TabIndex = 9;
            this.lblMinutes.Text = "Phút:";
            // 
            // nmrHourNotify
            // 
            this.nmrHourNotify.Enabled = false;
            this.nmrHourNotify.Location = new System.Drawing.Point(51, 129);
            this.nmrHourNotify.Name = "nmrHourNotify";
            this.nmrHourNotify.Size = new System.Drawing.Size(120, 26);
            this.nmrHourNotify.TabIndex = 8;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Enabled = false;
            this.lblHour.Location = new System.Drawing.Point(7, 131);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(38, 20);
            this.lblHour.TabIndex = 7;
            this.lblHour.Text = "Giờ:";
            // 
            // chkbNotify
            // 
            this.chkbNotify.AutoSize = true;
            this.chkbNotify.Location = new System.Drawing.Point(11, 88);
            this.chkbNotify.Name = "chkbNotify";
            this.chkbNotify.Size = new System.Drawing.Size(412, 24);
            this.chkbNotify.TabIndex = 6;
            this.chkbNotify.Text = "Thông báo nhắc nhở tôi sắp hết thời gian tắt máy vào:";
            this.chkbNotify.UseVisualStyleBackColor = true;
            this.chkbNotify.CheckedChanged += new System.EventHandler(this.chkbNotify_CheckedChanged);
            // 
            // nmrSeconds
            // 
            this.nmrSeconds.Location = new System.Drawing.Point(460, 41);
            this.nmrSeconds.Name = "nmrSeconds";
            this.nmrSeconds.Size = new System.Drawing.Size(120, 26);
            this.nmrSeconds.TabIndex = 5;
            this.nmrSeconds.ValueChanged += new System.EventHandler(this.nmrSeconds_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giây:";
            // 
            // nmrMinutes
            // 
            this.nmrMinutes.Location = new System.Drawing.Point(257, 41);
            this.nmrMinutes.Name = "nmrMinutes";
            this.nmrMinutes.Size = new System.Drawing.Size(120, 26);
            this.nmrMinutes.TabIndex = 3;
            this.nmrMinutes.ValueChanged += new System.EventHandler(this.nmrMinutes_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phút:";
            // 
            // nmrHour
            // 
            this.nmrHour.Location = new System.Drawing.Point(51, 41);
            this.nmrHour.Name = "nmrHour";
            this.nmrHour.Size = new System.Drawing.Size(120, 26);
            this.nmrHour.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giờ:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(474, 197);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 34);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Huỷ lệnh";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(337, 197);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(131, 34);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.Location = new System.Drawing.Point(200, 197);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(131, 34);
            this.btnShutDown.TabIndex = 15;
            this.btnShutDown.Text = "Shut down";
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "AutoShutdownComputer Dashboard";
            this.notifyIcon1.BalloonTipTitle = "AutoShutdownComputer Dashboard";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "AutoShutdownComputer Dashboard";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(328, 68);
            // 
            // mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem
            // 
            this.mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem.Name = "mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem";
            this.mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem.Size = new System.Drawing.Size(327, 32);
            this.mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem.Text = "Mở bảng điều khiển ứng dụng";
            this.mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem.Click += new System.EventHandler(this.mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(327, 32);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 288);
            this.Controls.Add(this.btnShutDown);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hẹn giờ tắt máy tính - Coded by Duy Thành";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSecondsNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinutesNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHourNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHour)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmrSecondsNotify;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown nmrMinutesNotify;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown nmrHourNotify;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.CheckBox chkbNotify;
        private System.Windows.Forms.NumericUpDown nmrSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mởBảngĐiềuKhiểnỨngDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Timer timer3;
    }
}

