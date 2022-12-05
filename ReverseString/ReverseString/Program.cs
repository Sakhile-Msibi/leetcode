using System;

namespace ReverseString
{
    class Program
    {
        public void ReverseAString(char[] s)
        {
            char ch;

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                ch = s[i];
                s[i] = s[j];
                s[j] = ch;
            }

            PrintArray(s);
        }

        public void PrintArray(char[] s)
        {
            foreach (char ch in s)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            char[] s1 = { 'H', 'a', 'n', 'n', 'a', 'h' };

            program.ReverseAString(s);
            program.ReverseAString(s1);
            Console.ReadKey();
        }
    }
}
