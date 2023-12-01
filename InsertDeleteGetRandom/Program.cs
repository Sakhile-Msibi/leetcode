namespace InsertDeleteGetRandom
{
    internal class RandomizedSet
    {
        HashSet<int> set = new HashSet<int>();

        public RandomizedSet()
        {
            
        }

        public bool Insert(int val)
        {
            return set.Contains(val) ? false : set.Add(val);
        }

        public bool Remove(int val)
        {
            return set.Contains(val) ? set.Remove(val) : false;
        }

        public int GetRandom()
        {
            Random random = new Random();
            int[] ints = set.ToArray();
            int i = random.Next(0, ints.Length);

            return ints[i];
        }

        static void Main(string[] args)
        {
            RandomizedSet randomizedSet = new RandomizedSet();

            Console.WriteLine(randomizedSet.Insert(1));
            Console.WriteLine(randomizedSet.Remove(2));
            Console.WriteLine(randomizedSet.Insert(2));
            Console.WriteLine(randomizedSet.GetRandom());
            Console.WriteLine(randomizedSet.Remove(1));
            Console.WriteLine(randomizedSet.Insert(2));
            Console.WriteLine(randomizedSet.GetRandom());

            Console.WriteLine(randomizedSet.Insert(-1));
            Console.WriteLine(randomizedSet.Remove(-2));
            Console.WriteLine(randomizedSet.Insert(-2));
            Console.WriteLine(randomizedSet.GetRandom());
            Console.WriteLine(randomizedSet.Remove(-1));
            Console.WriteLine(randomizedSet.Insert(-2));
            Console.WriteLine(randomizedSet.GetRandom());

            Console.ReadKey();
        }
    }
}