using System;

namespace GetIntersectionNode
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

        public ListNode FindIntersectionNode(ListNode headA, ListNode headB)
        {
            int lenHeadA = ListLength(headA);
            int lenHeadB = ListLength(headB);
            int diff = 0;

            if (lenHeadA == 1 && lenHeadB == 1)
            {
                if (headA == headB)
                    return headA;
                else if (headA.next == headB.next)
                    return headA.next;
                else
                    return null;
            }

            if (lenHeadA > lenHeadB)
            {
                diff = lenHeadA - lenHeadB;

                for (int i = diff; i > 0; i--)
                {
                    headA = headA.next;
                }

                while (headA != null && headB != null)
                {
                    if (headA == headB)
                        return headA;
                    else if (headA.next == headB.next)
                        return headA.next;

                    headA = headA.next;
                    headB = headB.next;
                }
            }
            else if (lenHeadA < lenHeadB)
            {
                diff = lenHeadB - lenHeadA;

                for (int i = diff; i > 0; i--)
                {
                    headB = headB.next;
                }

                while (headA != null && headB != null)
                {
                    if (headA == headB)
                        return headA;
                    else if (headA.next == headB.next)
                        return headA.next;

                    headA = headA.next;
                    headB = headB.next;
                }
            }
            else
            {
                while (headA != null && headB != null)
                {
                    if (headA == headB)
                        return headA;
                    else if (headA.next == headB.next)
                        return headA.next;

                    headA = headA.next;
                    headB = headB.next;
                }
            }

            return null;
        }

        public int ListLength(ListNode head)
        {
            ListNode list = head;
            int counter = 0;

            while (list != null)
            {
                counter++;
                list = list.next;
            }

            return counter;
        }

        public void Push(int new_data)
        {
            ListNode new_node = new ListNode(new_data);

            new_node.next = head;
            head = new_node;
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

        public void DisplayLinkedLIst(ListNode head)
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

            //linkedList.Push(5);
            //linkedList.Push(4);
            //linkedList.Push(8);
            //linkedList.Push(1);
            //linkedList.Push(4);

            //linkedList.Append(1);
            //linkedList.Append(9);
            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.Append(4);

            //linkedList.Append(1);
            //linkedList.Append(2);
            linkedList.Append(3);
            //linkedList.Append(4);
            //linkedList.Append(5);
            //linkedList.Append(6);
            //linkedList.Append(7);
            //linkedList.Append(8);
            //linkedList.Append(9);
            //linkedList.Append(10);
            //linkedList.Append(11);
            //linkedList.Append(12);
            //linkedList.Append(13);

            ListNode headA = linkedList.head;

            linkedList.head = null;

            //linkedList.Push(5);
            //linkedList.Push(4);
            //linkedList.Push(8);
            //linkedList.Push(1);
            //linkedList.Push(6);
            //linkedList.Push(5);

            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.Append(4);

            //linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            //linkedList.Append(4);
            //linkedList.Append(5);
            //linkedList.Append(6);
            //linkedList.Append(7);
            //linkedList.Append(8);
            //linkedList.Append(9);
            //linkedList.Append(10);
            //linkedList.Append(11);
            //linkedList.Append(12);
            //linkedList.Append(13);

            ListNode headB = linkedList.head;

            linkedList.DisplayLinkedLIst(headA);
            linkedList.DisplayLinkedLIst(headB);

            headA = headB.next;

            linkedList.DisplayLinkedLIst(linkedList.FindIntersectionNode(headA, headB));
            Console.ReadKey();
        }
    }
}
