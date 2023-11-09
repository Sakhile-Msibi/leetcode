namespace CheckForDuplicates
{
    internal class Program
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>();

            foreach (int key in nums)
            {
                if (hashSet.Contains(key))
                {
                    return true;
                }
                hashSet.Add(key);
            }
            return false;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 1, 2, 3, 1 };
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            Console.WriteLine(program.ContainsDuplicate(nums));
            Console.WriteLine(program.ContainsDuplicate(nums1));
            Console.WriteLine(program.ContainsDuplicate(nums2));

            Console.ReadKey();
        }
    }
}