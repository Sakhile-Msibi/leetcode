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


            linkedList.AddAtTail(1);
            linkedList.AddAtTail(2);
            linkedList.AddAtTail(3);
            linkedList.DisplayDLL(linkedList.head);

            //Console.WriteLine(linkedList.Get(1));
            Console.ReadKey();
        }
    }
}