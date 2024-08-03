namespace Tasks_Day_5
{
    class CQueue
    {
        int[] queue;
        int front;
        int rear;
        int size;
        int count;

        public CQueue(int _size)
        {
            size = _size;
            queue = new int[_size];
            front = 0;
            rear = 0;
            count = 0;
        }


        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");

            }

            queue[rear] = item;
            rear = (rear + 1) % size;
            count++;

        }


        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");

            }


            int item = queue[front];
            front = (front + 1) % size;
            count--;
            return item;
        }


        public bool IsEmpty()
        {
            return count == 0;
        }


        public bool IsFull()
        {
            return count == size;
        }





        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            int i = front;
            for (int j = 0; j < count; j++)
            {
                Console.Write(queue[i] + " ");
                i = (i + 1) % size;
            }
            Console.WriteLine();
        }
    }
}