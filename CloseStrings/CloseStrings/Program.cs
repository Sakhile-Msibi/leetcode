using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloseStrings
{
    class Program
    {
        public bool FindCloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }
            else
            {
                int counter = 0;
                int counterword1 = 0;
                int counterword2 = 0;

                char[] word1Tochar = word1.ToCharArray();
                char[] word2Tochar = word2.ToCharArray();

                Array.Sort(word1Tochar);
                Array.Sort(word2Tochar);

                List<int> word1List = new List<int>();
                List<int> word2List = new List<int>();

                for (int i = 0; i < word1Tochar.Length; i++)
                {
                    for (int j = i; j < word1Tochar.Length && word1Tochar[i] == word1Tochar[j]; j++)
                    {
                        counterword1++;
                    }

                    word1List.Add(counterword1);
                    i += counterword1 - 1;
                    counterword1 = 0;
                }

                for (int i = 0; i < word2Tochar.Length; i++)
                {
                    for (int j = i; j < word2Tochar.Length && word2Tochar[i] == word2Tochar[j]; j++)
                    {
                        counterword2++;
                    }

                    word2List.Add(counterword2);
                    i += counterword2 - 1;
                    counterword2 = 0;
                }

                word1List.Sort();
                word2List.Sort();

                for (int i = 0; i < word2List.Count; i++)
                {
                    if (word1List[i] == word2List[i])
                        counter++;
                }

                if (counter == word1List.Count)
                {
                    word1Tochar = word1Tochar.Distinct().ToArray();
                    word2Tochar = word2Tochar.Distinct().ToArray();

                    if (word1Tochar.Length == word2Tochar.Length)
                    {
                        counter = 0;
                        for (int i = 0; i < word1Tochar.Length; i++)
                        {
                            if (word1Tochar[i] == word2Tochar[i])
                            {
                                counter++;
                            }
                        }

                        if (counter == word1Tochar.Length)
                            return true;
                    } 
                }
                    
            }

            return false;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string word1 = "abc";
            string word2 = "bca";
            string word3 = "abbzzca";
            string word4 = "babzzcz";
            string word5 = "cabbba";
            string word6 = "abbccc";
            string word7 = "cabbba";
            string word8 = "aabbss";
            string word9 = "uau";
            string word10 = "ssx";

            Console.WriteLine(program.FindCloseStrings(word1, word2));
            Console.WriteLine(program.FindCloseStrings(word3, word4));
            Console.WriteLine(program.FindCloseStrings(word5, word6));
            Console.WriteLine(program.FindCloseStrings(word7, word8));
            Console.WriteLine(program.FindCloseStrings(word9, word10));
            Console.ReadKey();
        }
    }
}
