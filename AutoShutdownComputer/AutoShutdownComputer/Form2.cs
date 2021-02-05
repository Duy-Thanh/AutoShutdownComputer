using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoShutdownComputer
{
    public partial class Form2 : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public Form2()
        {
            InitializeComponent();
            Location = new Point(1259, 905);
            StartPosition = FormStartPosition.Manual;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string str1 = File.ReadAllText("strDownTime.txt");
            string str2 = File.ReadAllText("strDownTimeNotify.txt");
            lblSecondsRemaning.Text = str1;
            lblSecondsNotify.Text = str2;
        }
    }
}
