using System;

namespace ReverseList
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

        public ListNode ReverseLinkedList(ListNode head)
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

            linkedList.DisplayLinkedList(linkedList.ReverseLinkedList(linkedList.head));
            Console.ReadKey();
        }
    }
}
