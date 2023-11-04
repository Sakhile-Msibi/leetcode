using System;

namespace GetLastMoment
{
    class Program
    {
        public int GetLMoment(int n, int[] left, int[] right)
        {
            if (left.Length == 0 && right.Length == 0)
                return 0;

            Array.Sort(left);
            Array.Sort(right);

            if (left.Length == 0)
            {
                return n - right[0];
            }
            else if (right.Length == 0)
            {
                return left[left.Length - 1];
            }
            else if (left.Length == 1 && right.Length == 1)
            {
                return (left[left.Length - 1] > right[right.Length - 1]) ? left[left.Length - 1] : right[right.Length - 1];
            }
            else
            {
                return n;
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            int n = 20;
            int[] left = { 4, 7, 15 };
            int[] right = { 9, 3, 13, 10 }; 

            Console.WriteLine(program.GetLMoment(n, left, right));
        }
    }
}
