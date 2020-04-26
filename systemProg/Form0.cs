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
    public partial class Form0 : Form
    {
        bool MouseState = false;
        public bool PanelClose = true;
        public bool form2Close = true;
        public bool form4Close = true;
        Point PrevMousePos;
        Form2 f2;
        Form3 f3;
        Form4 f4;
        public Form0()
        {
            TopMost = true;
            InitializeComponent();
            (new Form1()).Show();
            f2 = new Form2();
            f3 = new Form3();
            f4 = new Form4();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                if (PanelClose)
                {
                    f3.Show();
                    PanelClose = !PanelClose;
                }
                else
                {
                    f3.Hide();
                    PanelClose = !PanelClose;
                }
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

        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (form2Close)
            {
                f2.Show();
                form2Close = !form2Close;
            }
            else
            {
                f2.Hide();
                form2Close = !form2Close;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (form4Close)
            {
                f4.Show();
                form4Close = !form4Close;
            }
            else
            {
                f4.Hide();
                form4Close = !form4Close;
            }
        }
    }
}
