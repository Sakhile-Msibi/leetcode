using System;
using System.Collections.Generic;

namespace RomanToIntUsingDictionary
{
    class Program
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> roman = new Dictionary<char, int> 
            {
                {'I', 1},
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && roman[s[i]] >= roman[s[i + 1]])
                {
                    sum += roman[s[i]];
                }
                else if (i + 1 < s.Length && roman[s[i]] < roman[s[i + 1]])
                {
                    sum -= roman[s[i]];
                }
                else
                {
                    sum += roman[s[i]];
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "III";
            string s1 = "LVIII";
            string s2 = "MCMXCIV";
            string s3 = "IX";
            string s4 = "DCXXI";
            string s5 = "MMMCC";

            Console.WriteLine(program.RomanToInt(s));
            Console.WriteLine(program.RomanToInt(s1));
            Console.WriteLine(program.RomanToInt(s2));
            Console.WriteLine(program.RomanToInt(s3));
            Console.WriteLine(program.RomanToInt(s4));
            Console.WriteLine(program.RomanToInt(s5));
            Console.ReadKey();
        }
    }
}
