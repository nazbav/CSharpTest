using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemProg
{
    public partial class Form1 : Form
    {
        bool my;
        public Form1()
        {
            InitializeComponent();
           this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            my = false;
            if (e.KeyCode == Keys.F4 && e.Alt)
                my = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (my)
                e.Cancel = true;
        }
    }
}
