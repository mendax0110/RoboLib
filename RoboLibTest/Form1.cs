using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboLib;

namespace RoboLibTest
{
    public partial class Roboter : Form
    {

        Robot R1;
        Point[] punkte;
        int i;
        public Roboter()
        {
            InitializeComponent();
            R1 = new Robot(10, Color.Green, pictureBox_room.Width, pictureBox_room.Height);
            punkte = new Point[50000];
            timer1.Interval = 50;
            i = 0;
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            R1.RotateLeft();
            pictureBox_room.Invalidate();
        }
        private void button_move_Click(object sender, EventArgs e)
        {
            R1.Move();
            pictureBox_room.Invalidate();
        }

        private void button_faster_Click(object sender, EventArgs e)
        {
            R1.SpeedUp();
            label_speed.Text = "Speed: " + R1.Speed;
        }

        private void button_slower_Click(object sender, EventArgs e)
        {
            R1.SpeedDown();
            label_speed.Text = "Speed: " + R1.Speed;
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            R1.RotateRight();
            pictureBox_room.Invalidate();
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            R1.StartAuto();
            timer1.Start();
            button_slower.Enabled = false;
            button_faster.Enabled = false;
            button_left.Enabled = false;
            button_right.Enabled = false;
            button_move.Enabled = false;
            button_party.Enabled = false;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
           
            R1.StopAuto();
            timer1.Stop();
            button_slower.Enabled = true;
            button_faster.Enabled = true;
            button_left.Enabled = true;
            button_right.Enabled = true;
            button_move.Enabled = true;
            button_party.Enabled = true;
        }

        Point punkt;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            label_speed.Text = "Speed: " + R1.Speed;
            Graphics dev = e.Graphics;
            punkt.X = R1.X;
            punkt.Y = R1.Y;
            punkte[i] = punkt;
            i++;
            Pen stift = new Pen(Brushes.White, R1.Radius * 2);
            for (int i = 1; i < punkte.Length; i++)
            {
                if (!(punkte[i - 1].X == 0 && punkte[i - 1].Y == 0 || punkte[i].X == 0 && punkte[i].Y == 0))
                {
                    dev.DrawLine(stift, punkte[i - 1], punkte[i]);
                    dev.FillEllipse(Brushes.White, punkte[i].X - R1.Radius, punkte[i].Y - R1.Radius, 2*R1.Radius,2*R1.Radius);
                }

            }
            if (i == punkte.Length - 2)
                i = 0;
            R1.DrawRobot(dev);
            

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox_room.Invalidate();
        }

        private void button_party_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < punkte.Length; i++)
            {
                punkte[i].X = 0;
                punkte[i].Y = 0;
            }
            timer1.Stop();
            pictureBox_room.Invalidate();
        }
    }
}
