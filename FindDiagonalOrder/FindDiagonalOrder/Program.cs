using System;

namespace FindDiagonalOrder
{
    class Program
    {
        public int[] DiagonalOrder(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            int[] arr = new int[n * m];
            int row = 0;
            int col = 0;

            for (int i = 0; i < n * m; i++)
            {
                arr[i] = mat[row][col];
                //Going up
                if ((row + col) % 2 == 0)
                {
                    if (col == n - 1)
                        row++;
                    else if (row == 0)
                        col++;
                    else
                    {
                        row--;
                        col++;
                    }
                }
                else
                {
                    if (row == m - 1)
                        col++;
                    else if (col == 0)
                        row++;
                    else
                    {
                        row++;
                        col--;
                    }
                }
            }

            return arr;
        }

        public void PrintArray(int[] arr)
        {
            foreach (int val in arr)
                Console.Write(val + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[][] mat = 
            { 
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 } 
            };

            int[][] mat1 =
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 } 
            };

            program.PrintArray(program.DiagonalOrder(mat));
            program.PrintArray(program.DiagonalOrder(mat1));
            Console.ReadKey();
        }
    }
}
