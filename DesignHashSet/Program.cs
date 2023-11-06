using System;

namespace DesignHashSet
{
    public class MyHashSet
    {
        private const int MAX_BUCKETS = 1000000;
        private const int ARRAY_SIZE = 100;
        private List<List<int>> parentList;

        int HashFunction (int key)
        {
            return key % MAX_BUCKETS;
        }

        public MyHashSet()
        {
            parentList = new ArrayList<>(ARRAY_SIZE);
        }

        public void Add(int key)
        {

        }

        public void Remove(int key)
        {

        }

        public bool Contains(int key)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
