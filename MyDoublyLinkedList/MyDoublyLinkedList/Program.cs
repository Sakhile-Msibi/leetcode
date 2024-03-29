﻿using System;

namespace MyDoublyLinkedList
{
    public class ListNode
    {
        public int data;
        public ListNode next;
        public ListNode prev;

        public ListNode(int val)
        {
            data = val;
        }
    }

    class LinkedList
    {
        ListNode head;

        public int Get(int index)
        {
            ListNode temp = head;

            if (temp == null)
                return -1;

            for (int i = 0; i < index; i++)
            {
                if (temp == null)
                    return -1;

                temp = temp.next;
            }

            if (temp == null)
                return -1;

            return temp.data;
        }

        public void AddAtHead(int val)
        {
            ListNode new_node = new ListNode(val);

            new_node.next = head;
            new_node.prev = null;

            if (head != null)
                head.prev = new_node;

            head = new_node;
        }

        public void AddAtTail(int val)
        {
            ListNode new_node = new ListNode(val);

            if (head == null)
            {
                head = new ListNode(val);
                return;
            }

            new_node.next = null;
            ListNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            new_node.prev = temp;
            temp.next = new_node;
        }

        public void AddAtIndex(int index, int val)
        {
            ListNode new_node = new ListNode(val);
            ListNode current = head;
            ListNode prev_node = head;

            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            if (current == null)
                return;

            for (int i = 0; i < index; i++)
            {
                prev_node = current;
                if (prev_node == null)
                    return;

                current = current.next;
            }


            new_node.next = current;
            new_node.prev = prev_node;
            prev_node.next = new_node;
            
            if (current != null)
                current.prev = new_node;
        }

        public void DeleteAtIndex(int index)
        {
            ListNode prev_node = head;
            ListNode current = head;

            if (current == null)
                return;

            if (index == 0)
            {
                head = head.next;
                return;
            }

            for (int i =0; i < index; i++)
            {
                prev_node = current;
                if (prev_node == null)
                    return;

                current = current.next;
            }

            if (current == null)
                return;

            prev_node.next = current.next;

            if (current.next != null)
                current.next.prev = prev_node;
        }

        public void DisplayDLL(ListNode head)
        {
            ListNode list = head;

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

            //linkedList.AddAtHead(3);
            //linkedList.AddAtHead(2);
            //linkedList.AddAtHead(1);
            //linkedList.DisplayDLL(linkedList.head);


            //linkedList.AddAtTail(1);
            //linkedList.AddAtTail(2);
            //linkedList.AddAtTail(3);
            //linkedList.DisplayDLL(linkedList.head);

            //linkedList.AddAtIndex(0, 1);
            //linkedList.AddAtIndex(1, 2);
            //linkedList.AddAtIndex(2, 3);
            //linkedList.AddAtIndex(1, 5);
            //linkedList.DisplayDLL(linkedList.head);

            //linkedList.DeleteAtIndex(3);
            //linkedList.DisplayDLL(linkedList.head);

            //Console.WriteLine(linkedList.Get(1));

            linkedList.AddAtHead(1);
            linkedList.AddAtTail(3);
            linkedList.AddAtIndex(1, 2);
            linkedList.DisplayDLL(linkedList.head);

            Console.WriteLine(linkedList.Get(1));

            linkedList.DeleteAtIndex(1);
            linkedList.DisplayDLL(linkedList.head);

            Console.WriteLine(linkedList.Get(1));

            Console.WriteLine(linkedList.Get(3));

            linkedList.DeleteAtIndex(3);
            linkedList.DisplayDLL(linkedList.head);

            linkedList.DeleteAtIndex(0);
            linkedList.DisplayDLL(linkedList.head);

            Console.WriteLine(linkedList.Get(0));

            linkedList.DeleteAtIndex(0);
            linkedList.DisplayDLL(linkedList.head);

            Console.WriteLine(linkedList.Get(0));

            Console.ReadKey();
        }
    }
}
