using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    class Program
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<int> list = new List<int>() { 1 };
            IList<int> list1 = new List<int>() { 1, 1 };
            IList<IList<int>> parent = new List<IList<int>>();
            parent.Add(list);

            if (numRows == 1)
                return parent;
            else if (numRows == 2)
            {
                parent.Add(list1);
                return parent;
            }
            else
            {
                parent.Add(list1);

                for (int i = 0; i < numRows - 2; i++)
                {
                    IList<int> list2 = new List<int>();
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

            return parent;
        }

        public void DisplayList(IList<IList<int>> parent)
        {
            for (int i = 0; i < parent.Count; i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < parent[i].Count; j++)
                    Console.Write(parent[i][j] + " ");

                Console.Write("}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int numRows = 6;

            program.DisplayList(program.Generate(numRows));
            Console.ReadKey();
        }
    }
}
