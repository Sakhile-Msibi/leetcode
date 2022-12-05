using System;

namespace removeDuplicatesTwoPointers
{
    class Program
    {
        public int TwoPointers(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return 1;

            int writePointer = 1;

            for (int readPointer = 1; readPointer < nums.Length; readPointer++)
            {
                if (nums[readPointer] != nums[readPointer - 1])
                {
                    nums[writePointer++] = nums[readPointer];
                }
            }

            DisplayArray(nums);

            return writePointer;
        }

        public void DisplayArray(int[] nums)
        {
            foreach (int num in nums)
                Console.Write(num + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            Console.WriteLine(program.TwoPointers(nums));
            Console.ReadKey();
        }
    }
}
