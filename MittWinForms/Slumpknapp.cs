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
    public partial class Slumpknapp : Form
    {
        int antalTryck = 0;
        int slumptal = 0;

        public Slumpknapp()
        {
            InitializeComponent();
            //MessageBox.Show("Vi startar....");
            Random rand = new Random();
            slumptal = rand.Next(1, 101);
            lblSlumptal.Text = slumptal.ToString();
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            antalTryck++;
            lblAntalTryck.Text = antalTryck.ToString();

            Random rand = new Random();
            slumptal = rand.Next(1, 101);
            lblSlumptal.Text = slumptal.ToString();
        }
    }
}
