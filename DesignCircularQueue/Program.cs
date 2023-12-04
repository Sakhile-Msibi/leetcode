namespace DesignCircularQueue
{
    internal class MyCircularQueue
    {
        private int[] _queue;
        private int _head;
        private int _tail;

        public MyCircularQueue(int k)
        {
            _queue = new int[k];
            _head = -1;
            _tail = -1;
        }

        public bool EnQueue(int value)
        {
            if (!IsFull())
            {
                if (_tail != _queue.Length - 1)
                {
                    _queue[++_tail] = value;

                    if (_head == -1)
                    {
                        _head = 0;
                    }
                }
                else if (_head != 0 && _tail == _queue.Length - 1)
                {
                    _tail = 0;
                    _queue[_tail] = value;
                }

                return true;
            }

            return false;
        }

        public bool DeQueue()
        {
            if (!IsEmpty())
            {
                if (_head != _queue.Length - 1)
                {
                    _head++;
                }
                else if (_head == _queue.Length - 1)
                {
                    _head = 0;
                }

                if (_head - 1 == _tail)
                {
                    _tail = -1;
                    _head = -1;
                }
                
                return true;
            }

            return false;
        }

        public int Front()
        {
            if (!IsEmpty())
            {
                return _queue[_head];
            }

            return -1;
        }

        public int Rear()
        {
            if (!IsEmpty())
            {
                //int lastElement = _tail;
                return _queue[_tail];
            }

            return -1;
        }

        public bool IsEmpty()
        {
            return _head == -1 && _tail == -1;
        }

        public bool IsFull()
        {
            return _tail + 1 == _head || (_head == 0 && _tail == _queue.Length - 1);
        }

        public void DisplayArray(int[] ints)
        {
            Console.WriteLine("Array");
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Queue");

            if (_tail >= _head)
            {
                for (int i = _head; i <= _tail; i++)
                {
                    Console.Write(_queue[i] + " ");
                }
            }
            else
            {
                for (int i = _tail; i < _queue.Length; i++)
                {
                    Console.Write(_queue[i] + " ");
                }
            }
            
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            MyCircularQueue queue = new MyCircularQueue(5);

            //Console.WriteLine(queue.EnQueue(1));
            //queue.DisplayArray(queue._queue);

            //Console.WriteLine(queue.EnQueue(2));
            //queue.DisplayArray(queue._queue);

            //Console.WriteLine(queue.EnQueue(3));
            //queue.DisplayArray(queue._queue);

            //Console.WriteLine(queue.EnQueue(4));
            //queue.DisplayArray(queue._queue);

            //Console.WriteLine(queue.Rear());

            //Console.WriteLine(queue.IsFull());

            //Console.WriteLine(queue.DeQueue());
            //queue.DisplayArray(queue._queue);

            //Console.WriteLine(queue.EnQueue(4));
            //queue.DisplayArray(queue._queue);

            //Console.WriteLine(queue.Rear());

            Console.WriteLine(queue.IsFull());

            Console.WriteLine(queue.IsEmpty());

            Console.WriteLine(queue.EnQueue(5));
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.EnQueue(13));
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.EnQueue(8));
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.EnQueue(2));
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.EnQueue(10));
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.IsFull());

            Console.WriteLine(queue.IsEmpty());

            Console.WriteLine(queue.DeQueue());
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.DeQueue());
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.EnQueue(23));
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.EnQueue(6));
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.IsFull());

            Console.WriteLine(queue.IsEmpty());

            Console.WriteLine(queue.DeQueue());
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.DeQueue());
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.DeQueue());
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.DeQueue());
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.DeQueue());
            queue.DisplayArray(queue._queue);

            Console.WriteLine(queue.DeQueue());
            queue.DisplayArray(queue._queue);


            Console.ReadKey();
        }
    }
}