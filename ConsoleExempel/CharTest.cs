using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExempel
{
    internal class CharTest
    {
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
        
    }
}
