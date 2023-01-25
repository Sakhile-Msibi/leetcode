using System;

namespace AddTwoNumbers
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
        ListNode head;

        public ListNode AddTwoLinkedListNumbers(ListNode l1, ListNode l2)
        {
            int firstDigit = -1;
            int lastDigit = -1;
            int sum = -1;

            while (l1 != null && l2 != null)
            {
                if (firstDigit == -1)
                {
                    sum = l1.val + l2.val;
                }
                else
                {
                    sum = firstDigit + l1.val + l2.val;
                    firstDigit = -1;
                }

                if (sum < 10)
                {
                    Append(sum);
                }
                else
                {
                    firstDigit = (sum) / 10;
                    lastDigit = (sum) % 10;

                    Append(lastDigit);
                }

                l1 = l1.next;
                l2 = l2.next;
            }

            while (l1 != null)
            {
                if (firstDigit == -1)
                {
                    sum = l1.val;
                }
                else
                {
                    sum = firstDigit + l1.val;
                    firstDigit = -1;
                }

                if (sum < 10)
                {
                    Append(sum);
                }
                else
                {
                    firstDigit = (sum) / 10;
                    lastDigit = (sum) % 10;

                    Append(lastDigit);
                }

                l1 = l1.next;
            }

            while (l2 != null)
            {
                if (firstDigit == -1)
                {
                    sum = l2.val;
                }
                else
                {
                    sum = firstDigit + l2.val;
                    firstDigit = -1;
                }

                if (sum < 10)
                {
                    Append(sum);
                }
                else
                {
                    firstDigit = (sum) / 10;
                    lastDigit = (sum) % 10;

                    Append(lastDigit);
                }

                l2 = l2.next;
            }

            if (firstDigit != -1)
                Append(firstDigit);

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
            ListNode list = head;

            while (list.next != null)
            {
                list = list.next;
            }

            list.next = new_node;
        }

        public void DisplayLinkedLIst(ListNode head)
        {
            ListNode list = head;

            while (list != null)
            {
                Console.Write(list.val + " ");
                list = list.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            //linkedList.Append(2);
            //linkedList.Append(4);
            //linkedList.Append(3);
            //ListNode l1 = linkedList.head;
            //linkedList.head = null;

            //linkedList.Append(5);
            //linkedList.Append(6);
            //linkedList.Append(4);
            //ListNode l2 = linkedList.head;
            //linkedList.head = null;

            linkedList.Append(0);
            ListNode l1 = linkedList.head;
            linkedList.head = null;

            linkedList.Append(0);
            ListNode l2 = linkedList.head;
            linkedList.head = null;

            //linkedList.Append(9);
            //linkedList.Append(9);
            //linkedList.Append(9);
            //linkedList.Append(9);
            //linkedList.Append(9);
            //linkedList.Append(9);
            //linkedList.Append(9);
            //ListNode l1 = linkedList.head;
            //linkedList.head = null;


            //linkedList.Append(9);
            //linkedList.Append(9);
            //linkedList.Append(9);
            //linkedList.Append(9);
            //ListNode l2 = linkedList.head;
            //linkedList.head = null;

            linkedList.DisplayLinkedLIst(l1);
            linkedList.DisplayLinkedLIst(l2);

            linkedList.AddTwoLinkedListNumbers(l1, l2);
            linkedList.DisplayLinkedLIst(linkedList.head);
            Console.ReadKey();
        }
    }
}
