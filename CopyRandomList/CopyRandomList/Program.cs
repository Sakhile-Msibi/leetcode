using System;

namespace CopyRandomList
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;
        
        public Node(int data)
        {
            val = data;
            next = null; random = null;
        }
    }

    class LinkedList
    {
        Node heads;

        public Node DeepCopyRandomList(Node head)
        {
            if (head == null)
                return null;

            Node list = head;
            heads = null;

            while (list != null)
            {
                Append(list.val);
                list = list.next;
            }

            list = head;
            Node lis = heads;
            int num = 0;
            Node temp = head;
            Node tem = heads;

            while (list != null)
            {
                if (list.random == null)
                {
                    lis.random = null;
                }
                else
                {
                    while (temp != list.random)
                    {
                        num++;
                        temp = temp.next;
                    }

                    
                    while (num != 0)
                    {
                        tem = tem.next;
                        num--;
                    }

                    lis.random = tem;
                    tem = heads;
                    temp = head;
                }

                lis = lis.next;
                list = list.next;
            }

            return heads;
        }

        public void Append(int new_data)
        {
            Node new_node = new Node(new_data);

            if (heads == null)
            {
                heads = new Node(new_data);
                return;
            }

            new_node.next = null;
            Node temp = heads;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new_node;
        }

        public void DisplayLinkedList()
        {
            Node temp = heads;

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

            //linkedList.heads = new Node(1);
            //Node second = new Node(2);

            //linkedList.heads.next = second;
            //linkedList.heads.random  = second;
            //second.next = null;
            //second.random = second;

            //linkedList.heads = new Node(3);
            //Node second = new Node(3);
            //Node third = new Node(3);

            //linkedList.heads.next = second;
            //linkedList.heads.random = null;
            //second.next = third;
            //second.random = linkedList.heads;
            //third.next = null;
            //third.random = null;

            linkedList.heads = new Node(7);
            Node second = new Node(13);
            Node third = new Node(11);
            Node fourth = new Node(10);
            Node fifth = new Node(1);

            linkedList.heads.next = second;
            linkedList.heads.random = null;
            second.next = third;
            second.random = linkedList.heads;
            third.next = fourth;
            third.random = fifth;
            fourth.next = fifth;
            fourth.random = third;
            fifth.next = null;
            fifth.random = linkedList.heads;

            linkedList.DisplayLinkedList();

            linkedList.DeepCopyRandomList(linkedList.heads);
            linkedList.DisplayLinkedList();
            Console.ReadKey();
        }
    }
}
