using System;

namespace NewMiddleNode
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

        public void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
                return;

            Node new_node = new Node(new_data);

            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        public void DisplayLinkedList()
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
            Node third = new Node(4);

            linkedList.head.next = second;
            second.next = third;

            linkedList.DisplayLinkedList();

            linkedList.InsertAfter(second, 3);
            linkedList.DisplayLinkedList();
            Console.ReadKey();
        }
    }
}
