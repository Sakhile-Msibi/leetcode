using System.Collections;

namespace IntersectionOfTwoArrays
{
    internal class Program
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>(nums1);
            HashSet<int> set1 = new HashSet<int>();

            foreach (int num in nums2)
            {
                if (set.Contains(num) && !set1.Contains(num))
                {
                    set1.Add(num);
                }
            }

            return set1.ToArray();
        }

        public void DisplayArray(int[] values)
        {
            foreach (int num in values)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };

            int[] nums3 = { 4, 9, 5 };
            int[] nums4 = { 9, 4, 9, 8, 4 };

            program.DisplayArray(program.Intersection(nums1, nums2));
            program.DisplayArray(program.Intersection(nums3, nums4));

            Console.ReadKey();
        }
    }
}