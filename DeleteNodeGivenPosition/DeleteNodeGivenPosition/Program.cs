using System;

namespace DeleteNodeGivenPosition
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

        //Does not work for C#. Works for C
        public void DeleteNode(Node head, int position)
        {
            Node temp = head;
            Node prev = head;

            for (int i = 0; i < position; i++)
            {
                if (i == 0 && position == 1)
                {
                    if (head == null)
                        return;

                    head = temp.next;
                }
                else
                {
                    if (i == position - 1 && temp != null)
                    {
                        prev.next = temp.next;
                    }
                    else
                    {
                        prev = temp;

                        if (prev == null)
                            break;

                        temp = temp.next;
                    }
                }
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

        public void DisplayLinkedLIst(Node head)
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

            Node list = new Node(1);
            Node second = new Node(2);
            linkedList.InsertAfter(second, 3);

            list.next = second;

            linkedList.DisplayLinkedLIst(list);

            linkedList.DeleteNode(list, 1);
            linkedList.DisplayLinkedLIst(linkedList.head);
            Console.ReadKey();
        }
    }
}
