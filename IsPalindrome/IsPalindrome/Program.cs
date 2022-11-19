using System;

namespace IsPalindrome
{
    class Program
    {
        public bool IsNumberAPalindrome(int x)
        {
            if (x < 0)
                return false;
            else if (x >= 0 && x <= 9)
                return true;
            else
            {
                string stringX = x.ToString();
                int leftToRightPointer = 0;
                int rightToLeftPointer = stringX.Length - 1;

                while (leftToRightPointer < rightToLeftPointer)
                {
                    if (stringX[leftToRightPointer] != stringX[rightToLeftPointer])
                        return false;

                    leftToRightPointer++;
                    rightToLeftPointer--;
                }

                return true;
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int x = 121;
            int x1 = -121;
            int x2 = 10;

            Console.WriteLine(program.IsNumberAPalindrome(x));
            Console.WriteLine(program.IsNumberAPalindrome(x1));
            Console.WriteLine(program.IsNumberAPalindrome(x2));
            Console.ReadKey();
        }
    }
}
