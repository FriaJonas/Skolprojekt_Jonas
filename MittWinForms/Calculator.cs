using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MittWinForms
{
    public partial class Calculator : Form
    {
        int tal = 0;
        public Calculator()
        {
            InitializeComponent();
            tal = 5;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal tal1 = num1.Value + num2.Value;
            lblSumma.Text = tal1.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                //Här testar vi att dividera
                decimal tal1 = num1.Value / num2.Value;

                //Skriver ut summan i lblSumma
                lblSumma.Text = tal1.ToString();
            }
            catch (Exception ee) 
            {
                lblSumma.Text = "Det gick inte: " + ee.Message;
            }
            
        }
    }
}
