﻿using System.Data;

namespace ConsoleExempel
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            //ArrayEx.Start();
            CountDown();
        }

        public static void CountDown()
        {
            // loopa från 10-1
            for (int i = 100; i < 0; i+=20)
            {
                Console.WriteLine("Tal " + i);
            }
            Console.WriteLine("Nu kör vi");
        }

        public static void RandomNr()
        {
            //Skapa slumpgenerator
            Random ran = new Random();
            
            int ranNr = ran.Next(1,101);

            bool success = false;
            Console.WriteLine("Gissa tal");
            int guess = 0;

            while (success == false)
            {
                string nr = Console.ReadLine();
                int intNr = int.Parse(nr);

                if(intNr>ranNr)
                {
                    Console.WriteLine("För högt");
                }
                else if(intNr<ranNr) {
                    Console.Write("För lågt");
                }
                else
                {
                    Console.WriteLine("Grattis - du gissade rätt!");
                    success= true;
                }
                guess++;
            }
            Console.WriteLine("Klart, du gissade rätt efter"+guess+"Försök");

        }

        static void SummeraTal(int tal1, int tal2)
        {
            int summa=tal1 + tal2;
            Console.WriteLine("Talet blir: "+summa);
        }

        static int SummeraTalIgen(int tal1,int tal2)
        {
            int summa = tal1 * tal2;
            return summa;
        }

        static void MinFunktion()
        {

        }

        static void EnFunktion()
        {
            Console.WriteLine("Hej hopp");
        }

        static void EnAnnanFunktion(string ettName)
        {
            Console.WriteLine("Namn:" + ettName);
        }


    }
}