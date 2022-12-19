using System;

namespace SearchElementInLinkedList
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

        public bool Search(int x)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == x)
                {
                    Console.WriteLine("true");
                    return true;
                }
                current = current.next;
            }

            Console.WriteLine("false");
            return false;
        }
        public void Append(int new_data)
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

            new_node.next = last.next;
            last.next = new_node;
        }
        public void DisplayLinkedList()
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

            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.DisplayLinkedList();

            linkedList.Search(3);
            linkedList.Search(5);
            Console.ReadKey();
        }
    }
}
