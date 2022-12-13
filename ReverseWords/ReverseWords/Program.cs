using System;
using System.Text;

namespace ReverseWords
{
    class Program
    {
        public string ReverseWordsInASentence(string s)
        {
            StringBuilder reverseString = new StringBuilder();
            string[] stringS = s.Split(" ");

            for (int i = stringS.Length - 1; i >= 0; i--)
            {
                if (stringS[i] != "")
                {
                    reverseString.Append(stringS[i] + " ");
                }
            }

            return reverseString.ToString().Trim();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "  a good   example  ";

            Console.WriteLine(program.ReverseWordsInASentence(s));
            Console.ReadKey();
        }
    }
}
