using System;

namespace LinkedListExample
{
    class LinkedList
    {
        Node head;

        //Declare a new node.
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

        //Add a node the the front and make it a head
        public void Push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;
            head = new_node;
        }

        public void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
                return;

            Node new_node = new Node(new_data);

            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        public void InsertAfter(int key, int val)
        {
            Node new_node = new Node(val);

            if (key == head.data)
            {
                new_node.next = head.next;
                head.next = new_node;
            }

            Node temp = head;
            while (temp.data != key)
            {
                temp = temp.next;

                if (temp == null)
                    return;
            }

            new_node.next = temp.next;
            temp.next = new_node;
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

            //linkedList.head = new Node(1);
            //Node second = new Node(2);
            //Node third = new Node(4);

            //linkedList.head.next = second;
            //second.next = third;

            //linkedList.Push(0);
            //linkedList.DisplayLinkedList();

            //linkedList.InsertAfter(second, 3);
            //linkedList.DisplayLinkedList();

            //linkedList.append(5);
            //linkedList.DisplayLinkedList();

            linkedList.append(6);
            linkedList.DisplayLinkedList();

            linkedList.Push(7);
            linkedList.DisplayLinkedList();

            linkedList.Push(1);
            linkedList.DisplayLinkedList();

            linkedList.append(4);
            linkedList.DisplayLinkedList();

            linkedList.InsertAfter(linkedList.head.next, 8);
            linkedList.DisplayLinkedList();

            linkedList.InsertAfter(8, 3);
            linkedList.DisplayLinkedList();
            Console.ReadKey();
        }
    }
}
