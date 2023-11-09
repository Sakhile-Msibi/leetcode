using System.Linq;

namespace CheckForSingleNumber
{
    internal class Program
    {
        public int SingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    set.Remove(num);
                }
                else
                {
                    set.Add(num);
                }
            }
            return set.First();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 2, 2, 1 };
            int[] nums1 = { 4, 1, 2, 1, 2 };
            int[] nums2 = { 1 };

            Console.WriteLine(program.SingleNumber(nums));
            Console.WriteLine(program.SingleNumber(nums1));
            Console.WriteLine(program.SingleNumber(nums2));

            Console.ReadKey();
        }
    }
}