using System;
using System.Collections.Generic;

namespace Maximum69Number
{
    class Program
    {
        public int[] DigitToArray(int num)
        {
            List<int> numList = new List<int>();

            while (num != 0)
            {
                numList.Add(num % 10);

                num /= 10;
            }

            int[] arr = numList.ToArray();
            Array.Reverse(arr);
            return arr;
        }

        public int maximum69Number(int num)
        {
            int[] arr = DigitToArray(num);
            string str = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 6)
                {
                    arr[i] = 9;
                    break;
                }
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i];
            }

            return Convert.ToInt32(str);
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int num = 9669;

            Console.WriteLine(program.maximum69Number(num));
        }
    }
}
