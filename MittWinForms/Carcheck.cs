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
    public partial class Carcheck : Form
    {
        public Carcheck()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int price = int.Parse(txtPrice.Text);

            if (price < 100000)
            {
                lblResult.Text = "Bilen är rätt billig";
            }
            else if(price > 100000)
            {
                lblResult.Text = "Bilen är nog rätt dyr";
            }
            else
            {
                lblResult.Text = "Bilen måste kosta 100000kr";
            }

        }
    }
}
