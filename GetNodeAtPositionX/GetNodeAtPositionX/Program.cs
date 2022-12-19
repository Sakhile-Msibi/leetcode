using System;

namespace GetNodeAtPositionX
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

        public int GetNth(int index)
        {
            int counter = 0;
            Node current = head;

            while (current != null)
            {
                if (counter == index)
                    return current.data;

                current = current.next;
                counter++;
            }

            return -1;
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

            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.Append(3);
            //linkedList.Append(4);
            //linkedList.DisplayLinkedList();


            Console.WriteLine(linkedList.GetNth(3));
            Console.WriteLine(linkedList.GetNth(5));
            Console.ReadKey();
        }
    }
}
