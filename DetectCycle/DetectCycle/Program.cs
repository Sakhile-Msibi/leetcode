using System;

namespace DetectCycle
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

        public ListNode FindCycle(ListNode head)
        {
            ListNode slowPointer = head;
            ListNode fastPointer = head;

            while (fastPointer != null && fastPointer.next != null)
            {
                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;

                if (slowPointer == fastPointer)
                    break;   
            }

            if (fastPointer == null || fastPointer.next == null)
                return null;

            while (head != slowPointer)
            {
                head = head.next;
                slowPointer = slowPointer.next;
            }

            return head;
        }

        public void Push(int new_data)
        {
            ListNode new_node = new ListNode(new_data);

            new_node.next = head;
            head = new_node;
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
            //linkedList.DisplayLinkedList(linkedList.head);

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
            ////linkedList.DisplayLinkedList();

            //ListNode temp = linkedList.head;
            //for (int i = 0; i < 24; i++)
            //{
            //    temp = temp.next;
            //}

            //ListNode temp1 = linkedList.head;
            //for (int i = 0; i < 27; i++)
            //{
            //    temp1 = temp1.next;
            //}

            //temp1.next = temp;
            linkedList.DisplayLinkedList(linkedList.FindCycle(linkedList.head));
            Console.ReadKey();
        }
    }
}
