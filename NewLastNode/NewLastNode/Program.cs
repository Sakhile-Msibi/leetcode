using System;

namespace NewLastNode
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

        public void append(int new_data)
        {
            Node new_node = new Node(new_data);

            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            new_node.next = null;

            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }

            last.next = new_node;
            return;
        }
        public void DisplayList()
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

            //linkedList.append(1);
            //linkedList.DisplayList();

            linkedList.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            linkedList.head.next = second;
            second.next = third;

            linkedList.DisplayList();

            linkedList.append(4);
            linkedList.DisplayList();

            Console.ReadKey();
        }
    }
}
