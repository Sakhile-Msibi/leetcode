﻿using System;

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
                if (curr == head)
                    break;

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
            Node fourth = new Node(4);
            Node fifth = new Node(5);
            Node sixth = new Node(6);
            Node seventh = new Node(7);
            Node eight = new Node(8);
            Node ninth = new Node(9);
            Node tenth = new Node(10);
            Node eleventh = new Node(11);
            Node twelveth = new Node(12);

            linkedList.nodeHead.next = second;
            linkedList.nodeHead.prev = null;
            second.next = third;
            second.prev = linkedList.nodeHead;
            third.next = fourth;
            third.prev = second;
            third.child = seventh;
            fourth.next = fifth;
            fourth.prev = third;
            fifth.next = sixth;
            fifth.prev = fourth;
            sixth.next = null;
            sixth.prev = fifth;
            seventh.next = eight;
            seventh.prev = null;
            eight.next = ninth;
            eight.prev = seventh;
            eight.child = eleventh;
            ninth.next = tenth;
            ninth.prev = eight;
            tenth.next = null;
            tenth.prev = ninth;
            eleventh.next = twelveth;
            eleventh.prev = null;
            twelveth.next = null;
            twelveth.prev = eleventh;

            //linkedList.nodeHead = new Node(1);
            //Node second = new Node(2);
            //Node third = new Node(3);

            //linkedList.nodeHead.next = second;
            //second.next = null;
            //second.prev = linkedList.nodeHead;
            //linkedList.nodeHead.child = third;
            //third.next = null;
            //third.prev = linkedList.nodeHead;

            //linkedList.nodeHead = new Node(1);
            //Node second = new Node(2);
            //Node third = new Node(3);
            //Node fourth = new Node(4);
            //Node fifth = new Node(5);

            //linkedList.nodeHead.next = null;
            //linkedList.nodeHead.prev = null;
            //linkedList.nodeHead.child = second;
            //second.next = fourth;
            //second.prev = null;
            //second.child = third;
            //third.next = null;
            //third.prev = null;
            //third.child = fifth;
            //fourth.next = null;
            //fourth.prev = second;
            //fifth.next = null;
            //fifth.prev = null;

            linkedList.DisplayLinkedList();

            linkedList.FlattenLinkedList(linkedList.nodeHead);
            linkedList.DisplayLinkedList();
            Console.ReadKey();
        }
    }
}
