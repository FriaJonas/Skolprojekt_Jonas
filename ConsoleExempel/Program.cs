using System.Data;

namespace ConsoleExempel
{
    internal class Program
    {
        static int EttTal = 12;
        static void Main(string[] args)
        {
            CharTest.Start();
          
        }
       
        public static void EnFunktion()
        {
           
            Console.WriteLine("hello world "+EttTal);
        }
        public static void EnAnnanFunktion(string name)
        {
            Console.WriteLine("Du skrev: "+name);
        }
    }
}