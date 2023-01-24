using System;

namespace MergeTwoLists
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

        public ListNode MergeTwoLinkedLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
                return null;

            if (list1 == null)
            {
                head = list2;

                return head;
            }
                

            if (list2 == null)
            {
                head = list1;

                return head;
            }
                

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    ListNode temp = head;

                    while (temp.next != null)
                        temp = temp.next;

                    temp.next = list2;
                    break;
                }

                if (list2 == null)
                {
                    ListNode temp = head;

                    while (temp.next != null)
                        temp = temp.next;

                    temp.next = list1;
                    break;
                }

                if (list1.data < list2.data)
                {
                    Append(list1.data);
                    list1 = list1.next;
                }
                else if (list1.data > list2.data)
                {
                    Append(list2.data);
                    list2 = list2.next;
                }
                else
                {
                    Append(list1.data);
                    Append(list2.data);
                    list1 = list1.next;
                    list2 = list2.next;
                }
            }

            return head;
        }

        public int ListLength(ListNode head)
        {
            int len = 0;
            ListNode temp = head;

            while (temp != null)
            {
                len++;
                temp = temp.next;
            }

            return len;
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

            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.Append(4);

            //ListNode list1 = linkedList.head;
            //linkedList.head = null;

            //linkedList.Append(1);
            //linkedList.Append(3);
            //linkedList.Append(4);

            //ListNode list2 = linkedList.head;
            //linkedList.head = null;

            //ListNode list1 = linkedList.head;
            //linkedList.head = null;

            //ListNode list2 = linkedList.head;
            //linkedList.head = null;

            ListNode list1 = linkedList.head;
            linkedList.head = null;

            linkedList.Append(0);
            ListNode list2 = linkedList.head;
            linkedList.head = null;

            linkedList.DisplayLinkedList(list1);
            linkedList.DisplayLinkedList(list2);

            linkedList.MergeTwoLinkedLists(list1, list2);
            linkedList.DisplayLinkedList(linkedList.head);
            
            Console.ReadKey();
        }
    }
}
