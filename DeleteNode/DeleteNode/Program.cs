using System;

namespace DeleteNode
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

        public void DeleteNodeUsingKey(int key)
        {
            Node temp = head;
            Node prev = null;

            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }

            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
                return;

            prev.next = temp.next;
        }

        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;
            head = new_node;
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

            linkedList.Push(7);
            linkedList.Push(1);
            linkedList.Push(3);
            linkedList.Push(2);

            linkedList.DisplayLinkedList();

            linkedList.DeleteNodeUsingKey(2);
            linkedList.DisplayLinkedList();
            Console.ReadKey();
        }
    }
}
