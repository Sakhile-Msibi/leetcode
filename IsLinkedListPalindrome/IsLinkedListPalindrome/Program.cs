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


            int mid = ListLength(head) / 2;
            ListNode forwad_list = head;
            ListNode second_half_list = head;

            if (ListLength(head) % 2 == 0)
            {
                while (mid != 0)
                {
                    second_half_list = second_half_list.next;
                    
                    mid--;
                }

                while (second_half_list != null)
                {
                    if (forwad_list.data != second_half_list.data)
                        return false;

                    forwad_list = forwad_list.next;
                    second_half_list = second_half_list.next;
                }
            }

            return true;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode prev_node = null;
            ListNode current = head;
            ListNode next_node = null;

            while (current != null)
            {
                next_node = current.next;
                current.next = prev_node;
                prev_node = current;
                current = next_node;
            }

            head = prev_node;

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
            linkedList.Append(1);
            linkedList.DisplayLinkedList(linkedList.head);

            Console.WriteLine(linkedList.IsPalindrome(linkedList.head));
            Console.ReadKey();
        }
    }
}
