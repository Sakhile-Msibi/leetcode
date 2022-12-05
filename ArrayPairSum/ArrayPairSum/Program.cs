using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayPairSum
{
    class Program
    {
        public int PairSum(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                sum += nums[i];
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 1, 4, 3, 2 };
            int[] nums1 = { 6, 2, 6, 5, 1, 2 };

            Console.WriteLine(program.PairSum(nums));
            Console.WriteLine(program.PairSum(nums1));
            Console.ReadKey();
        }
    }
}
