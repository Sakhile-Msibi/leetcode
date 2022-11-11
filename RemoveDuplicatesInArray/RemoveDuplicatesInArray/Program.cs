using System;

namespace RemoveDuplicatesInArray
{
    class Program
    {
        public int removeDuplicates(int[] nums)
        {
            int counter = 0;

            if (nums.Length == 0)
                return counter;

            if (nums.Length == 1)
                return ++counter;

            int value = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (value == nums[i])
                {
                    nums[i] = 200;
                    counter++;
                }
                else
                {
                    value = nums[i];
                }
            }
            Array.Sort(nums);

            printArray(nums);

            return nums.Length - counter;
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

            int[] nums = { 1, 1, 2 };
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] nums3 = { 1, 1, 1 };

            Console.WriteLine("k = " + program.removeDuplicates(nums));
            Console.WriteLine();
            Console.WriteLine("k = " + program.removeDuplicates(nums1));
            Console.WriteLine();
            Console.WriteLine("k = " + program.removeDuplicates(nums3));
            Console.ReadKey();
        }
    }
}
