using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueOccurrences
{
    class Program
    {
        public bool FindUniqueOccurrences(int[] arr)
        {
            if (arr.Length == 1)
                return true;

            List<int> list = new List<int>();
            int counter = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length && arr[i] == arr[j]; j++)
                {
                    counter++;
                }

                list.Add(counter);
                i += counter;
                counter = 0;
            }

            arr = arr.Distinct().ToArray();
            list = list.Distinct().ToList();

            if (arr.Length == list.Count)
                return true;

            return false;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 1, 2, 2, 1, 1, 3 };
            int[] arr1 = { 1, 2 };
            int[] arr2 = { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            int[] arr3 = { -4, 3, 3 };

            //Console.WriteLine(program.FindUniqueOccurrences(arr));
            //Console.WriteLine(program.FindUniqueOccurrences(arr1));
            //Console.WriteLine(program.FindUniqueOccurrences(arr2));
            Console.WriteLine(program.FindUniqueOccurrences(arr3));
            Console.ReadKey();
        }
    }
}
