namespace JewelsandStones
{
    internal class Program
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            char[] jewelsChars = jewels.ToCharArray(); ;
            char[] stonesChars = stones.ToCharArray();
            int numberOfJewelsInStones = 0;

            foreach (char c in jewelsChars)
            {
                map.Add(c, 0);
            }

            foreach (char stone in stonesChars)
            {
                if (map.ContainsKey(stone))
                {
                    int value = 0;

                    if (map.TryGetValue(stone, out value))
                    {
                        map.Remove(stone);
                        map.Add(stone, ++value);
                    }
                }
            }

            foreach (KeyValuePair<char, int> kvp in map)
            {
                if (kvp.Value > 0)
                {
                    numberOfJewelsInStones += kvp.Value;
                }
            }

            return numberOfJewelsInStones;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            string jewels = "aA";
            string stones = "aAAbbbb";
            Console.WriteLine(program.NumJewelsInStones(jewels, stones));

            string jewels1 = "z";
            string stones1 = "ZZ";
            Console.WriteLine(program.NumJewelsInStones(jewels1, stones1));

            Console.ReadKey();
        }
    }
}