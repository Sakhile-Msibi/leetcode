using System;

namespace ReplaceElements
{
    class Program
    {
        public int[] ElementReplacer(int[] arr)
        {
            if (arr.Length == 1)
            {
                arr[0] = -1;

                return arr;
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int greatestElement = arr[i + 1];
                for (int j = i + 2; j < arr.Length; j++)
                {
                    if (arr[j] > greatestElement)
                        greatestElement = arr[j];
                }
                arr[i] = greatestElement;
            }

            arr[arr.Length - 1] = -1;

            return arr;
        }

        public void PrintArray(int[] arr)
        {
            foreach (int val in arr)
                Console.Write(val + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 17, 18, 5, 4, 6, 1 };
            int[] arr1 = { 400 };

            program.PrintArray(program.ElementReplacer(arr));
            program.PrintArray(program.ElementReplacer(arr1));
            Console.ReadKey();
        }
    }
}
