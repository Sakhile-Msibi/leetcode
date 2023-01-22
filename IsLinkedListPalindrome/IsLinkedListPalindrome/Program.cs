using System;

namespace IsLinkedListPalindrome
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

        public bool IsPalindrome(ListNode head)
        {
            if (ListLength(head) == 1)
                return true;

            ListNode fast = head;
            ListNode slow = head;
            ListNode prev;
            ListNode temp;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            prev = slow;
            slow = slow.next;
            prev.next = null;
            while (slow != null)
            {
                temp = slow.next;
                slow.next = prev;
                prev = slow;
                slow = temp;
            }

            fast = head;
            slow = prev;
            while (slow != null)
            {
                if (fast.data != slow.data)
                    return false;

                slow = slow.next;
                fast = fast.next;
            }

            return true;
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
            ListNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new_node;
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
            linkedList.Append(2);
            linkedList.Append(8);
            linkedList.Append(2);
            linkedList.Append(2);
            linkedList.Append(1);
            linkedList.DisplayLinkedList(linkedList.head);

            Console.WriteLine(linkedList.IsPalindrome(linkedList.head));
            Console.ReadKey();
        }
    }
}
