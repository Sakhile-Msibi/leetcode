using System;
using System.Collections.Generic;

namespace SpiralOrder
{
    class Program
    {
        public IList<int> FindSpiralOrder(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int row = 0;
            int col = 0;
            int colCounterLeftToRight = matrix[0].Length;
            int colCounterRightToLeft = 0;
            IList<int> arr = new List<int>();

            for (int i = 0; i < m * n; i++)
            {
                //Left to Right
                while (col < colCounterLeftToRight)
                {
                    arr.Add(matrix[row][col++]);
                }
                //To leave the for loop once the number of values in the
                //list are equal to numbers in the are. e.g a 5 X 5 array
                //has 25 number. Once all those number has been added to
                //list, the task is done.
                if (arr.Count == m * n)
                    break;
                //Move to the next number. To ensure numbers added to the
                //list are not repeated.
                row++;
                col--;

                //Top to down
                while (row < matrix.Length - i)
                {
                    arr.Add(matrix[row++][col]);
                }
                if (arr.Count == m * n)
                    break;
                col--;
                row--;

                //Right to left
                while (col >= colCounterRightToLeft)
                {
                    arr.Add(matrix[row][col--]);
                }
                if (arr.Count == m * n)
                    break;
                row--;
                col++;

                //Down to top

                while (row >= i + 1)
                {
                    arr.Add(matrix[row--][col]);
                }
                if (arr.Count == m * n)
                    break;
                col++;
                row++;

                colCounterLeftToRight -= (1);
                colCounterRightToLeft += 1;
            }

            return arr;
        }

        public void PrintArrray(IList<int> matrix)
        {
            foreach (int val in matrix)
                Console.Write(val + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[][] matrix =
            {
                new int[] {1,2,3},
                new int[] {4,5,6 },
                new int[] {7,8,9}
            };

            int[][] matrix1 =
            {
                new int[] {1,2,3,4},
                new int[] {5,6,7,8 },
                new int[] {9,10,11,12}
            };

            int[][] matrix2 =
            {
                new int[] { 1, 2, 3, 4, 5, 6 },
                new int[] { 7, 8, 9, 10, 11, 12 },
                new int[] { 13, 14, 15, 16, 17, 18 },
                new int[] { 19, 20, 21, 22, 23, 24 },
                new int[] { 25, 26, 27, 28, 29, 30 },
                new int[] { 31, 32, 33, 34, 35, 36 }
            };

            int[][] matrix3 =
            {
                new int[] {1,2,3,4},
                new int[] {5,6,7,8},
                new int[] {9,10,11,12},
                new int[] { 13, 14, 15, 16 }
            };

            int[][] matrix4 =
           {
                new int[] {1,2,3,4},
               
            };

            int[][] matrix5 =
            {
                new int[] {1},
                new int[] {5},
                new int[] {9},
                new int[] { 13}
            };

            int[][] matrix6 =
            {
                new int[] {1,2,3,4,5},
                new int[] {6,7,8,9,10},
                new int[] {11,12,13,14,15 },
                new int[] { 16,17,18,19,20 },
                new int[] { 21, 22, 23, 24, 25 },
               
            };

            program.PrintArrray(program.FindSpiralOrder(matrix));
            program.PrintArrray(program.FindSpiralOrder(matrix1));
            program.PrintArrray(program.FindSpiralOrder(matrix2));
            program.PrintArrray(program.FindSpiralOrder(matrix3));
            program.PrintArrray(program.FindSpiralOrder(matrix4));
            program.PrintArrray(program.FindSpiralOrder(matrix5));
            program.PrintArrray(program.FindSpiralOrder(matrix6));
            Console.ReadKey();
        }
    }
}
