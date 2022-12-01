using System;
using System.Collections.Generic;
using System.Text;

namespace LengthOfLongestSubstring
{
    class Program
    {
        public int LongestSubstring(string s)
        {
            int maxLength = 0;
            StringBuilder subStr = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (subStr.Length > 0)
                    {
                        if (!subStr.ToString().Contains(s[j]))
                        {
                            subStr.Append(s[j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        subStr.Append(s[j]);
                    }
                }

                if (subStr.Length > maxLength)
                    maxLength = subStr.Length;

                subStr = new StringBuilder();
            }

            return maxLength;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "abcabcbb";
            string s1 = "bbbbb";
            string s2 = "pwwkew";
            string s3 = "";

            Console.WriteLine(program.LongestSubstring(s));
            Console.WriteLine(program.LongestSubstring(s1));
            Console.WriteLine(program.LongestSubstring(s2));
            Console.WriteLine(program.LongestSubstring(s3));
            Console.ReadKey();
        }
    }
}
