using System;

namespace NumberOfSteps
{
    class Program
    {
        public int numberOfSteps(int num)
        {
            int steps = 0;

            if (num == 0)
                return steps;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    steps++;
                }

                if (num % 2 != 0)
                {
                    num -= 1;
                    steps++;
                }
            }

            return steps;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int num = 123;

            Console.WriteLine(program.numberOfSteps(num));
        }
    }
}
