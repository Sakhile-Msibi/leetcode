using System;

namespace TwoSum
{
    class Program
    {
        public int[] FindTwoSum(int[] numbers, int target)
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

        public void PrintArray(int[] ans)
        {
            foreach (int num in ans)
                Console.Write(num + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] numbers = { 2, 7, 11, 15 };
            int[] numbers1 = { 2, 3, 4 };
            int[] numbers2 = { -1, 0 };

            int target = 9;
            int target1 = 6;
            int target2 = -1;

            program.PrintArray(program.FindTwoSum(numbers, target));
            program.PrintArray(program.FindTwoSum(numbers1, target1));
            program.PrintArray(program.FindTwoSum(numbers2, target2));
            Console.ReadKey();
        }
    }
}
