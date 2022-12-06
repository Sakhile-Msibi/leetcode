using System;
using System.Linq;

namespace MinSubArrayLen
{
    class Program
    {
        public int FindMinSubArrayLen(int target, int[] nums)
        {
            int sum = 0;
            int counter = 0;
            int index = 0;
            Array.Sort(nums, (a, b) => b - a);

            for (int i = 0; i < nums.Length; i++)
            {
                if (sum >= target)
                {
                    return counter;
                }

                sum += nums[i];
                counter++;

                if (sum > target)
                {
                    if (sum - nums[i] > sum - nums[index])
                    {
                        sum -= nums[i];
                        counter--;
                    }
                    else
                    {
                        sum -= nums[index];
                        counter--;
                        index++;
                    }
                } 
            }

            if (sum == target)
            {
                return counter;
            }

            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sum > target)
                {
                    return i;
                }

                sum += nums[i];
            }

            return 0;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int target = 7;
            int[] nums1 = { 1, 4, 4 };
            int target1 = 4;
            int[] nums2 = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int target2 = 11;
            int[] nums3 = { 2, 16, 14, 15 };
            int target3 = 20;
            int[] nums4 = { 12,28,83,4,25,26,25,2,25,25,25,12 };
            int target4 = 213;

            //Console.WriteLine(program.FindMinSubArrayLen(target, nums));
            //Console.WriteLine(program.FindMinSubArrayLen(target1, nums1));
            //Console.WriteLine(program.FindMinSubArrayLen(target2, nums2));
            //Console.WriteLine(program.FindMinSubArrayLen(target3, nums3));
            Console.WriteLine(program.FindMinSubArrayLen(target4, nums4));
            Console.ReadKey();
        }
    }
}
