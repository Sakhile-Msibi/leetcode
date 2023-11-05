using System;
using System.Collections.Generic;

namespace GetLastMoment
{
    class Program
    {
        public int GetLMoment(int n, int[] left, int[] right)
        {
            int time = 0;

            for (int i = 0; i < left.Length; i++)
            {
                time = Math.Max(time, left[i]);
            }

            for (int i = 0; i < right.Length; i++)
            {
                time = Math.Max(time, n - right[i]);
            }
            
            return time;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            //int n = 20;
            //int[] left = /*{ 4, 3 }*/{ 4, 7, 15 };
            //int[] right = /*{ 0, 1 }*/{ 9, 3, 13, 10 };

            int n = 11;
            int[] left = { 1, 4, 5, 10, 9 };
            int[] right = { 2, 7, 6, 3 };

            Console.WriteLine("Time = " + program.GetLMoment(n, left, right));
        }
    }
}
