using System;

namespace HeightChecker
{
    class Program
    {
        public int CheckHeight(int[] heights)
        {
            int matchCounter = 0;

            if (heights.Length == 0 || heights.Length == 1)
                return matchCounter;

            int[] expected = new int[heights.Length];
            
            for (int i = 0; i < heights.Length; i++)
                expected[i] = heights[i];

            Array.Sort(expected);

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expected[i])
                    matchCounter++;
            }

            return matchCounter;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] heights = { 1, 1, 4, 2, 1, 3 };
            int[] heights1 = { 5, 1, 2, 3, 4 };
            int[] heights2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine(program.CheckHeight(heights));
            Console.WriteLine(program.CheckHeight(heights1));
            Console.WriteLine(program.CheckHeight(heights2));
            Console.ReadKey();
        }
    }
}
