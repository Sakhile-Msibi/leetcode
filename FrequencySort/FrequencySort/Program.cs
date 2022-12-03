using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrequencySort
{
    class Program
    {
        public string SortByFrequency(string s)
        {
            if (s.Length <= 2)
            {
                return s;
            }
            else
            {
                Dictionary<char, int> chars = new Dictionary<char, int>
                {
                    {'a', 0}, {'b', 0}, {'c', 0}, {'d', 0}, {'e', 0}, {'f', 0}, {'g', 0},
                    {'h', 0}, {'i', 0}, {'j', 0}, {'k', 0}, {'l', 0}, {'m', 0}, {'n', 0},
                    {'o', 0}, {'p', 0}, {'q', 0}, {'r', 0}, {'s', 0}, {'t', 0}, {'u', 0},
                    {'v', 0}, {'w', 0}, {'x', 0}, {'y', 0}, {'z', 0},

                    {'A', 0}, {'B', 0}, {'C', 0}, {'D', 0}, {'E', 0}, {'F', 0}, {'G', 0},
                    {'H', 0}, {'I', 0}, {'J', 0}, {'K', 0}, {'L', 0}, {'M', 0}, {'N', 0},
                    {'O', 0}, {'P', 0}, {'Q', 0}, {'R', 0}, {'S', 0}, {'T', 0}, {'U', 0},
                    {'V', 0}, {'W', 0}, {'X', 0}, {'Y', 0}, {'Z', 0},
                };

                StringBuilder stringS = new StringBuilder(s);
                StringBuilder stringSol = new StringBuilder();

                for (int i = 0; i < stringS.Length; i++)
                {
                    char ch = s[i];
                    ch = 'A';
                    for (int j = i; j < stringS.Length; j++)
                    {
                        if (stringS[j] >= 'a' && stringS[j] <= 'z')
                        {
                            if (stringS[i] == chars.ElementAt(stringS[j] - 97).Key)
                            {
                                chars[chars.ElementAt(stringS[j] - 97).Key]++;
                                stringS.Remove(j, 1);
                                j--;
                            }
                        }
                        else
                        {
                            if (stringS[i] == chars.ElementAt(stringS[j] - 65).Key)
                            {
                                chars[chars.ElementAt(stringS[j] - 65).Key]++;
                                stringS.Remove(j, 1);
                                j--;
                            }
                        }
                        
                    }
                    i--;

                }

                return stringS.ToString();
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "aAabBcC";

            Console.WriteLine(program.SortByFrequency(s));
            Console.ReadKey();
        }
    }
}
