using System;
using System.Collections.Generic;

namespace GetPascalTriangleRow
{
    class Program
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> list = new List<int>() { 1 };
            IList<int> list1 = new List<int>() { 1, 1 };
            IList<int> list2 = new List<int>();
            IList<IList<int>> parent = new List<IList<int>>();
            parent.Add(list);

            if (rowIndex == 0)
                return list;
            else if (rowIndex == 1)
                return list1;
            else
            {
                parent.Add(list1);

                for (int i = 0; i < rowIndex - 1; i++)
                {
                    list2 = new List<int>();
                    list2.Add(1);
                    int counter = parent.Count;
                    for (int j = 0; j < parent[counter - 1].Count - 1; j++)
                    {
                        list2.Add(parent[i + 1][j] + parent[i + 1][j + 1]);
                    }
                    list2.Add(1);
                    parent.Add(list2);
                }
            }

            return list2;
        }

        public void DisplayList(IList<int> list2)
        {
            Console.Write("{ ");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i] + " ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int rowIndex = 6;
            int rowIndex1 = 3;
            int rowIndex2 = 0;
            int rowIndex3 = 1;

            program.DisplayList(program.GetRow(rowIndex));
            program.DisplayList(program.GetRow(rowIndex1));
            program.DisplayList(program.GetRow(rowIndex2));
            program.DisplayList(program.GetRow(rowIndex3));
            Console.ReadKey();
        }
    }
}
