using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace launcginbrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "http://www.bing.com/search?q=C%23+examples");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe", "www.microsoft.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "www.google.com");
        }
    }
}
