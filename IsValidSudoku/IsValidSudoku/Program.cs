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
                        if (board[i][j] != 46)
                        {
                            if (board[i][j] == rowsSudokuValues.ElementAt(board[i][j] - 49).Key)
                                rowsSudokuValues[rowsSudokuValues.ElementAt(board[i][j] - 49).Key]++;

                            if (rowsSudokuValues[rowsSudokuValues.ElementAt(board[i][j] - 49).Key] > 1)
                                return false;
                        }
                    }
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            char[][] board =
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' }
            };

            Console.WriteLine(program.SudokuValidation(board));
            Console.ReadKey();
        }
    }
}
