using System;
using System.Text;

namespace RemoveDuplicates
{
    class Program
    {
        public string removeDuplicates(string s)
        {
            if (s.Length == 1)
                return s;

            StringBuilder newS = new StringBuilder(s);

            for (int i = 0; i < newS.Length - 1; i++)
            {
                if (newS[i] == newS[i + 1])
                {
                    newS.Remove(i, 2);

                    if (i != 0)
                        i -= 2;
                    else
                        i--;
                }
            }

            return newS.ToString();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "abbaca";
            string s1 = "azxxzy";
            string s3 = "pp";
            string s4 = "RLLR";

            Console.WriteLine(program.removeDuplicates(s));
            Console.WriteLine(program.removeDuplicates(s1));
            Console.WriteLine(program.removeDuplicates(s3));
            Console.WriteLine(program.removeDuplicates(s4));
        }
    }
}
