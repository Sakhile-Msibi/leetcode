namespace DesignLinearQueue
{
    internal class MyQueue
    {
        private List<int> _queue;

        private int _pointer;

        public MyQueue()
        {
            _queue = new List<int>();
            _pointer = 0;
        }

        public Boolean enQueue(int x)
        {
            _queue.Add(x);

            return true;
        }

        public Boolean deQueue()
        {
            if (isEmpty())
            {
                return false;
            }

            _pointer++;
            return true;
        }

        public int Front()
        {
            return _queue[_pointer];
        }

        public Boolean isEmpty()
        {
            return _pointer >= _queue.Count;
        }

        public void DisplayList(List<int> list)
        {
            foreach (int x in list)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            Console.WriteLine(queue.enQueue(5));
            queue.DisplayList(queue._queue);

            Console.WriteLine(queue.enQueue(3));
            queue.DisplayList(queue._queue);

            if (!queue.isEmpty())
            {
                Console.WriteLine(queue.Front());
            }

            Console.WriteLine(queue.deQueue());
            queue.DisplayList(queue._queue);

            if (!queue.isEmpty())
            {
                Console.WriteLine(queue.Front());
            }

            Console.ReadKey();
        }

    }
}