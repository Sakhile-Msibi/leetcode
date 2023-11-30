namespace TopKFrequentElements
{
    internal class Program
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] ans = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = map.ContainsKey(nums[i]) ? map[nums[i]] + 1 : 1;
            }

            var sortedDic = from entry in map orderby entry.Value descending select entry;

            k--;
            foreach (KeyValuePair<int, int> pair in sortedDic)
            {
                if (k < 0)
                    break;

                ans[k--] = pair.Key;
            }

            return ans;
        }

        public void DisplayArray(int[] nums)
        {
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums1 = { 1, 1, 1, 2, 2, 3 };
            int k1 = 2;
            program.DisplayArray(program.TopKFrequent(nums1, k1));

            int[] nums2 = { 1 };
            int k2 = 1;
            program.DisplayArray(program.TopKFrequent(nums2, k2));

            Console.ReadKey();
        }
    }
}