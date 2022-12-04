using System;
using System.Collections.Generic;
using System.Linq;

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

            List<int> average = new List<int>();
            int minAverage = int.MaxValue;
            int minIndex = int.MaxValue;
            List<int> indexList = new List<int>();

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

                average.Add(Convert.ToInt32(Math.Abs(averageOfFirstElemnts - averageOfLastElemnts)));

                sumOfFirstElemnts = 0;
                sumOfLastElemnts = 0;
            }

            int lastaverage = average[0];
            average.Remove(average[0]);
            minIndex = average.IndexOf(average.Min());
            minAverage = Math.Min(average.Min(), lastaverage);

            if (minAverage == lastaverage && lastaverage < average.Min())
                return nums.Length - 1;

            return minIndex;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 2, 5, 3, 9, 5, 3 };
            int[] nums1 = { 0,4,3,0,0 };
            int[] nums2 = { 0, 0, 0, 0, 0 };
            int[] nums3 = { 5,4,3,2,1 };
            int[] nums4 = { 4, 2, 0 };

            //Console.WriteLine(program.FindMinimumAverageDifference(nums));
            //Console.WriteLine(program.FindMinimumAverageDifference(nums1));
            //Console.WriteLine(program.FindMinimumAverageDifference(nums2));
            //Console.WriteLine(program.FindMinimumAverageDifference(nums3));
            Console.WriteLine(program.FindMinimumAverageDifference(nums4));
            Console.ReadKey();
        }
    }
}
