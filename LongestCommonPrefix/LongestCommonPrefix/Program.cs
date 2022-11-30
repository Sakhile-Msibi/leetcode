using System;
using System.Linq;
using System.Text;

namespace LongestCommonPrefix
{
    class Program
    {
        public string FindLongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
                return strs[0];

            int minLen = int.MaxValue;
            StringBuilder str = new StringBuilder();
            int counter = 0;

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < minLen)
                {
                    str.Clear();
                    minLen = strs[i].Length;
                    str.Append(strs[i]);
                }
            }

            while (str.Length > 0)
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    if (strs[i].Substring(0, str.Length) == str.ToString())
                        counter++;
                }

                if (counter == strs.Length)
                    return str.ToString();

                counter = 0;
                str.Remove(str.Length - 1, 1);
            }

            return "";
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string[] strs = { "dog", "racecar", "car" };
            string[] strs1 = { "flower", "flow", "flight" };
            string[] strs2 = { "reflower", "flow", "flight" };

            Console.WriteLine(program.FindLongestCommonPrefix(strs));
            Console.WriteLine(program.FindLongestCommonPrefix(strs1));
            Console.WriteLine(program.FindLongestCommonPrefix(strs2));
            Console.ReadKey();
        }
    }
}
