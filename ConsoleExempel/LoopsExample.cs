using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExempel
{
    internal class LoopsExample
    {
        public static void ForLoppExample()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Klar");

        }

        public static void ForLoopExample2()
        {
            Random ran = new Random();
            //Skapa en int array för 10 nummer
            // 0,1,2,3.....9
            int[] Numbers = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Numbers[i] = ran.Next(1,33); //Blir ett tal mellan 1-32
                Console.WriteLine("Det nya talet på position "+i+" är"+Numbers[i]);
            }

            ForEachExample(Numbers);
        }

        public static void ForEachExample(int[] Numbers)
        {
            foreach(int i in Numbers)
            {
                Console.WriteLine("tal - " + i);
            }
            Console.WriteLine("Foreach - ready");
        }

        public static void WhileExample()
        {
            string password = "GodJul";
            bool YouPass = false;
            Console.WriteLine("Ange ett lösenord för att logga in...");

            while (YouPass == false)
            {
                string inputPass = Console.ReadLine();
                if(inputPass == password)
                {
                    YouPass = true;
                }
                else
                {
                    Console.WriteLine("Fel lösen, försök igen");
                }
            }
            Console.WriteLine("Rätt lösen, du är inloggad!");
        }
    }
}
