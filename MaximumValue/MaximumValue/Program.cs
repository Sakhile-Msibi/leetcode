using System;
using System.Linq;

namespace MaximumValue
{
    class Program
    {
        public int MaximumValueString(string[] strs)
        {
            int strLen = 0;
            int maxLen = 0;

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Any(x => char.IsLetter(x)))
                {
                    strLen = strs[i].Length;

                    if (strLen > maxLen)
                        maxLen = strLen;
                }
                else
                {
                    strLen = Convert.ToInt32(strs[i]);

                    if (strLen > maxLen)
                        maxLen = strLen;
                } 
            }

            return maxLen;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string[] strs = { "alic3", "bob", "3", "4", "00030" };
            string[] strs1 = { "1", "01", "001", "0001" };

            Console.WriteLine(program.MaximumValueString(strs));
            Console.WriteLine(program.MaximumValueString(strs1));
            Console.ReadKey();
        }
    }
}
