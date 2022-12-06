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
    public partial class ClickExempel : Form
    {
        int click = 0;
        List<PictureBox> Bombs = new List<PictureBox>();

        public ClickExempel()
        {
            InitializeComponent();
            CreateBomb(100,100);
            timer1.Interval = 1000;
        }

        public void CreateBomb(int x, int y)
        {
           for(int i=0; i < 5; i++)
            {
                PictureBox Bomb = new PictureBox();
                Bomb.BackgroundImage = Resources.bomb;
                Bomb.BackgroundImageLayout = ImageLayout.Stretch;

                Bomb.Location = new Point(x, y);
                Bomb.Size = new Size(80, 80);
                Bomb.Click += Bomb_Click;
                this.Controls.Add(Bomb);
                Bombs.Add(Bomb);
            } 
            
        }

        private void Bomb_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Du träffade");
            timer1.Interval -= 10;
        }

        public void MoveBomb()
        {
            Random rnd = new Random();
            foreach(PictureBox pb in Bombs)
            {
                pb.Left = rnd.Next(0, this.Width - 90);
                pb.Top = rnd.Next(0, this.Height - 90);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveBomb();
        }
    }
}
