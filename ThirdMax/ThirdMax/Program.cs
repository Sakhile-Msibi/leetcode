using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdMax
{
    class Program
    {
        public int ThirdPlaceMax(int[] nums)
        {
            Array.Sort(nums);

            List<int> numsList = new List<int>();

            numsList = nums.Distinct().ToList();

            int max = nums.Max();

            if (numsList.Count == 1)
                return numsList[0];

            if (numsList.Count == 2)
                return max;

            return numsList[numsList.Count - 3];
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 3, 2, 1 };
            int[] nums1 = { 1, 1, 1 };
            int[] nums2 = { 2, 2, 3, 1 };
            int[] nums3 = { 1, 2, 2, 5, 3, 5 };

            Console.WriteLine(program.ThirdPlaceMax(nums));
            Console.WriteLine(program.ThirdPlaceMax(nums1));
            Console.WriteLine(program.ThirdPlaceMax(nums2));
            Console.WriteLine(program.ThirdPlaceMax(nums3));
            Console.ReadKey();
        }
    }
}
