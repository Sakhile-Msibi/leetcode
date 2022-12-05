using System;
using System.Collections.Generic;
using System.Linq;

namespace HalvesAreAlike
{
    class Program
    {
        public bool AlikeHalves(string s)
        {
            char[] arr = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int firstHalf = 0;
            int secondHalf = 0;

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (arr.Contains(s[i]))
                    firstHalf++;

                if (arr.Contains(s[j]))
                    secondHalf++;
            }

            if (firstHalf == secondHalf)
                return true;

            return false;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "book";
            string s1 = "textbook";

            Console.WriteLine(program.AlikeHalves(s));
            Console.WriteLine(program.AlikeHalves(s1));
            Console.ReadKey();
        }
    }
}
