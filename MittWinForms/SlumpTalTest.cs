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
    public partial class SlumpTalTest : Form
    {
        int AntalGissningar = 0;
        int Slumptal = 0;

        public SlumpTalTest()
        {
            InitializeComponent();
            Random random = new Random();
            Slumptal = random.Next(1, 101);

        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            int tal = (int)numGuess.Value;
            AntalGissningar++;
            lblCount.Text = AntalGissningar.ToString();

            if(tal>Slumptal)
            {
                lblMessage.Text = "Talet är för högt";
            }
            else if (tal < Slumptal)
            {
                lblMessage.Text = "Talet är för lågt";
            }
            else
            {
                lblMessage.Text = "Du gissade rätt efter " + AntalGissningar;
            }
        }

        private void SlumpTalTest_Load(object sender, EventArgs e)
        {

        }
    }
}
