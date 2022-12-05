using System;

namespace StrStr
{
    class Program
    {
        public int StrStrImplementation(string haystack, string needle)
        {
            return haystack.IndexOf(needle);

            //int counter = 0;
            //int ans = -1;

            //if (needle.Length > haystack.Length)
            //    return ans;

            //for (int i = 0; i < haystack.Length; i++)
            //{
            //    if (haystack[i] == needle[0])
            //    {
            //        for (int j = 0, k = i; j < needle.Length && k < haystack.Length && haystack[k] == needle[j]; j++, k++)
            //        {
            //            counter++;
            //        }

            //        if (counter == needle.Length)
            //        {
            //            ans = i;
            //            return ans;
            //        }
            //        counter = 0;
            //    }
            //}

            //return -1;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string haystack = "sadbutsad";
            string needle = "sad";

            string haystack1 = "sabudbutsad";
            string needle1 = "but";

            string haystack2 = "mississippi";
            string needle2 = "issip";

            Console.WriteLine(program.StrStrImplementation(haystack, needle));
            Console.WriteLine(program.StrStrImplementation(haystack1, needle1));
            Console.WriteLine(program.StrStrImplementation(haystack2, needle2));

            Console.ReadKey();
        }
    }
}
