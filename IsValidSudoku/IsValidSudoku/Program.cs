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

                    //for (int k = j + 1; k < board[i].Length - 1; k++)
                    //{
                    //    if (board[i][j] != 46)
                    //    {
                    //        if (board[i][k] != 46)
                    //        {
                    //            if (board[i][j] == board[i][k])
                    //                return false;
                    //        }
                    //    }
                    //}

                    ////Compare the current value board[i][j] to the last column of j
                    //if (board[i][j] == board[i][board[i].Length - 1])
                    //    return false;


                    //Checks columns
                    //if (board[j][i] != 46)
                    //{
                    //    if (board[j][i] == columnsSudokuValues.ElementAt(board[j][i] - 49).Key)
                    //        columnsSudokuValues[columnsSudokuValues.ElementAt(board[j][i] - 49).Key]++;

                    //    if (columnsSudokuValues[columnsSudokuValues.ElementAt(board[j][i] - 49).Key] > 1)
                    //        return false;
                    //}

                    ////for (int k = i + 1; k < board.Length - 1; k++)
                    ////{
                    ////    if (board[i][j] != 46)
                    ////    {
                    ////        if (board[k][j] != 46)
                    ////        {
                    ////            if (board[i][j] == board[k][j])
                    ////                return false;
                    ////        }
                    ////    }
                    ////}

                    //////Compare the current value board[i][j] to the last row of i
                    ////if (board[i][j] == board[board.Length - 1][j])
                    ////    return false;
                }

                //Checks the 3 X 3 sub-boxes
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
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
            }

            return true;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            char[][] board =
            {
                new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
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
