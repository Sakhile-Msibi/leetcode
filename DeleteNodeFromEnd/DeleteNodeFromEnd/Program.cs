using System;

namespace DeleteNodeFromEnd
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
            Node prev_node = head;
            Node end_node = head;

            while (end_node.next != null)
            {
                prev_node = end_node;
                end_node = end_node.next;
            }

            if (end_node == null)
                return;

            prev_node.next = end_node.next;
        }

        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;
            head = new_node;
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
