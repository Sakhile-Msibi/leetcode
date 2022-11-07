using System;

namespace RunningSum
{
    class Program
    {
        //Sum all the numbers before an index i and put it in an array
        public int[] runningSum(int[] nums)
        {
            int sum = nums[0];
            int[] arrSums = new int[nums.Length];
            arrSums[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                arrSums[i] = sum;
            }


            //for (int i = 1; i < nums.Length; i++)
            //{
            //    nums[i] += nums[i - 1];
            //}

            //return nums;
            return arrSums;
        }

        public void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + ", ");
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 3, 1, 2, 10, 1 };

            program.printArray(program.runningSum(nums));
        }
    }
}
