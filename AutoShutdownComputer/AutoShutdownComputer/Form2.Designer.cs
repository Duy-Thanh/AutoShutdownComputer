namespace AutoShutdownComputer
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSecondsRemaning = new System.Windows.Forms.Label();
            this.lblSecondsNotify = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông báo: Thời gian tắt máy còn lại là:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian thông báo nhác nhở trước khi tắt máy: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 58);
            this.label3.TabIndex = 2;
            this.label3.Text = "CHÚ Ý: Hãy lưu ngay công việc bạn đang làm \r\nđể tránh mát mát dữ liệu khi tắt máy" +
    " / khởi động lại";
            // 
            // lblSecondsRemaning
            // 
            this.lblSecondsRemaning.AutoSize = true;
            this.lblSecondsRemaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsRemaning.Location = new System.Drawing.Point(470, 7);
            this.lblSecondsRemaning.Name = "lblSecondsRemaning";
            this.lblSecondsRemaning.Size = new System.Drawing.Size(0, 29);
            this.lblSecondsRemaning.TabIndex = 3;
            // 
            // lblSecondsNotify
            // 
            this.lblSecondsNotify.AutoSize = true;
            this.lblSecondsNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsNotify.Location = new System.Drawing.Point(566, 46);
            this.lblSecondsNotify.Name = "lblSecondsNotify";
            this.lblSecondsNotify.Size = new System.Drawing.Size(0, 29);
            this.lblSecondsNotify.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 146);
            this.Controls.Add(this.lblSecondsNotify);
            this.Controls.Add(this.lblSecondsRemaning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Thông báo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSecondsNotify;
        private System.Windows.Forms.Label lblSecondsRemaning;
        private System.Windows.Forms.Timer timer1;
    }
}