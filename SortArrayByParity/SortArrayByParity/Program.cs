using System;

namespace SortArrayByParity
{
    class Program
    {
        public int[] SortArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums;

            int writePointer = 0;
            int tempValue;

            for (int readPointer = 0; readPointer < nums.Length - 1; readPointer++)
            {
                if (nums[readPointer] % 2 != 0 && nums[readPointer + 1] % 2 == 0)
                {
                    tempValue = nums[writePointer];
                    nums[writePointer++] = nums[readPointer + 1];
                    nums[readPointer + 1] = tempValue;
                }
                else if (nums[readPointer] % 2 == 0)
                {
                    writePointer++;
                }
            }

            return nums;
        }

        public void PrintArray(int[] nums)
        {
            foreach (int num in nums)
                Console.Write(num + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 0, 1, 0, 3, 12 };
            int[] nums1 = { 0 };
            int[] nums2 = { 4 };
            int[] nums3 = { 1, 0, 1, 1, 0 };
            int[] nums4 = { 3, 1, 2, 4 };

            program.PrintArray(program.SortArray(nums));
            program.PrintArray(program.SortArray(nums1));
            program.PrintArray(program.SortArray(nums2));
            program.PrintArray(program.SortArray(nums3));
            program.PrintArray(program.SortArray(nums4));
            Console.ReadKey();
        }
    }
}
