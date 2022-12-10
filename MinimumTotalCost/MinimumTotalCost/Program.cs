using System;
using System.Collections.Generic;

namespace MinimumTotalCost
{
    class Program
    {
        public long FindMinimumTotalCost(int[] nums1, int[] nums2)
        {
            int counter = 0;
            int index = -1;
            long indexSum = 0;
            int tester = -1;

            List<int> indexes = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                int freq = 0;
                for (int j = 0; j < nums1.Length; j++)
                {
                    if (nums2[i] == nums2[j])
                        freq++;
                }
                freq--;

                if (freq > nums1.Length / 2)
                    return -1;
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] == nums2[i])
                {
                    int j = 0;
                    while (nums1[i] == nums1[j])
                    {
                        j++;
                    }

                    int temp = nums1[i];
                    nums1[i] = nums1[j];
                    nums1[j] = temp;
                    indexSum += i + j;

                    //indexes.Add(i);
                    //counter++;
                }

            }

            if (counter == 0)
                return 0;
            //else
            //{
            //    for (int i = 0; i < indexes.Count; i++)
            //    {
            //        index = indexes[i];

            //        for (int j = 0; j < nums1.Length; j++)
            //        {
            //            if (nums1[index] != nums1[j])
            //            {
            //                int temp = nums1[index];
            //                nums1[index] = nums1[j];
            //                nums1[j] = temp;
            //                indexSum += index + j;
            //            }
            //        }
            //    }
            //    return indexSum;
            //}

            return indexSum;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums1 = { 2, 2, 2, 1, 3 };
            int[] nums2 = { 1, 2, 2, 3, 3 };

            Console.WriteLine(program.FindMinimumTotalCost(nums1, nums2));
            Console.ReadKey();
        }
    }
}
