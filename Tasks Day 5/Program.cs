namespace Tasks_Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack


            //Console.Write("Enter The Size of the Array :  ");
            //StacKk st = new StacKk(int.Parse(Console.ReadLine()));


            //while (true)
            //{
            //    Console.WriteLine($"1- Push \n 2-Pop \n 3- Peek \n  4- Print The Stack ");
            //    int choosen = int.Parse(Console.ReadLine());

            //    switch (choosen)
            //    {
            //        case 1:
            //            Console.Write("Enter The Element : ");
            //            st.Push(int.Parse(Console.ReadLine()));
            //            break;
            //        case 2:

            //            st.Pop();
            //            break;
            //        case 3:
            //            Console.WriteLine(st.PeeK());
            //            break;
            //        case 4:
            //            st.Print();
            //            break;
            //        default:
            //            Console.WriteLine("PLease Try Again");
            //            break;
            //    }
            //}
            #endregion


            #region ShiftQueue



            //QueueK Qu = new QueueK(3);
            //Qu.Enqueue(5);
            //Qu.Enqueue(4);
            //Qu.Enqueue(9);
            //Qu.DeQueue();
            //Qu.Enqueue(10);
            //Qu.DeQueue();
            //Qu.DeQueue();
            //Qu.Enqueue(3);





            //Qu.Print();

            #endregion


            #region CicularQueue

            CQueue cQu = new CQueue(3);

            cQu.Enqueue(1);
            cQu.Enqueue(2);
            cQu.Enqueue(3);
            cQu.Dequeue();


            cQu.PrintQueue();
            #endregion

            Console.ReadKey();
        }
    }
}
