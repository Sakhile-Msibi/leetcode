using System;
using System.Collections.Generic;
using System.Linq;

namespace IsValidSudoku
{
    class Program
    {
        public bool SudokuValidation(char[][] board)
        {
            Dictionary<char, int> rowsSudokuValues = new Dictionary<char, int>()
            {
                { '1', 0 },
                { '2', 0 },
                { '3', 0 },
                { '4', 0 },
                { '5', 0 },
                { '6', 0 },
                { '7', 0 },
                { '8', 0 },
                { '9', 0 }
            };

            Dictionary<char, int> columnsSudokuValues = new Dictionary<char, int>()
            {
                { '1', 0 },
                { '2', 0 },
                { '3', 0 },
                { '4', 0 },
                { '5', 0 },
                { '6', 0 },
                { '7', 0 },
                { '8', 0 },
                { '9', 0 }
            };

            Dictionary<char, int> subBoxesSudokuValues = new Dictionary<char, int>()
            {
                { '1', 0 },
                { '2', 0 },
                { '3', 0 },
                { '4', 0 },
                { '5', 0 },
                { '6', 0 },
                { '7', 0 },
                { '8', 0 },
                { '9', 0 }
            };

            int x = 0;
            int y = 0;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    //Checks rows
                    if (board[i][j] != 46)
                    {
                        //board[i][j] - 49 Convert char into integer
                        if (board[i][j] == rowsSudokuValues.ElementAt(board[i][j] - 49).Key)
                            rowsSudokuValues[rowsSudokuValues.ElementAt(board[i][j] - 49).Key]++;

                        if (rowsSudokuValues[rowsSudokuValues.ElementAt(board[i][j] - 49).Key] > 1)
                            return false;
                    }

                    //Checks columns
                    if (board[j][i] != 46)
                    {
                        if (board[j][i] == columnsSudokuValues.ElementAt(board[j][i] - 49).Key)
                            columnsSudokuValues[columnsSudokuValues.ElementAt(board[j][i] - 49).Key]++;

                        if (columnsSudokuValues[columnsSudokuValues.ElementAt(board[j][i] - 49).Key] > 1)
                            return false;
                    }
                }

                //Checks the 3 X 3 sub-boxes
                for (int j = 0 + y; j < 3 + y; j++)
                {
                    for (int k = 0 + x; k < 3 + x; k++)
                    {
                        if (board[j][k] != 46)
                        {
                            if (board[j][k] == subBoxesSudokuValues.ElementAt(board[j][k] - 49).Key)
                                subBoxesSudokuValues[subBoxesSudokuValues.ElementAt(board[j][k] - 49).Key]++;

                            if (subBoxesSudokuValues[subBoxesSudokuValues.ElementAt(board[j][k] - 49).Key] > 1)
                                return false;
                        }
                    }
                }

                rowsSudokuValues = new Dictionary<char, int>()
                {
                    { '1', 0 },
                    { '2', 0 },
                    { '3', 0 },
                    { '4', 0 },
                    { '5', 0 },
                    { '6', 0 },
                    { '7', 0 },
                    { '8', 0 },
                    { '9', 0 }
                };

                columnsSudokuValues = new Dictionary<char, int>()
                {
                    { '1', 0 },
                    { '2', 0 },
                    { '3', 0 },
                    { '4', 0 },
                    { '5', 0 },
                    { '6', 0 },
                    { '7', 0 },
                    { '8', 0 },
                    { '9', 0 }
                };

                subBoxesSudokuValues = new Dictionary<char, int>()
                {
                    { '1', 0 },
                    { '2', 0 },
                    { '3', 0 },
                    { '4', 0 },
                    { '5', 0 },
                    { '6', 0 },
                    { '7', 0 },
                    { '8', 0 },
                    { '9', 0 }
                };

                if (i >= 0 && i <= 1)
                {
                    y += 3;
                }
                else if (i == 2)
                {
                    x += 3;
                    y = 0;
                }
                else if (i >= 3 && i <= 4)
                {
                    y += 3;
                }
                else if (i == 5)
                {
                    x += 3;
                    y = 0;
                }
                else if (i >= 6 && i <= 7)
                {
                    y += 3;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            char[][] board =
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            Console.WriteLine(program.SudokuValidation(board));
            Console.ReadKey();
        }
    }
}
