using System;

namespace ValidMountainArray
{
    class Program
    {
        public bool MountainArray(int[] arr)
        {
            if (arr.Length < 3)
                return false;

            if (arr[0] > arr[1])
                return false;


            if (arr[arr.Length - 1] >= arr[arr.Length - 2])
                return false;

            int checker = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                    return false;

                if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                    checker++;
            }

            if (checker > 1 || checker == 0)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 0,1,2,0,1 };
            int[] arr1 = { 3, 5, 5 };
            int[] arr2 = { 0, 3, 2, 1 };
            int[] arr3 = { 0, 2, 3, 4, 5, 2, 1, 0 };
            int[] arr4 = { 0, 2, 3, 3, 5, 2, 1, 0 };

            Console.WriteLine(program.MountainArray(arr));
            Console.WriteLine(program.MountainArray(arr1));
            Console.WriteLine(program.MountainArray(arr2));
            Console.WriteLine(program.MountainArray(arr3));
            Console.WriteLine(program.MountainArray(arr4));
            Console.ReadKey();
        }
    }
}
