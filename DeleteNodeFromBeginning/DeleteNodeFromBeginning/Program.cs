using System;

namespace DeleteNodeFromBeginning
{
    class LinkedList
    {
        Node head;

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

        public void DeleteNode()
        {
            if (head != null)
            {
                head = head.next;
            }
        }
        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;
            head = new_node;
        }
        public void DisplayLinkedList()
        {
            Node link = head;

            while (link != null)
            {
                Console.Write(link.data + " ");
                link = link.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Push(3);
            linkedList.Push(2);
            linkedList.Push(1);
            linkedList.DisplayLinkedList();

            linkedList.DeleteNode();
            linkedList.DisplayLinkedList();

            linkedList.DeleteNode();
            linkedList.DisplayLinkedList();
            Console.ReadKey();
        }
    }
}
