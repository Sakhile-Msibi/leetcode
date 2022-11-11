using System;

namespace Merge
{
    class Program
    {
        public void merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0)
                for (int i = 0; i < n; i++)
                    nums1[i] = nums2[i];

            if (n != 0)
            {
                int j = 0;
                for (int i = m; i < (m + n); i++)
                {
                    nums1[i] = nums2[j];
                    j++;
                }

                Array.Sort(nums1);
            }

            foreach (int value in nums1)
                Console.Write(value + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums12 = { 1 };
            int[] nums13 = { 0 };

            int[] nums2 = { 2, 5, 6 };
            int[] nums22 = { };
            int[] nums23 = { 1 };

            int m = 3;
            int m2 = 1;
            int m3 = 0;

            int n = 3;
            int n2 = 0;
            int n3 = 1;

            program.merge(nums1, m, nums2, n);
            program.merge(nums12, m2, nums22, n2);
            program.merge(nums13, m3, nums23, n3);

        }
    }
}
