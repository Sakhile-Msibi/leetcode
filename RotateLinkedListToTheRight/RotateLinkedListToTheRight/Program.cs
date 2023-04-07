using System;

namespace RotateLinkedListToTheRight
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int data)
        {
            val = data;
            next = null;
        }
    }

    class LinkedList
    {
        ListNode heads;

        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return null;

            if (k == 0 && head != null)
                return head;

            if (head.next == null)
                return head;

            if (head.next.next == null && k % 2 == 0)
                return head;

            k = k % LinkedListLenght(head);
            k = LinkedListLenght(head) - k;

            ListNode list = head;

            while (list.next != null)
            {
                list = list.next;
            }

            list.next = head;
            for (int i = k; list.next != null && i != 0; i--)
            {
                list = list.next;
            }

            head = list.next;
            list.next = null;

            return head;
        }

        public int LinkedListLenght(ListNode head)
        {
            ListNode temp = head;
            int counter = 0;

            while (temp != null)
            {
                counter++;
                temp = temp.next;
            }

            return counter;
        }

        public void Append(int new_data)
        {
            ListNode new_node = new ListNode(new_data);

            if (heads == null)
            {
                heads = new ListNode(new_data);
                return;
            }

            new_node.next = null;
            ListNode temp = heads;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new_node;
        }

        public void DisplayLinedList(ListNode head)
        {
            ListNode temp = head;

            while (temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
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
            //linkedList.DisplayLinedList(linkedList.heads);

            //int k = 2;

            //linkedList.Append(0);
            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.DisplayLinedList(linkedList.heads);

            //int k = 4;

            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.DisplayLinedList(linkedList.heads);

            //int k = 1;

            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.DisplayLinedList(linkedList.heads);

            int k = 2000000000;
            linkedList.DisplayLinedList(linkedList.RotateRight(linkedList.heads, k));
            Console.ReadKey();
        }
    }
}
