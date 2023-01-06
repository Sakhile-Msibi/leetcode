using System;

namespace RemoveNthFromEnd
{
    public class ListNode
    {
        public int data;
        public ListNode next;

        public ListNode(int val)
        {
            data = val;
            next = null;
        }
    }

    class LinkedList
    {
        ListNode head;

        public ListNode RemoveNthNodeFromEnd(ListNode head, int n)
        {
            ListNode slowPointer = head;
            ListNode fastPointer = head;
            int listLength = ListLength(head);
            int len = listLength - n;

            if (listLength == 1 && n == 1)
            {
                return null;
            }

            if (len == 0)
            {
                head = head.next;

                return head;
            }

            while (len != 0)
            {
                slowPointer = fastPointer;
                fastPointer = fastPointer.next;
                len--;
            }

            slowPointer.next = fastPointer.next;

            return head;
        }

        public int ListLength(ListNode head)
        {
            int counter = 0;
            ListNode list = head;

            while (list != null)
            {
                counter++;
                list = list.next;
            }

            return counter;
        }

        public void Append(int new_data)
        {
            ListNode new_node = new ListNode(new_data);

            if (head == null)
            {
                head = new ListNode(new_data);
                return;
            }

            new_node.next = null;
            ListNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new_node;
        }

        public void DisplayLinkedList(ListNode head)
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

            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);
            linkedList.Append(5);
            linkedList.DisplayLinkedList(linkedList.head);

            linkedList.DisplayLinkedList(linkedList.RemoveNthNodeFromEnd(linkedList.head, 5));
            Console.ReadKey();
        }
    }
}
