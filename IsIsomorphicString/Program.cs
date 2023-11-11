using System.Collections;
using System.Runtime.InteropServices;

namespace IsIsomorphicString
{
    internal class Program
    {
        public bool IsIsomorphic(string s, string t)
        {
            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();

            Dictionary<char, int> ht = new Dictionary<char, int>();
            Dictionary<char, int> ht2 = new Dictionary<char, int>();

            for (int i = 0; i < sChars.Length; i++)
            {
                if (!ht.ContainsKey(sChars[i]))
                {
                    ht.Add(sChars[i], i);
                }

                if (!ht2.ContainsKey(tChars[i]))
                {
                    ht2.Add(tChars[i], i);
                }

                if (ht.ContainsKey(sChars[i]) && ht2.ContainsKey(tChars[i]))
                {
                    int sValue = -1;
                    int tValue = -1;
                    bool sBoolean = ht.TryGetValue(sChars[i], out sValue);
                    bool tBoolean = ht2.TryGetValue(tChars[i], out  tValue);

                    if (sValue != tValue)
                        return false;

                }
            }

            return (ht.Count == ht2.Count);
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            //string s = "egg";
            //string t = "add";

            //Console.WriteLine(program.IsIsomorphic(s, t));

            //string s1 = "foo";
            //string t1 = "bar";

            //Console.WriteLine(program.IsIsomorphic(s1, t1));

            //string s2 = "paper";
            //string t2 = "title";

            //Console.WriteLine(program.IsIsomorphic(s2, t2));

            string s3 = "bbbaaaba";
            string t3 = "aaabbbba";

            Console.WriteLine(program.IsIsomorphic(s3, t3));

            //string s4 = "ffeffcef";
            //string t4 = "eefeedef";

            //Console.WriteLine(program.IsIsomorphic(s4, t4));

            //string s5 = "ffeffce";
            //string t5 = "eefeede";

            //Console.WriteLine(program.IsIsomorphic(s5, t5));

            //string s6 = "papap";
            //string t6 = "titii";

            //Console.WriteLine(program.IsIsomorphic(s6, t6));
        }
    }
}