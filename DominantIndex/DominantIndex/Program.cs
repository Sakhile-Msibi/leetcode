using System;
using System.Linq;

namespace DominantIndex
{
    class Program
    {
        public int TwoTimesDominantIndex(int[] nums)
        {
            int counter = 1;
            int max = nums.Max();
            int index = Array.IndexOf(nums, max);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != max && nums[i] != 0 && max >= 2 * nums[i])
                {
                    counter++;
                }
                else if (nums[i] != max && nums[i] == 0)
                {
                    counter++;
                }
            }

            if (nums.Length == counter)
                return index;
            else
                return -1;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 3, 6, 1, 0 };
            int[] nums1 = { 1, 1 };

            //Console.WriteLine(program.TwoTimesDominantIndex(nums));
            Console.WriteLine(program.TwoTimesDominantIndex(nums1));
            Console.ReadKey();
        }
    }
}
