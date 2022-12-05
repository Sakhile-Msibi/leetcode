using System;

namespace RemoveElement
{
    class Program
    {
        public int removeElement(int[] nums, int val)
        {
            int counter = 0;


            if (nums.Length == 0 || (nums.Length == 1 && nums[0] == val))
                return counter;

            if (nums.Length == 1 && nums[0] != val)
                return ++counter; 

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == val)
                    counter++;

            for (int i = counter; i > 0; i--)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                    if (nums[j] == val)
                        for (int k = j; k < nums.Length - 1; k++)
                            nums[k] = nums[k + 1];
            }

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

            int[] nums = { 3, 2, 2, 3 };
            int[] nums1 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int[] nums3 = { };
            int[] nums4 = { 3 };


            int val = 3;
            int val1 = 2;

            Console.WriteLine("k = " + program.removeElement(nums, val));
            Console.WriteLine();
            Console.WriteLine("k = " + program.removeElement(nums1, val1));
            Console.WriteLine();
            Console.WriteLine("k = " + program.removeElement(nums3, val1));
            Console.WriteLine();
            Console.WriteLine("nums = {3}, val = 3 k = " + program.removeElement(nums4, val));
            Console.WriteLine();
            Console.WriteLine("nums = {3}, val = 2 k = " + program.removeElement(nums4, val1));
        }
    }
}
