using System;
using System.Linq;

namespace MinSubArrayLen
{
    class Program
    {
        public int FindMinSubArrayLen(int target, int[] nums)
        {
            int sumLR = 0;
            int sumRL = 0;
            int counterLR = 0;
            int counterRL = 0;
            int indexLR = 0;
            int indexRL = nums.Length - 1;
            int ansLR = int.MaxValue;
            int ansRL = int.MaxValue;
            int largerLR = int.MaxValue;
            int largerRL = int.MaxValue;

            for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
            {
                if (sumLR == target)
                {
                    if (counterLR < ansLR)
                        ansLR = counterLR;
                }

                if (sumRL == target)
                {
                    if (counterRL < ansRL)
                        ansRL = counterRL;
                }

                sumLR += nums[i];
                counterLR++;

                if (sumLR > target)
                {
                    if (counterLR < largerLR)
                        largerLR = counterLR;

                    while (sumLR > target)
                    {
                        sumLR -= nums[indexLR];
                        counterLR--;
                        indexLR++;
                    }

                    //if (counterLR < largerLR)
                    //    largerLR = counterLR;
                }

                sumRL += nums[j];
                counterRL++;

                if (sumRL > target)
                {
                    if (counterRL < largerRL)
                        largerRL = counterRL;

                    while (sumRL > target)
                    {
                        sumRL -= nums[indexRL];
                        counterRL--;
                        indexRL--;
                    }
                }
            }

            if (sumLR == target && sumRL == target)
            {
                return counterLR;
            }

            if (ansLR < ansRL)
                return ansLR;
            else if (ansLR > ansRL)
                return ansRL;
            else if (ansLR == ansRL && ansRL != int.MaxValue)
                return ansRL;
            else if (largerLR < largerRL)
                return largerLR;
            else if (largerLR > largerRL)
                return largerRL;
            else if (largerLR == largerRL && largerRL != int.MaxValue)
                return largerRL;
            else
                return 0;

            //if (sum == target)
            //{
            //    return counter;
            //}

            //sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (sum > target)
            //    {
            //        return i;
            //    }

            //    sum += nums[i];
            //}

            //return 0;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int target = 7;
            int[] nums1 = { 1, 4, 4 };
            int target1 = 4;
            int[] nums2 = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int target2 = 11;
            int[] nums3 = { 2, 16, 14, 15 };
            int target3 = 20;
            int[] nums4 = { 12,28,83,4,25,26,25,2,25,25,25,12 };
            int target4 = 213;
            int[] nums5 = { 1,2,3,4,5 };
            int target5 = 11;
            int[] nums6 = { 5, 1, 3, 5, 10, 7, 4, 9, 2, 8 };
            int target6 = 15;

            Console.WriteLine(program.FindMinSubArrayLen(target, nums));
            Console.WriteLine(program.FindMinSubArrayLen(target1, nums1));
            Console.WriteLine(program.FindMinSubArrayLen(target2, nums2));
            Console.WriteLine(program.FindMinSubArrayLen(target3, nums3));
            Console.WriteLine(program.FindMinSubArrayLen(target4, nums4));
            Console.WriteLine(program.FindMinSubArrayLen(target5, nums5));
            Console.WriteLine(program.FindMinSubArrayLen(target6, nums6));
            Console.ReadKey();
        }
    }
}
