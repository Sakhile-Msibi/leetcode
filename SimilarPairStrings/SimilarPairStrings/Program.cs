using System;
using System.Linq;
using System.Text;

namespace SimilarPairStrings
{
    class Program
    {
        public int SimilarPairs(string[] words)
        {
            int counter = 0;

            if (words.Length > 1)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    char[] a = words[i].ToArray();
                    a = a.Distinct().ToArray();
                    Array.Sort(a);
                    StringBuilder word = new StringBuilder();

                    for (int j = 0; j < a.Length; j++)
                    {
                        word.Append(a[j]);
                    }

                    words[i] = word.ToString();
                }

                


                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            if (words[i].Contains(words[j]))
                            {
                                counter++;
                            }
                        }
                    }
                }
            }

            return counter;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string[] words = { "aabb", "ab", "ba" };
            string[] words1 = { "aba", "aabb", "abcd", "bac", "aabc" };
            string[] words2 = { "nba", "cba", "dba" };

            Console.WriteLine(program.SimilarPairs(words));
            Console.WriteLine(program.SimilarPairs(words1));
            Console.WriteLine(program.SimilarPairs(words2));
            Console.ReadKey();
        }
    }
}
