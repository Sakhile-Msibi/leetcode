using System;

namespace DuplicateZeros
{
    class Program
    {
        public void duplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0 && (i + 1) < arr.Length)
                {
                    for (int j = arr.Length - 2; j > i; j--)
                        arr[j + 1] = arr[j];

                    arr[i + 1] = arr[i];
                    i++;
                }
            }

            foreach (int value in arr)
                Console.Write(value + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 0, 0, 0, 0, 0, 0, 0 };

            program.duplicateZeros(arr);
            program.duplicateZeros(arr1);
            program.duplicateZeros(arr2);


        }
    }
}
