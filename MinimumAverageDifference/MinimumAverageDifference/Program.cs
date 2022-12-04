using System;
using System.Collections.Generic;

namespace MinimumAverageDifference
{
    class Program
    {
        public int FindMinimumAverageDifference(int[] nums)
        {
            int sumOfFirstElemnts = 0;
            int sumOfLastElemnts = 0;
            int averageOfFirstElemnts = 0;
            int averageOfLastElemnts = 0;

            int average = 0;
            int minAverage = int.MaxValue;
            int minIndex = -1;

            if (nums.Length == 1)
                return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumOfFirstElemnts += nums[j];
                }

                if (i > 0)
                {
                    averageOfFirstElemnts = sumOfFirstElemnts / i;
                }
                else
                {
                    averageOfFirstElemnts = 0;
                }

                for (int j = nums.Length - 1; j >= i; j--)
                {
                    sumOfLastElemnts += nums[j];
                }

                averageOfLastElemnts = sumOfLastElemnts / (nums.Length - i);

                average = Math.Abs(averageOfFirstElemnts - averageOfLastElemnts);

                if (average < minAverage)
                {
                    minAverage = average;
                    if (i == 0)
                        minIndex = nums.Length - 1;
                    else
                        minIndex = i - 1;

                    if (minAverage == 0)
                        return minIndex;
                }

                sumOfFirstElemnts = 0;
                sumOfLastElemnts = 0;
            }

            return minIndex;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 2, 5, 3, 9, 5, 3 };
            int[] nums1 = { 0 };
            int[] nums2 = { 0, 0, 0, 0, 0 };

            //Console.WriteLine(program.FindMinimumAverageDifference(nums));
            //Console.WriteLine(program.FindMinimumAverageDifference(nums1));
            Console.WriteLine(program.FindMinimumAverageDifference(nums2));
            Console.ReadKey();
        }
    }
}
