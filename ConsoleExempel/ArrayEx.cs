using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExempel
{
    internal class ArrayEx
    {
        public static void Start()
        {
            string name = "Kalle";


            string name2 = "Stina";
            string name3 = "Jocke";

            string[] names = new string[10];
            names[0] = "Kalle";
            names[1] = "Putte";

            string[] Cities = new string[] { "Stockholm", "Malmö" };

            int[] massatal = new int[] { 1, 2, 3, 4, 5, 6 };


            int tal = 100;

            Random rnd = new Random();

            int[] slumptal = new int[7];

            slumptal[0] = rnd.Next(1, 33);

            slumptal[1] = rnd.Next(1, 33);

            slumptal[6] = rnd.Next(1, 33);

                






        }
        
    }
}
