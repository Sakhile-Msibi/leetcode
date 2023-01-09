using System;

namespace RemoveElements
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

        public ListNode RemoveLinkedListElements(ListNode head, int val)
        {
            ListNode current = head;
            ListNode prev_node = head;
            
            while (current != null)
            {
                if (head.data == val)
                {
                    head = head.next;
                } 
                else if (current.data == val && current.next != null)
                {
                    while (current != null && current.data == val)
                    {
                        current = current.next;
                    }
                    prev_node.next = current;

                    if (current == null)
                        break;
                }
                else if (current.data == val && current.next == null)
                {
                    prev_node.next = null;
                }

                prev_node = current;
                current = current.next;
            }

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
            ListNode cuurent = head;
            while (cuurent.next != null)
            {
                cuurent = cuurent.next;
            }

            cuurent.next = new_node;
        }

        public void DisplayLinkedList(ListNode head)
        {
            ListNode current = head;

            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.Append(6);
            //linkedList.Append(3);
            //linkedList.Append(4);
            //linkedList.Append(5);
            //linkedList.Append(6);
            //linkedList.DisplayLinkedList(linkedList.head);

            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.Append(2);
            ////linkedList.Append(2);
            //linkedList.Append(1);
            //linkedList.DisplayLinkedList(linkedList.head);

            linkedList.Append(5);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(2);
            linkedList.Append(1);
            linkedList.Append(1);
            linkedList.DisplayLinkedList(linkedList.head);

            linkedList.DisplayLinkedList(linkedList.RemoveLinkedListElements(linkedList.head, 1));
            Console.ReadKey();
        }
    }
}
