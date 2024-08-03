namespace Tasks_Day_5
{
    class QueueK
    {
        int front;
        int rear;
        int[] arr;
        int size;


        public QueueK()
        {
            size = 5;
            arr = new int[size];
            front = 0;
            rear = 0;
        }

        public QueueK(int _size)
        {
            size = _size;
            arr = new int[size];
            front = 0;
            rear = 0;

        }


        public void Enqueue(int value)
        {
            if (rear != size)
            {
                arr[rear++] = value;
            }
            else
            {
                Console.WriteLine("Queue is FULL");
            }
        }

        public void DeQueue()
        {
            if (front != rear)
            {
                Console.WriteLine(arr[front]);

                for (int i = front; i < rear - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                rear--;
            }
            else
            {
                Console.WriteLine("Queue is Empty");

            }
        }



        public void Print()
        {
            Console.Write("[");
            for (int i = rear - 1; i >= front; i--)
            {


                Console.Write($"{arr[i]} ");

            }
            Console.Write("]");

        }
    }
}