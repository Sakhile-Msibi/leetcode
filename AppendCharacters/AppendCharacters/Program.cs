using System;
using System.Text;

namespace AppendCharacters
{
    class Program
    {
        public int AppendCharactersInString(string s, string t)
        {
            int i;
            int j;

            for (i = 0, j = 0; i < s.Length && j < t.Length; i++)
            {
                if (s[i] == t[j])
                    j++;
            }

            return t.Length - j;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "coaching";
            string t = "coding";

            Console.WriteLine(program.AppendCharactersInString(s, t));
            Console.ReadKey();
        }
    }
}
