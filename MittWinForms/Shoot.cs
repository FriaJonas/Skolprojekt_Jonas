using MittWinForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace MittWinForms
{
    public partial class Shoot : Form
    {
        List<PictureBox> Shoots = new List<PictureBox>();

        SoundPlayer player;
        public Shoot()
        {
            InitializeComponent();
            //System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            //System.IO.Stream s = a.GetManifestResourceStream(a.FullName+".explosionSound.wav");
            //player = new SoundPlayer(s);
           // SoundPlayer player = new SoundPlayer(@"C:\Users\JonasNilsson\OneDrive - Watma Education\Programmering\MittSkolProjekt_Jonas\Skolprojekt_Jonas\MittWinForms\Resources\explosionSound.wav");
        }



        private void Shoot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Ship.Left -= 5;
            }
            else if(e.KeyCode== Keys.Right)
            {
                Ship.Left+= 5;
            }
            Ship.Invalidate();
            if (e.KeyCode == Keys.Space)
            {
                //Skjuta!
                CreateShot(Ship.Left + 50);
                //player.Play();
            }
            
        }

        public void CreateShot(int left)
        {
            PictureBox pb = new PictureBox();
            pb.BackgroundImage = Resources.Star;
            pb.Size = new Size(20, 20);
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Location = new Point(left,Ship.Top);
            this.Controls.Add(pb);
            Shoots.Add(pb);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image img = Ship.Image;
            img = RotateImage(img, 60);
            Ship.Image = img;
            foreach (var shot in Shoots)
            {
                shot.Top -= 5;
                if (shot.Top < 0)
                {
                    shot.Tag="x";                    
                }

                shot.Refresh();
            }
            Shoots.RemoveAll(x => x.Tag == "x");
            this.Refresh();   
        }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                Ship.Image = Resources.spaceship2;
            }
            timer1.Enabled = !timer1.Enabled;

        }
    }
}
