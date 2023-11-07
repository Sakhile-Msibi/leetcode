using System;
using System.Collections;

namespace DesignHashSet
{
    public class MyHashSet
    {
        private const int MAX_LENGHT = 1000000;
        private const int BUCKETS_SIZE = 100;
        private ArrayList<LinkedList<int>> parentList;

        public int HashFunction (int key)
        {
            return key % ARRAY_SIZE;
        }

        public MyHashSet()
        {
            parentList = new ArrayList<>(ARRAY_SIZE);

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                parentList.Add(null);
            }
        }

        public void Add(int key)
        {
            int index = HashFunction(key);
            LinkedList<int> childList = parentList[index];

            if (childList == null)
            {
                LinkedList<int> list = new LinkedList<int>();
                list.Add(key);
                parentList.Insert(index, list);
            }
            else
            {
                if (!childList.Contains(key))
                {
                    childList.Add(key);
                }
            }
        }

        public void Remove(int key)
        {
            int index = HashFunction(key);
            LinkedList<int> childList = parentList[index];

            if (childList != null)
            {
                childList.Remove(childList.IndexOf(key));
            }
        }

        public bool Contains(int key)
        {
            int index = HashFunction(key);
            LinkedList<int> childList = parentList[index];

            return childList != null && childList.Contains(key);
        }

        static void Main(string[] args)
        {
            MyHashSet myHashSet = new MyHashSet();

            myHashSet.Add(1);
            myHashSet.Add(2);

            foreach (int value in myHashSet)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();

            Console.WriteLine(myHashSet.Contains(1));
            Console.WriteLine(myHashSet.Contains(3));

            myHashSet.Add(2);

            foreach (int value in myHashSet)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();

            Console.WriteLine(myHashSet.Contains(2));

            myHashSet.Remove(2);

            foreach (int value in myHashSet)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();

            Console.WriteLine(myHashSet.Contains(2));
        }
    }
}
