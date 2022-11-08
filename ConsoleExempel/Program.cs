using System.Data;

namespace ConsoleExempel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortNr();
            //ArrayEx2();
            
        }

        static void ArrayEx2()
        {
            Console.WriteLine("Skriv in 5st namn");

            string[] names = new string[5];

            names[0] = Console.ReadLine();

            Console.WriteLine("Skriv in namn 2");
            names[1] = Console.ReadLine();

            Console.WriteLine("Skriv in namn 3");
            names[2] = Console.ReadLine();

            Console.WriteLine("Skriv in namn 4");
            names[3] = Console.ReadLine();

            Console.WriteLine("Skriv in namn 5");
            names[4] = Console.ReadLine();

            Console.WriteLine("Namn: " + names[0]+", " + names[1] + ", " + names[2] + ", " + names[3] + ", " + names[4]);

            Random rnd = new Random();

            int tal = rnd.Next(0, 5);

            Console.WriteLine("Det slumpade namnet är: " + names[tal]);
        }

        public static void SortNr()
        {
            Random rnd = new Random();
            int[] tal = new int[7];

            tal[0] = rnd.Next(1, 101);
            tal[1] = rnd.Next(1, 101);
            tal[2] = rnd.Next(1, 101);
            tal[3] = rnd.Next(1, 101);
            tal[4] = rnd.Next(1, 101);
            tal[5] = rnd.Next(1, 101);
            tal[6] = rnd.Next(1, 101);
            Array.Sort(tal);
            
            for(int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine("Tal " + tal[i]);
            }
        }
    }
}