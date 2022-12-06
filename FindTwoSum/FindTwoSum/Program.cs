using System;

namespace FindTwoSum
{
    class Program
    {
        public class Solution
        {
            public int[] TwoSum(int[] numbers, int target)
            {
                int[] ans = { 1, 2 };

                if (numbers.Length == 2)
                    return ans;

                for (int x = 0; x < numbers.Length; x++)
                {
                    for (int y = x + 1; y < numbers.Length; y++)
                    {
                        if (numbers[x] + numbers[y] == target)
                        {
                            ans[0] = x + 1;
                            ans[1] = y + 1;

                            return ans;
                        }
                    }

                }

                return ans;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
