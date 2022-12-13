using System;
using System.Linq;
using System.Text;

namespace ReverseEachWord
{
    class Program
    {
        public string ReverseWords(string s)
        {
            StringBuilder stringS = new StringBuilder();
            string[] str = s.Split(" ");

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = str[i].Length - 1; j >= 0 ; j--)
                {
                    stringS.Append(str[i][j]);
                }
                stringS.Append(" ");
            }

            return stringS.ToString().Trim();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "God Ding";
            string s1 = "Let's take LeetCode contest";

            Console.WriteLine(program.ReverseWords(s));
            Console.WriteLine(program.ReverseWords(s1));
            Console.ReadKey();
        }
    }
}
