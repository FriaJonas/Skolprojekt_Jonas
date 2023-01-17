using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MittWinForms
{
    public partial class NyttSlumpTest : Form
    {
        public NyttSlumpTest()
        {
            InitializeComponent();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            LblResult.Text = "";
            //Skapa en array som innehåller lika många positioner som antalet tal som önskas
            int antalTal = (int)NumCount.Value;

            int[] allaTal = new int[antalTal];

            int from = (int)NumFrom.Value;
            int to = (int)NumTo.Value;

            Random rnd = new Random();

            //Loopa antalet gånger som tal ska slumpas
            for(int i=0;i<antalTal;i++)
            {
                //Slumpa tal mellan de förutbestämda talen i NumFrom
                //och NumTo
                //Lägg till talet i Array
                int nyttTal = rnd.Next(from, to + 1);
                if (allaTal.Contains(nyttTal))
                {
                    //Lägg inte till talet
                    i--;
                }
                else
                {
                    allaTal[i] = nyttTal;
                }
                
            }

            //Sortera array
            Array.Sort(allaTal);
            //loopa igen och skriv ut alla talen
            //i listan i Lblresult

            foreach(int t in allaTal) 
            {
                 LblResult.Text += t.ToString()+", ";
            }

        }
    }
}
