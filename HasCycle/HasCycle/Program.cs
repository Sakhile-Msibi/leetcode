using System;

namespace HasCycle
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

        public bool CheckCycle(ListNode head)
        {
            ListNode slowPointer = head;
            ListNode fastPointer = head;

            if (slowPointer == null || slowPointer.next == null)
                return false;

            while (slowPointer != null && slowPointer.next.next != null)
            {
                if (fastPointer == null || fastPointer.next == null)
                    return false;

                if (slowPointer.next == fastPointer.next.next)
                    return true;

                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;
            }

            return false;
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
        public void DisplayLinkedList()
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

            linkedList.head = new ListNode(1);
            ListNode second = new ListNode(2);
            ListNode third = new ListNode(3);
            ListNode fourth = new ListNode(4);

            linkedList.head.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = second;

            //linkedList.Append(-21);
            //linkedList.Append(10);
            //linkedList.Append(17);
            //linkedList.Append(8);
            //linkedList.Append(4);
            //linkedList.Append(26);
            //linkedList.Append(5);
            //linkedList.Append(35);
            //linkedList.Append(33);
            //linkedList.Append(-7);
            //linkedList.Append(-16);
            //linkedList.Append(27);
            //linkedList.Append(-12);
            //linkedList.Append(6);
            //linkedList.Append(29);
            //linkedList.Append(-12);
            //linkedList.Append(5);
            //linkedList.Append(9);
            //linkedList.Append(20);
            //linkedList.Append(14);
            //linkedList.Append(14);
            //linkedList.Append(2);
            //linkedList.Append(13);
            //linkedList.Append(-24);
            //linkedList.Append(21);
            //linkedList.Append(23);
            //linkedList.Append(-21);
            //linkedList.Append(5);
            //linkedList.DisplayLinkedList();

            Console.WriteLine(linkedList.CheckCycle(linkedList.head));
            Console.ReadKey();
        }
    }
}
