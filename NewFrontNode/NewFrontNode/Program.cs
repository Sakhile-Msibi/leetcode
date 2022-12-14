using System;

namespace NewFrontNode
{
    class LinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }

        public void PrintLinkedList()
        {
            Node n = head;

            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            linkedList.head.next = second;
            second.next = third;

            linkedList.PrintLinkedList();
            

            linkedList.push(5);
            linkedList.PrintLinkedList();
            Console.ReadKey();
        }
    }
}
