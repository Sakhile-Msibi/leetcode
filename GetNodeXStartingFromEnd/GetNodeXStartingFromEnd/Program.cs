using System;

namespace GetNodeXStartingFromEnd
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

        public int GetNthNodeFromLast(int N)
        {
            int len = 0;
            Node temp = head;

            if (N < 1)
                return -1;

            while (temp != null)
            {
                temp = temp.next;
                len++;
            }

            if (N > len)
                return -1;

            temp = head;
            for (int i = 0; i < len - N; i++)
            {
                temp = temp.next;
            }

            return temp.data;
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

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new_node;
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

            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.DisplayLinkedList();

            Console.WriteLine(linkedList.GetNthNodeFromLast(4));
            Console.ReadKey();
        }
    }
}
