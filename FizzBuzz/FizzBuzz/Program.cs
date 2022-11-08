using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        public IList<string> fizzBuzz(int n)
        {
            List<string> value = new List<string>();

            for (int i = 1; i < (n + 1); i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    value.Add("Fizz");
                else if (i % 3 != 0 && i % 5 == 0)
                    value.Add("Buzz");
                else if (i % 3 == 0 && i % 5 == 0)
                    value.Add("FizzBuzz");
                else
                    value.Add(i.ToString());
            }

            return value;
        }

        public void printList(IList<string> value)
        {
            foreach (var val in value)
                Console.Write(val + " ");
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int n = 15;

            program.printList(program.fizzBuzz(n));
        }
    }
}
