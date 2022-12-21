using System;

namespace DesignLinkedList
{
    public class MyLinkedList
    {
        public MyLinkedList()
        {

        }

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

        Node head;

        public int Get(int index)
        {
            Node temp = head;
            Node prev = head;

            if (temp == null)
                return -1;

            for (int i = 0; i < index; i++)
            {

                prev = temp;
                if (prev == null)
                    return -1;

                temp = temp.next;
            }

            return temp.data;
        }

        public void AddAtHead(int val)
        {
            Node new_node = new Node(val);

            new_node.next = head;
            head = new_node;
        }

        public void AddAtTail(int val)
        {
            Node new_node = new Node(val);

            new_node.next = null;

            if (head == null)
            {
                head = new Node(val);
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new_node;
        }

        public void AddAtIndex(int index, int val)
        {
            Node new_node = new Node(val);
            Node current = head;
            Node prev = head;

            if (current == null)
                return;

            for (int i = 0; i < index; i++)
            {
                prev = current;
                if (prev == null)
                    return;

                current = current.next;
            }

            new_node.next = current;
            prev.next = new_node;
        }

        public void DeleteAtIndex(int index)
        {
            Node prev = head;
            Node current = head;

            if (current == null)
                return;

            for (int i = 0; i < index; i++)
            {
                prev = current;
                if (prev == null)
                    return;

                current = current.next;
            }

            prev.next = current.next;
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
            MyLinkedList myLinkedList = new MyLinkedList();

            //myLinkedList.AddAtHead(7);
            //myLinkedList.AddAtHead(2);
            //myLinkedList.AddAtHead(1);
            //myLinkedList.AddAtIndex(3, 0);
            //myLinkedList.DisplayLinkedList();

            //myLinkedList.DeleteAtIndex(2);
            //myLinkedList.DisplayLinkedList();

            //myLinkedList.AddAtHead(6);
            //myLinkedList.AddAtTail(4);
            //myLinkedList.DisplayLinkedList();

            //Console.WriteLine(myLinkedList.Get(14));

            //myLinkedList.AddAtHead(4);
            //myLinkedList.AddAtIndex(5, 0);
            //myLinkedList.AddAtHead(6);
            //myLinkedList.DisplayLinkedList();



            //Console.WriteLine(myLinkedList.Get(1));
            Console.ReadKey();
        }
    }
}
