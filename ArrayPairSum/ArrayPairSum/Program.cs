using System;
using System.Collections.Generic;

namespace ArrayPairSum
{
    class Program
    {
        public int PairSum(int[] nums)
        {
            IList<List<int>> pairsList = new List<List<int>>();
            List<int> pairs = new List<int>();
            int sum = 0;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    pairs.Add(nums[i]);
                    pairs.Add(nums[j]);

                    pairsList.Add(pairs);
                    pairs = new List<int>();
                }
            }

            for (int i = 0; i < pairsList.Count; i++)
            {
                
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 1, 4, 3, 2 };

            Console.WriteLine(program.PairSum(nums));
            Console.ReadKey();
        }
    }
}
