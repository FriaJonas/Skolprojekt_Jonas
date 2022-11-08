using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExempel
{
    internal class ArrayExample
    {
        public static void Start()
        {
            int number = 12;

            string name = "Jonas";
            string name2 = "Kalle";
            string name3 = "Stina";

            string[] names = new string[] { "Jonas", "Kalle", "Stina" }; //Position 0,1,2

            Console.WriteLine(names[0]);
            Console.WriteLine(names[2]);

            string[] Cities = new string[10];

            Cities[0] = "Stockholm";
            Cities[1] = "New York";
            Cities[9] = "New York";

            int[] numbers = new int[7];

            Random rnd = new Random();

            numbers[0] = rnd.Next(1, 33);
            numbers[1] = rnd.Next(1, 33);

            int[] massatal = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Array.Sort(names);

            if (names.Contains("Jonas"))
            {
                Console.WriteLine("Arrayen innehöll strängen Jonas");
            }

            if (massatal.Contains(4))
            {
                //Gör detta....
            }
        }
    }
}
