using System;

namespace TwoSum
{
    class Program
    {
        public int[] SumTwoNumbers(int[] nums, int target)
        {
            int[] ans = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        return ans;
                    }
                }
            }

            return ans;
        }

        public void DisplayArray(int[] ans)
        {
            foreach (int num in ans)
                Console.Write(num + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 2, 7, 11, 15 };
            int[] nums1 = { 3, 2, 4 };
            int[] nums2 = { 3, 3 };

            int target = 9;
            int target1 = 6;

            program.DisplayArray(program.SumTwoNumbers(nums, target));
            program.DisplayArray(program.SumTwoNumbers(nums1, target1));
            program.DisplayArray(program.SumTwoNumbers(nums2, target1));
            Console.ReadKey();
        }
    }
}
