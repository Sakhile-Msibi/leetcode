using System;

namespace PivotInteger
{
    class Program
    {
        public int FindPivotInteger(int n)
        {
            int rightToLeftPointer = n;
            int sumLeft = 0;
            int sumRight = rightToLeftPointer;

            if (n == 1)
                return n;

            for (int i = 1; i <= n; i++)
            {
                sumLeft += i;
                for (int j = i; j <= n; j++)
                {
                    if (sumLeft == sumRight && i == rightToLeftPointer)
                        return rightToLeftPointer;

                    rightToLeftPointer--;
                    sumRight += rightToLeftPointer;
                }
                rightToLeftPointer = n;
                sumRight = rightToLeftPointer;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.FindPivotInteger(8));
            Console.WriteLine(program.FindPivotInteger(1));
            Console.WriteLine(program.FindPivotInteger(4));
            Console.ReadKey();
        }
    }
}
