namespace Tasks_Day_5
{
    class StacKk
    {

        int[] arr;
        int size, top;

        public StacKk()
        {
            arr = new int[10];
            top = 0;
        }
        public StacKk(int _size)
        {
            size = _size;
            arr = new int[_size];
            top = 0;

        }

        public void Push(int value)
        {
            if (top == size)
            {
                Console.WriteLine("Stack OverFlow");
            }
            else
            {
                arr[top] = value;
                top++;

            }

        }
        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {

                Console.WriteLine(arr[--top]);
            }

        }

        public int PeeK()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                return (arr[top - 1]);
            }
        }

        public void Print()
        {
            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine("\t\t__");
                Console.WriteLine($"\t\t|{arr[i]}|");


            }
        }

        public bool IsEmpty()
        {
            return top == 0;
        }
    }
}