using System;

namespace CheckIfExist
{
    class Program
    {
        public bool CheckExistance(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == 2 * arr[j] && j != i)
                        return true;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 10, 2, 5, 3 };
            int[] arr1 = { 3, 1, 7, 11 };

            Console.WriteLine(program.CheckExistance(arr));
            Console.WriteLine(program.CheckExistance(arr1));
            Console.ReadKey();
        }
    }
}
