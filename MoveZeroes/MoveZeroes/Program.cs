using System;

namespace MoveZeroes
{
    class Program
    {
        public void ZeroMover(int[] nums)
        {
            if (nums.Length > 1)
            {
                int writePointer = 0;

                for (int readPointer = 0; readPointer < nums.Length - 1; readPointer++)
                {
                    if (nums[readPointer] == 0 && nums[readPointer + 1] != 0)
                    {
                        nums[writePointer++] = nums[readPointer + 1];
                        nums[readPointer + 1] = 0;
                    }
                    else if (nums[readPointer] != 0)
                    {
                        writePointer++;
                    }
                }
            }

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
            int[] nums3 = { 1, 0, 1 , 1, 0 };

            program.ZeroMover(nums);
            program.ZeroMover(nums1);
            program.ZeroMover(nums2);
            program.ZeroMover(nums3);
            Console.ReadKey();
        }
    }
}
