using System;
using System.Numerics;

namespace SmallestValue
{
    class Program
    {
        public int FindSmallestValue(int n)
        {
            BigInteger sum = 0;
            BigInteger prod = 1;
            BigInteger Bign = new BigInteger(n);
            
            for (int i = 2; i < Bign; i++)
            {
                while (Bign % i == 0)
                {
                    sum += Bign / i;
                    prod *= Bign / i;

                    if (prod == Bign)
                    {
                        Bign = sum;
                        i = 1;
                        sum = 0;
                        prod = 1;
                        break;
                    }
                    else if (prod > Bign)
                    {
                        
                        sum -= Bign / i;
                        prod /= Bign / i;
                        break;
                    }
                }
            }

            return (int)Bign;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int n = 15;
            int n1 = 3;

            Console.WriteLine(program.FindSmallestValue(9));
            Console.WriteLine(program.FindSmallestValue(n1));
            Console.WriteLine(program.FindSmallestValue(n));
            Console.ReadKey();
        }
    }
}
