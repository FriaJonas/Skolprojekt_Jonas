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
    public partial class Slump2 : Form
    {
        int antalClick = 0;
        int slumpTal = 0;

        public Slump2()
        {
            InitializeComponent();
            Random random = new Random();
            slumpTal = random.Next(1, 101);
            int tal2 = 100;
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            antalClick++;
            lblNrOfClick.Text = antalClick.ToString();
            lblRandom.Text = slumpTal.ToString();
        }
    }
}
