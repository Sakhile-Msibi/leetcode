using System;

namespace OddEvenList
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

        public ListNode CreateOddEvenList(ListNode head)
        {
            ListNode first_node = head;
            ListNode middle_node = head;
            ListNode last_node = head;
            int mid = ListLength(head) / 2;
            int counter = 0;

            if (ListLength(head) <= 2)
                return head;

            first_node = first_node.next.next;
            middle_node = middle_node.next;
            ListNode temp_middle_node = middle_node;

            while (mid != 0)
            {
                if (first_node == null)
                    break;

                counter++;
                last_node.next = first_node;
                middle_node.next = first_node.next;
                first_node.next = temp_middle_node;

                //DisplayLinkedList(head);

                ListNode temp = first_node;
                first_node = middle_node;
                middle_node = temp;

                last_node = last_node.next;

                for (int i = counter; i >= 0 && middle_node.next != null; i--)
                {
                    middle_node = middle_node.next;
                }

                first_node = middle_node.next;

                mid--;
            }

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

            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.Append(3);
            //linkedList.Append(4);
            //linkedList.Append(5);
            //linkedList.Append(6);
            //linkedList.Append(7);
            //linkedList.Append(8);
            //linkedList.DisplayLinkedList(linkedList.head);

            linkedList.Append(2);
            linkedList.Append(1);
            linkedList.Append(3);
            //linkedList.Append(5);
            //linkedList.Append(6);
            //linkedList.Append(4);
            //linkedList.Append(7);
            linkedList.DisplayLinkedList(linkedList.head);

            linkedList.DisplayLinkedList(linkedList.CreateOddEvenList(linkedList.head));
            Console.ReadKey();
        }
    }
}
