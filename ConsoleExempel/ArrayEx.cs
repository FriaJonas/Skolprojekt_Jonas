using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExempel
{
    internal class ArrayEx
    {
        public ArrayEx() {
            Start();
        }
        public static void Start()
        {
            string[] namn = new string[] { "Kalle", "Pelle", "Stina" };

            Console.WriteLine(namn[2]);


            int[] massatal = new int[] {1,2,3,4,5};
            Console.WriteLine(massatal[3]);



            int[] ints= new int[4];

            ints[0] = 10;
            ints[1] = 20;
            ints[2] = 30;
            ints[3] = 40;   

            int ettNyttTal = ints[1];
        }

    }
}
