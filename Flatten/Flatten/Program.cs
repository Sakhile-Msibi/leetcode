using System;

namespace Flatten
{
    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;

        public Node(int data)
        {
            val = data;
            next = null;
            prev = null;
            child = null;
        }
    }

    class LinkedList
    {
        Node nodeHead;

        public Node FlattenLinkedList(Node head)
        {
            if (head == null)
                return null;

            Node curr = head;
            Node next_node = curr;
            Node prev_node = curr;
            nodeHead = null;

            while (curr != null)
            {
                prev_node = curr;
                if (curr.child == null)
                {
                    Append(curr.val);
                    curr = curr.next;
                }
                else
                {
                    Append(curr.val);
                    curr.child.prev = curr;
                    curr = curr.child;
                }

            }

            curr = prev_node;

            while (curr != null)
            {
                if (curr.prev.child != curr)
                {
                    curr = curr.prev;
                }
                else
                {
                    curr = curr.prev;
                    next_node = curr.next;

                    while (next_node != null)
                    {
                        Append(next_node.val);
                        next_node = next_node.next;
                    }

                    curr = curr.prev;
                }
            }

            return nodeHead;
        }

        public void Append(int val)
        {
            Node new_node = new Node(val);

            new_node.next = null;

            if (nodeHead == null)
            {
                nodeHead = new Node(val);
                return;
            }

            Node temp = nodeHead;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            new_node.prev = temp;
            temp.next = new_node;
        }

        public void DisplayLinkedList()
        {
            Node list = nodeHead;

            while (list != null)
            {
                Console.Write(list.val + " ");
                list = list.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.nodeHead = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            linkedList.nodeHead.next = second;
            second.next = null;
            second.prev = linkedList.nodeHead;
            linkedList.nodeHead.child = third;
            third.next = null;
            third.prev = linkedList.nodeHead;

            linkedList.DisplayLinkedList();

            linkedList.FlattenLinkedList(linkedList.nodeHead);
            linkedList.DisplayLinkedList();
            Console.ReadKey();
        }
    }
}
