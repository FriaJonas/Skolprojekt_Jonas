using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExempel
{
    public  class CharTest
    {

        public static void ViTestar()
        {
            Console.WriteLine("Skriv in en text:");
            string input = Console.ReadLine();
            BackWord(input);
            Vertical(input);
            CountChar(input);
        }

        public static void BackWord(string text) 
        { 
            //Skapa en algoritm som vänder på texten och skriver*
            //ut den baklänges.
            //Tips - använd for-loopen baklänges!
            for(int i=text.Length-1;i>=0; i--)
            {
                Console.Write(text[i]);
            }
        }
        public static void Vertical(string text)
        {
            //Skriv ut texten vertilkalt
            //Precis enligt genomgången
            //For-loop för varje tecken i strängen
        }
        public static void CountChar(string text)
        {
            //Räkna ut hur många gånger å, ä , ö finns
            //Skriv ut antalet

            //
        }



        Char tecken = 'J';
        public static void Start()
        {
            Console.WriteLine("Skriv ett ord");
            string word1 = Console.ReadLine();
            Console.WriteLine("Skriv ord 2");
            string word2 =Console.ReadLine();

            Char[] letters1 = word1.ToCharArray();
            Char[] letters2 = word2.ToCharArray();

            string newWord = "";
            int pos = 0;
            foreach(char s in letters1)
            {
                newWord+= s;
                try
                {
                    newWord+= letters2[pos];
                }
                catch { }
                pos++;
            }
            if(pos<=letters2.Length) 
            {
                for(int i=pos; i<letters2.Length; i++)
                {
                    newWord+= letters2[i];
                }
            }
            Console.WriteLine(newWord);
        }

        public static void Test2()
        {
            string name = "JOnas";
            bool find = name.Contains('O');
        }
        
    }
}
