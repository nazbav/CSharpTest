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
    public partial class Form3 : Form
    {
        int move = 0;
        bool exit_rofl = true;
        int exit_count = 0;
        int xs;
        int shutdown = 0;
        int ys;
        bool button_jump = false;
        bool MouseState = false;
        Point PrevMousePos;
        public Form3()
        {
            TopMost = true;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            xs = Screen.PrimaryScreen.WorkingArea.Width;
            ys = Screen.PrimaryScreen.WorkingArea.Height;
            button2.Location = new System.Drawing.Point((xs - button2.Width) / 2, (ys - button2.Height) / 2);
            timer1.Start();
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

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            if (exit_count == 0) exit_count = rand.Next(5, 60);
            if (move >= exit_count)
            {
                label2.Text = "Вы уверены что хотите закрыть?";
                label3.Show();
                button2.Hide();
                button1.Show();
                textBox1.Show();
            }
            else
            {
                label2.Text = "Осталось поймать: " + (exit_count - move) + " раз";
            }
            if ((move % 2) == 0)
            {
                int y = rand.Next(44, ys - 150);
                int x = rand.Next(12, xs - 150);
                button2.Location = new System.Drawing.Point(x, y);
                move++;
            }
            else
            {
                button2.Location = new System.Drawing.Point((xs - button2.Width) / 2, (ys - button2.Height) / 2);
                move++;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int y = button2.Location.Y;
            int x = button2.Location.Y;
            if (button_jump)
            {
                button_jump = !button_jump;
                button2.Location = new System.Drawing.Point(x - 30, y);
            }
            else
            {
                button_jump = !button_jump;
                button2.Location = new System.Drawing.Point(x + 30, y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (shutdown >= 3)
            {
                timer2.Start();
            }
            if (textBox1.Text == "88005553535")
            {
                Application.Exit();
            }
            else if (textBox1.Text != "")
            {
                shutdown++;
                label3.Text = " — Это Казахстан?\n — Хм, да, это Казахстан...";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(sender, e);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (exit_rofl)
            {
                exit_rofl = !exit_rofl;
                timer2.Interval = 20000;
                panel6.Hide();
                label2.Hide();
                label3.Hide();
                button2.Hide();
                button1.Hide();
                textBox1.Hide();
                label4.Show();
                pictureBox1.Show();
                BackColor = System.Drawing.Color.FromArgb(0, 169, 218);
            }
            else
            {
                timer2.Stop();
                exit_rofl = !exit_rofl;
                panel6.Show();
                label2.Show();
                label3.Show();
                button1.Show();
                textBox1.Show();
                label4.Hide();
                label3.Text = "Нет, ты не угадал пароль!";
                pictureBox1.Hide();
                BackColor = System.Drawing.Color.White;

            }

        }
    }
}
