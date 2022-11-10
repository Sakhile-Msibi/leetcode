using System;

namespace SortedSquares
{
    class Program
    {
        public int[] sortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }

            Array.Sort(nums);

            return nums;
        }

        public void printArray(int[] nums)
        {
            foreach (int num in nums)
                Console.Write(num + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { -4, -1, 0, 3, 10 };
            int[] nums1 = { -7, -3, 2, 3, 11 };

            program.printArray(program.sortedSquares(nums));
            program.printArray(program.sortedSquares(nums1));

        }
    }
}
