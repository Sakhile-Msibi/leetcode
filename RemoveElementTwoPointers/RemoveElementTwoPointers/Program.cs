using System;

namespace RemoveElementTwoPointers
{
    class Program
    {
        public int RemoveElement(int[] nums, int val)
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            return j;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 3, 2, 2, 3 };
            int[] nums1 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int[] nums3 = { };
            int[] nums4 = { 3 };


            int val = 3;
            int val1 = 2;

            Console.WriteLine("k = " + program.RemoveElement(nums, val));
            Console.WriteLine();
            Console.WriteLine("k = " + program.RemoveElement(nums1, val1));
            Console.WriteLine();
            Console.WriteLine("k = " + program.RemoveElement(nums3, val1));
            Console.WriteLine();
            Console.WriteLine("nums = {3}, val = 3 k = " + program.RemoveElement(nums4, val));
            Console.WriteLine();
            Console.WriteLine("nums = {3}, val = 2 k = " + program.RemoveElement(nums4, val1));
            Console.ReadKey();
        }
    }
}
