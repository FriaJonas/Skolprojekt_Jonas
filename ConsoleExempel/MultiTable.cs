using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExempel
{
    internal class MultiTable
    {
        public static void Start()
        {
            //Be användaren skriva in en siffra
            Console.WriteLine("Skriv in en siffra:");
            string siffra = Console.ReadLine();
            int number = int.Parse(siffra);

            for(int i =1;i<=12;i++)
            {
                int svar = number * i;
                Console.WriteLine(i+" x "+number+" = "+ svar);

            }
            Console.WriteLine("KLar!");

            Console.WriteLine("Vill du testa en annan?");
            string answer = Console.ReadLine();
            
            if (answer =="y")
            {
                Start();
            }
            else
            {
                Console.WriteLine("Ok.. strunta i det då...");
            }
        }
    }
}
