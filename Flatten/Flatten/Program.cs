using System;

namespace Flatten
{
    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;

        public Node(int data)
        {
            val = data;
            next = null;
            prev = null;
            child = null;
        }
    }

    class LinkedList
    {
        Node nodeHead;

        public Node FlattenLinkedList(Node head)
        {
            if (head == null)
                return null;

            Node curr = head;
            Node next_node = curr;

            while (curr != null)
            {
                if (curr.child == null)
                {
                    Append(curr.val);
                    curr = curr.next;
                }
                else
                {
                    curr.next.prev = curr;
                    curr = curr.next;
                }
            }

            curr = curr.prev;

            while (curr != null)
            {
                if (curr.prev.child != curr)
                {
                    //Append(curr.val);
                    curr = curr.next;
                }
                else
                {
                    curr = curr.prev;
                    next_node = curr.next;

                    while (next_node != null)
                    {
                        Append(next_node.val);
                        next_node = next_node.next;
                    }

                    curr = curr.prev;
                }
            }

            return nodeHead;
        }

        public void Append(int new_val)
        {

        }

        static void Main(string[] args)
        {
            
        }
    }
}
