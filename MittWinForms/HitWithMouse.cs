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
using Windows.Management;

namespace MittWinForms
{
    public partial class HitWithMouse : Form
    {
        //vi definierar variabenln för vårt Ufo
        //Precis som vi definierar en variabel för en sträng eller heltal så definierar vi en PictureBox på samma sätt
        PictureBox Ufo;

        PictureBox Ufo2; 
        

        public HitWithMouse()
        {
            InitializeComponent();
            CreateUfo();
        }

        private void CreateUfo()
        {
            //Vi skapar ett nytt objekt av en PicureBox
            Ufo = new PictureBox();
            Ufo.BackgroundImage = Resources.ufo;
            Ufo.Location = new Point(100,100);
            Ufo.Width = 100;
            Ufo.Height = 100;
            Ufo.BackgroundImageLayout= ImageLayout.Stretch;
            this.Controls.Add(Ufo);
            Ufo.Click += Ufo_Click;

            Ufo2 = new PictureBox();
            Ufo2.BackgroundImage = Resources.ufo;
            Ufo2.Location = new Point(100, 100);
            Ufo2.Width = 100;
            Ufo2.Height = 100;
            Ufo2.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(Ufo2);
            Ufo2.Click += Ufo_Click;

        }

        private void Ufo_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Du träffade");
        }

        private void MoveUfo()
        {
            Random ran = new Random();
            Ufo.Left = ran.Next(0, this.Width-100);
            Ufo.Top = ran.Next(0, this.Height-100);

            Ufo2.Left = ran.Next(0, this.Width - 100);
            Ufo2.Top = ran.Next(0, this.Height - 100);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // MoveUfo();
            //rotate();
        }
        //private void rotate()
        //{
        //    Image img = pictureBox1.Image;
        //    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
        //    pictureBox1.Image = img;
        //}
    }
}
