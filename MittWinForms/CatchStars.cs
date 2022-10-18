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
        int Seconds = 60000;
        int Points = 0;

        public CatchStars()
        {
            InitializeComponent();
            RedrawStar();
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
            Star.Top += 25;
            
            //Om skärnan passerat botten.... rita om 
            if(Star.Top > 600)
            {
                RedrawStar();
            }

            if (Star.Bounds.IntersectsWith(Player.Bounds))
            {
                Points += 1;
                RedrawStar();
            }

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

        private void RedrawStar()
        {
            Random r = new Random();
            Star.Left = r.Next(10, 880);
            Star.Top = r.Next(10, 250);
        }
    }
}
