using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DistinctAverages
{
    class Program
    {
        public int DistinctAverages(int[] nums)
        {
            List<double> distinctAverges = new List<double>();
            List<int> numsList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
                numsList.Add(nums[i]);

            for (int i = 0; numsList.Count != 0; i++)
            {
                int min = numsList.Min();
                int max = numsList.Max();
                double average;

                numsList.Remove(min);
                numsList.Remove(max);

                average = (Convert.ToDouble(min) + Convert.ToDouble(max)) / 2;

                distinctAverges.Add(average);
            }

            distinctAverges = distinctAverges.Distinct().ToList();

            PrintList(distinctAverges);

            return distinctAverges.Count;
        }

        public void PrintList(List<double> list)
        {
            foreach (double val in list)
                Console.Write(val + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 4, 1, 4, 0, 3, 5 };

            Console.WriteLine(program.DistinctAverages(arr));
            Console.ReadKey();
        }
    }
}
