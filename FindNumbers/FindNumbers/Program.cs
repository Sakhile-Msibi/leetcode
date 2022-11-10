using System;

namespace FindNumbers
{
    class Program
    {
        public int findNumbers(int[] nums)
        {
            int evenCounter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int counter = 0;
                while (nums[i] != 0)
                {
                    nums[i] /= 10;
                    counter++;
                }

                if (counter % 2 == 0)
                    evenCounter++;
            }

            return evenCounter;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 12, 345, 2, 6, 7896 };
            int[] nums1 = { 555, 901, 482, 1771 };

            Console.WriteLine(program.findNumbers(nums));
            Console.WriteLine(program.findNumbers(nums1));

        }
    }
}
