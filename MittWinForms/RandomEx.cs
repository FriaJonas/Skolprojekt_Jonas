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
    public partial class RandomEx : Form
    {
        int interval = 5;
        int start = 0;

        public RandomEx()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start++;

            if (start == 0){
                Bomb.Visible = false;

            }
            if (start == interval)
            {
                start = 0;
                Bomb.Visible = true;
                Random rnd = new Random();
                Bomb.Left = rnd.Next(0, 720);
                Bomb.Top = rnd.Next(0, 400);
            }
        }

        private void Bomb_Click(object sender, EventArgs e)
        {

        }
    }
}
