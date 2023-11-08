using System;

using System.Collections;

using System.Collections.Generic;
 
namespace DesignHashSet

{

    public class MyHashSet
    {
        private const int MAX_LENGHT = 1000000;

        private const int BUCKETS_SIZE = 100;

        private ArrayList parentList;

        public int HashFunction(int key)
        {
            return key % BUCKETS_SIZE;
        }

        public MyHashSet()
        {
            parentList = new ArrayList(BUCKETS_SIZE);

            for (int i = 0; i < BUCKETS_SIZE; i++)
            {
                parentList.Add(null);
            }

        }

        public void Add(int key)
        {
            int index = HashFunction(key);

            LinkedList<int> childList = (LinkedList<int>)parentList[index];

            if (childList == null)
            {
                LinkedList<int> list = new LinkedList<int>();

                list.AddLast(key);

                parentList[index] = list;
            }
            else
            {
                if (!childList.Contains(key))
                {
                    childList.AddLast(key);
                }
            }
        }

        public void Remove(int key)
        {
            int index = HashFunction(key);

            LinkedList<int> childList = (LinkedList<int>)parentList[index];

            if (childList != null)
            {
                childList.Remove(key);
            }
        }

        public bool Contains(int key)
        {
            int index = HashFunction(key);

            LinkedList<int> childList = (LinkedList<int>)parentList[index];

            return (childList != null && childList.Contains(key));
        }

        public void DisplayHashSet()
        {
            for (int i = 0; i < parentList.Count; i++)
            {
                LinkedList<int> childList = (LinkedList<int>)parentList[i];

                if (childList != null)
                {

                    foreach (int num in childList)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            MyHashSet myHashSet = new MyHashSet();


           
            Console.WriteLine(myHashSet.Contains(72));
            myHashSet.Remove(91);

            myHashSet.Add(48);
            myHashSet.Add(41);
            myHashSet.Add(2);

            myHashSet.DisplayHashSet();
            myHashSet.Remove(2);

            Console.WriteLine(myHashSet.Contains(96));
            myHashSet.Remove(87);

            Console.WriteLine(myHashSet.Contains(48));

            myHashSet.DisplayHashSet();

            //myHashSet.DisplayHashSet();

            //Console.WriteLine(myHashSet.Contains(91));

            //Console.WriteLine(myHashSet.Contains(3));

            //myHashSet.Add(2);

            //Console.WriteLine(myHashSet.Contains(2));

            //myHashSet.Remove(2);

            //Console.WriteLine(myHashSet.Contains(2));


            //myHashSet.Add(1);

            //myHashSet.Add(2);

            //myHashSet.DisplayHashSet();

            //Console.WriteLine(myHashSet.Contains(1));

            //Console.WriteLine(myHashSet.Contains(3));

            //myHashSet.Add(2);

            //Console.WriteLine(myHashSet.Contains(2));

            //myHashSet.Remove(2);

            //Console.WriteLine(myHashSet.Contains(2));




            //myHashSet.Add(0);

            //myHashSet.Add(1987);

            //myHashSet.Add(24);

            //myHashSet.Add(2);

            //myHashSet.DisplayHashSet();

            Console.ReadKey();
        }
    }
}
