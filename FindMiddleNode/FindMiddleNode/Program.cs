using System;

namespace FindMiddleNode
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int val)
        {
            data = val;
            next = null;
        }
    }
    class LinkedList
    {
        Node head;

        public int FindMiddleNode()
        {
            int center = GetLength(head) / 2;
            Node midNode = head;

            if (midNode == null)
                return -1;

            for (int i = 0; i < center; i++)
            {
                midNode = midNode.next;
            }

            if (midNode == null)
                return -1;

            return midNode.data;
        }

        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;
            head = new_node;
        }

        public int GetLength(Node link)
        {
            int len = 0;

            while (link != null)
            {
                len++;
                link = link.next;
            }

            return len;
        }

        public void PrintLinkedList()
        {
            Node list = head;
            while (list != null)
            {
                Console.Write(list.data + " ");
                list = list.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Push(3);
            linkedList.Push(4);
            linkedList.Push(2);
            linkedList.Push(1);
            linkedList.PrintLinkedList();

            Console.WriteLine(linkedList.FindMiddleNode());
            Console.ReadKey();
        }
    }
}
