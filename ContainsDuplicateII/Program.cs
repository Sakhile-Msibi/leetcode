namespace ContainsDuplicateII
{
    internal class Program
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> ints = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (ints.ContainsKey(nums[i]))
                {
                    int value = 0;
                    bool val = ints.TryGetValue(nums[i], out value);

                    if (Math.Abs(value - i) <= k)
                    {
                        return true;
                    }

                    ints.Remove(nums[i]);
                    ints.Add(nums[i], i);
                }
                else
                {
                    ints.Add(nums[i], i);
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 1, 2, 3, 1 };
            int k = 3;

            Console.WriteLine(program.ContainsNearbyDuplicate(nums, k));


            int[] nums1 = { 1, 0, 1, 1 };
            int k1 = 1;

            Console.WriteLine(program.ContainsNearbyDuplicate(nums1, k1));


            int[] nums2 = { 1, 2, 3, 1, 2, 3 };
            int k2 = 2;

            Console.WriteLine(program.ContainsNearbyDuplicate(nums2, k2));

            Console.ReadKey();
        }
    }
}