using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Anagrams
{
    internal class Program
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 1)
            {
                IList<IList<string>> str = new List<IList<string>>();
                str.Add(strs);

                return str;
            }

            IList<IList<string>> stri = new List<IList<string>>();
            string[] sortedStrs = new string[strs.Length];
            HashSet<string> list = new HashSet<string>();
            ArrayList list2 = new ArrayList();

            for (int i = 0; i < strs.Length; i++)
            {
                sortedStrs[i] = SortString(strs[i]);
            }

            foreach (string str in sortedStrs)
            {
                if (!list.Contains(str))
                {
                    list.Add(str);
                }
            }

            foreach (string st in list)
            {
                for ( int i = 0; i < strs.Length; i++ ) 
                {
                    if (st.Equals(sortedStrs[i]))
                    {
                        list2.Add(strs[i]);
                    }
                }
                stri.Add((string[])list2.ToArray(typeof(string)));
                list2.Clear();
            }

            return stri;
        }

        public string SortString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }

        public void DisplayList(IList<IList<string>> strings)
        {
            Console.Write("{ ");
            for (int i = 0;i < strings.Count;i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < strings[i].Count; j++)
                {
                    Console.Write(strings[i][j] + " ");
                }
                Console.Write("}");
            }
            Console.Write("}");
            Console.WriteLine();
        }

        public void DisplayArray(string[] strings)
        {
            
            for (int i = 0; i <strings.Length;i++)
            {
                Console.Write(strings[i] + " ");
            }
            
            //Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            program.DisplayList(program.GroupAnagrams(strs));

            string[] strs1 = { " " };
            program.DisplayList(program.GroupAnagrams(strs1));

            string[] strs2 = { "a" };
            program.DisplayList(program.GroupAnagrams(strs2));

            Console.ReadKey();
        }
    }
}