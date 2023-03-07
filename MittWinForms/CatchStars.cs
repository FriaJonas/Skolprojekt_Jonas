using MittWinForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MittWinForms
{
    public partial class CatchStars : Form
    {
        List<PictureBox> bombs = new List<PictureBox>();
        int Seconds = 60000;
        int Points = 0;
        Random random = new Random();

        public CatchStars()
        {
            for(int i = 0; i < 5; i++)
            {
                PictureBox pb = new PictureBox();
                pb.BackgroundImage = Resources.bomb;
                pb.Size = new Size(80, 80);
                pb.BackgroundImageLayout = ImageLayout.Stretch;
                pb.Location = new Point( random.Next(1, 800),10);
                this.Controls.Add(pb);
                bombs.Add(pb);
            }
            InitializeComponent();
            RedrawBomb();
        }

        private void CatchStars_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.A && Player.Left>=15)
            {
                Player.Left -= 15;
            }
            else if(e.KeyCode==Keys.D && Player.Left<800)
            {
                Player.Left += 15;
            }
            else if(e.KeyCode == Keys.W)
            {
                Player.Top -= 15;
            }
            else if(e.KeyCode == Keys.Z)
            {
                Player.Top += 15;
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            RedrawBomb();
            //Minskar timer
            Seconds -= timer1.Interval;
            if (Seconds <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Game Over!");
            }
            lblTimer.Text = $"Timer: {Seconds/1000}";
            lblPoints.Text = $"Poäng: {Points}";
        }

        private void RedrawBomb()
        {
            foreach(PictureBox pb in bombs)
            {
                int speed = random.Next(1, 30);
                pb.Top += speed;
                if (pb.Top > 600)
                {
                    pb.Top = 20;
                    pb.Left = random.Next(1, this.Width-100);
                }
                if (pb.Bounds.IntersectsWith(Player.Bounds))
                {
                    Points+=1000;
                    pb.Top = 0;
                    pb.Left = random.Next(1, this.Width - 100);
                }
            }

        }
    }
}
