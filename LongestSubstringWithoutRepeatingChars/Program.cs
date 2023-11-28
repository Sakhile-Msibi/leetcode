namespace LongestSubstringWithoutRepeatingChars
{
    internal class Program
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            HashSet<char> chars = new HashSet<char>();
            int lengthOfLongestSubstring = 0;
            int startIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!chars.Contains(s[i]))
                {
                    chars.Add(s[i]);
                }
                else if (chars.Contains(s[i]))
                {
                    if (lengthOfLongestSubstring < chars.Count)
                    {
                        lengthOfLongestSubstring = chars.Count;
                    }

                    string subS = new string(chars.ToArray());

                    subS = subS.Substring(subS.IndexOf(s[i]) + 1);
                    int index = s.IndexOf(s[i - 1], startIndex, i - startIndex + 1);
                    startIndex = i;
                    i = index;

                    chars.Clear();

                    if (subS != "")
                    {
                        chars = new HashSet<char>(subS.ToCharArray());
                    }
                    
                }
            }

            if (lengthOfLongestSubstring < chars.Count)
            {
                lengthOfLongestSubstring = chars.Count;
            }

            return lengthOfLongestSubstring;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "abcabcbb";
            Console.WriteLine(program.LengthOfLongestSubstring(s));

            string s1 = "bbbbb";
            Console.WriteLine(program.LengthOfLongestSubstring(s1));

            string s2 = "pwwkew";
            Console.WriteLine(program.LengthOfLongestSubstring(s2));

            string s3 = "sakhile";
            Console.WriteLine(program.LengthOfLongestSubstring(s3));

            string s4 = "dvdf";
            Console.WriteLine(program.LengthOfLongestSubstring(s4));
        }
    }
}