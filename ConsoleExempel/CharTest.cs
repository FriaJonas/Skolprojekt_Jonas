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

            //FirstAndLast(input);
            //BackWord(input);
            //Vertical(input);
            //CountChar(input);

            //DrawStringChars(input);

            //string pass = DrawChars();
            //Console.WriteLine(pass);

            string newText = "";
            char[] tecken = input.ToCharArray();

            foreach(char t in tecken)
            {
                int code = (int)Convert.ToChar(t);
                Console.WriteLine("Kod: " + code);

                newText += Convert.ToChar(code+2);
            }
            Console.WriteLine(newText);
        }

        public static bool CheckChar(char tecken, string text)
        {
            bool result = false;
            if (text.Contains(tecken))
            {
                result = true;
            }
            return result;
        }

        public static void FirstAndLast(string text)
        {
            Console.WriteLine(text[0]);
            Console.WriteLine(text[text.Length - 1]);
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
            int lengh = text.Length;
            for(int i=0;i<lengh;i++)
            {
                Console.WriteLine(text[i]);
            }
        }
        public static void CountChar(string text)
        {
            //Räkna ut hur många gånger å, ä , ö finns
            //Skriv ut antalet
            int charÅ = 0;
            int charÄ = 0;
            int charÖ = 0;
            for(int i=0;i<text.Length;i++)
            {
                if (text[i] == 'å')
                {
                    charÅ++;
                }
                if (text[i] == 'ä')
                {
                    charÄ++;
                }
                if (text[i] == 'ö' | text[i]=='Ö')
                {
                    charÖ++;
                }
            }
            Console.WriteLine($"antal å:{charÅ}, antal ä {charÄ}, antal Ö{charÖ}");
        }

        public static bool CheckIfExcist(char tecken, string text)
        {
            bool result = false;
            //Kod för att kolla om tecknet finns:
            if (text.Contains(tecken)){
                result = true;
            }

            return result;
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
        
        public static string DrawChars()
        {
            string tecken = "";
            for(int i = 49; i < 57; i++)
            {
                tecken += Convert.ToChar(i);
            }
           
            return tecken;
        }
        public static void DrawStringChars(string text)
        {
            //Vi gör om texten till en char array
            char[] chars = text.ToCharArray();

            // En ny tom sträng för att slå ihop igen:
            string newText = "";

            //Vi loopar sedan igenom varje tecken och skriver ut koden:
            foreach (char c in chars)
            {
                int code = (int)Convert.ToChar(c);
                Console.WriteLine("Kod: " + code);

                //Vi omvandlar tillbaka koden till en char
                char ch = Convert.ToChar(code+3);
                //Lägger till ch till strängen newText
                newText += ch;
            }
            //Vi skriver ut newText och då borde det bli samma som innan:
            Console.WriteLine(newText);
        }
    }
}
