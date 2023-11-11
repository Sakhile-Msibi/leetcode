namespace FirstUniqueChar
{
    internal class Program
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Dictionary<int, char> dict1 = new Dictionary<int, char>();
            int minIndex = int.MaxValue;

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], i);
                }
                else if (dict.ContainsKey(s[i]))
                {
                    int value = -1;
                    bool charBoolean = dict.TryGetValue(s[i], out value);
                    dict.Remove(s[i]);
                    dict1.Add(i, s[i]);
                }
            }

            foreach (char c  in dict1.Values)
            {
                if (dict.ContainsKey(c))
                {
                    dict.Remove(c);
                }
            }

            if (dict.Count == 0)
            {
                return -1;
            }

            foreach (char c in dict.Keys)
            {
                int value = -1;
                bool charBoolean = dict.TryGetValue(c, out value);
                minIndex = Math.Min(minIndex, value);
            }
            
            return (dict.Count != 0) ? minIndex : -1;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "leetcode";
            Console.WriteLine(program.FirstUniqChar(s));

            string s1 = "loveleetcode";
            Console.WriteLine(program.FirstUniqChar(s1));

            string s2 = "aabb";
            Console.WriteLine(program.FirstUniqChar(s2));

            string s3 = "aadadaad";
            Console.WriteLine(program.FirstUniqChar(s3));
        }
    }
}