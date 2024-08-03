namespace Tasks_Day_4
{
    class Program
    {


        static void Main(string[] args)
        {

            //pass by ref and value for ref type (search)
            #region Complex Constructor

            //Console.WriteLine("Enter real ... ");
            //Console.WriteLine("\tthen img ... ");
            //Complex C1 = new Complex(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            //Complex C2 = new Complex();

            //C1.Add(C2);

            //Console.Write($" => {C1.Print()} \n  Nums Of Ctor : {Complex.counter} ");

            #endregion

            #region Composition

            //Line L1 = new Line(5, 3);

            //L1.DrawLine();

            #endregion

            #region Aggregation/Association

            Point p1 = new Point();
            Point p2 = new Point();

            Rectan rect2 = new Rectan(p1, p2);
            Rectan rect1 = new Rectan();
            rect1.SetH(p1);
            rect1.SetW(p2);

            rect1.DrawRect();

            #endregion


            Console.ReadKey();
        }
    }
}
