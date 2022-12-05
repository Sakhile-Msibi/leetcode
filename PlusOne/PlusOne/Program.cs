using System;
using System.Collections;
using System.Numerics;

namespace PlusOne
{
    class Program
    {
        public int[] IncrementNumber(int[] digits)
        {
            ArrayList digitsList = new ArrayList();

            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] += 1;

                return digits;
            }
            else
            {
                string str = "";

                for (int i = 0; i < digits.Length; i++)
                    str += digits[i];

                BigInteger temp = BigInteger.Parse(str) + 1;
                str = temp.ToString();

                for (int i = 0; i < str.Length; i++)
                    digitsList.Add(str[i] - 48);

                int[] digi = new int[digitsList.Count];
                for (int i = 0; i < digitsList.Count; i++)
                    digi[i] = Convert.ToInt32(digitsList[i]);

                return digi;   
            }
        }

        public void PrintArray(int[] digits)
        {
            foreach (int digit in digits)
                Console.Write(digit + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] digits = { 1, 2, 4, 9 };
            int[] digits1 = { 1, 2, 3 };
            int[] digits2 = { 9, 9 };
            int[] digits3 = { 5,2,2,6,5,7,1,9,0,3,8,6,8,6,5,2,1,8,7,9,8,3,8,4,7,2,5,8,9 };

            program.PrintArray(program.IncrementNumber(digits));
            program.PrintArray(program.IncrementNumber(digits1));
            program.PrintArray(program.IncrementNumber(digits2));
            program.PrintArray(program.IncrementNumber(digits3));
            Console.ReadKey();
        }
    }
}
