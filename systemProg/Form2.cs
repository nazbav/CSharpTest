using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemProg
{
    public partial class Form2 : Form
    {
        Point PrevMousePos;
        bool MouseState = false;
        public Form2()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            PrevMousePos = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Left) { this.MouseState = true; }
        }
        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.MouseState)
            {
                int dx = e.X - PrevMousePos.X;
                int dy = e.Y - PrevMousePos.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.MouseState = false; }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form0 form0 = new Form0(); 
           form0.form2Close = true;
        }
    }
}
