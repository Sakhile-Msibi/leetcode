using System;

namespace MaximumWealth
{
    class Program
    {

        public int maximumWealth(int[][] accounts)
        {
            //int[] acc = new int[accounts.Length];
            int accountSum = 0;
            int maxWealth = int.MinValue;

            for (int j = 0; j < accounts.Length; j++)
            {
                for (int i = 0; i < accounts[j].Length; i++)
                    accountSum += accounts[j][i];

                if (maxWealth < accountSum)
                    maxWealth = accountSum;

                accountSum = 0;
            }

            return maxWealth;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[][] arr = new int[][] { new int[] { 2, 8, 7 },
                                        new int[] { 7, 1, 3 },
                                        new int[] { 1, 9, 5 } };

            Console.WriteLine(program.maximumWealth(arr));
        }
    }
}
