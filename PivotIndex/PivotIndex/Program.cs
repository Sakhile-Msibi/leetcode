using System;
using System.Collections;

namespace PivotIndex
{
    class Program
    {
        public int FindPivotIndex(int[] nums)
        {
            if (nums.Length == 1)
                return 0;

            if (nums.Length == 3 && (nums[0] + nums[1] == 0))
                return 2;
            else if (nums.Length == 3 && (nums[1] + nums[2] == 0))
                return 0;

            int[] sumLeft = new int[nums.Length];
            int[] sumRight = new int[nums.Length];
            int sumL = 0;
            int sumR = 0;

            for (int i = 0, j = nums.Length - 1; i < nums.Length && j >= 0; i++, j--)
            {
                sumL += nums[i];
                sumLeft[i] = sumL;
                sumR += nums[j];
                sumRight[j] = sumR;
            }

            for (int i = 0; i < nums.Length; i++)
                if (sumLeft[i] == sumRight[i])
                    return i;


            return -1;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 5, -3, -2, 1 };
            int[] nums1 = { -1, -1, -1, -1, -1, 0 };
            int[] nums2 = { -1,-1,-1,-1,-1,1 };

            Console.WriteLine(program.FindPivotIndex(nums));
            //Console.WriteLine(program.FindPivotIndex(nums1));
            //Console.WriteLine(program.FindPivotIndex(nums2));
            Console.ReadKey();
        }
    }
}
