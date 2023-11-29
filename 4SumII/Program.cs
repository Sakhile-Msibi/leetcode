namespace _4SumII
{
    internal class Program
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int counter = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    map[nums1[i] + nums2[j]] = map.ContainsKey(nums1[i] + nums2[j]) ? map[nums1[i] + nums2[j]] + 1 : 1;
                }
            }

            for (int i = 0; i < nums3.Length; i++)
            {
                for (int j = 0;j < nums4.Length; j++)
                {
                    if (map.ContainsKey(-nums3[i] - nums4[j]))
                    {
                        counter += map[-nums3[i] - nums4[j]];
                    }
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums1 = { 1, 2 };
            int[] nums2 = { -2, -1 };
            int[] nums3 = { -1, 2 };
            int[] nums4 = { 0, 2 };

            Console.WriteLine(program.FourSumCount(nums1, nums2, nums3, nums4));

            Console.ReadKey();
        }
    }
}