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
    public partial class Form4 : Form
    {
        bool MouseState = false;
        Point PrevMousePos;
        public Form4()
        {
            TopMost = true;
            InitializeComponent();
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form0 form0 = new Form0();
            form0.form4Close = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
