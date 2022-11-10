using System;

namespace FindMaxConsecutiveOnes
{
    class Program
    {
        public int findMaxConsecutiveOnes(int[] nums)
        {
            int counter = 0;
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    counter++;
                    if (counter > max)
                        max = counter;
                }
                else
                    counter = 0;
            }

            return max;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 1, 1, 0, 1, 1, 1 };

            int[] nums1 = { 1, 0, 1, 1, 0, 1 };

            Console.WriteLine(program.findMaxConsecutiveOnes(nums));
            Console.WriteLine(program.findMaxConsecutiveOnes(nums1));

        }
    }
}
