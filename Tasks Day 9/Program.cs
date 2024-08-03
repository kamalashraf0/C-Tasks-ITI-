namespace Tasks_Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Point3D

            //var Point3d = new Point3D(10, 10, 10);

            //Console.WriteLine(Point3d);    // 1







            //console.write("enter coordinate x :   ");
            //int x;
            //while (!(int.tryparse(console.readline(), out x)))
            //{
            //    console.write("wrong input , please enter a numeric value :  ");

            //}

            //console.write("enter coordinate y :   ");
            //int y;
            //while (!(int.tryparse(console.readline(), out y)))
            //{
            //    console.write("wrong input , please enter a numeric value :  ");

            //}
            //var point2d = new Point3d(x, y);

            //console.writeline(point2d);            //2









            //var Point3DRW = new Point3D[1];

            //for (int i = 0; i < Point3DRW.Length; i++)
            //{
            //    Console.Write("Enter Coordinate X :   ");
            //    int x;
            //    while (!(int.TryParse(Console.ReadLine(), out x)))
            //    {
            //        Console.Write("Wrong Input , PLease Enter A Numeric Value :  ");

            //    }

            //    Console.Write("Enter Coordinate Y :   ");
            //    int y;
            //    while (!(int.TryParse(Console.ReadLine(), out y)))
            //    {
            //        Console.Write("Wrong Input , PLease Enter A Numeric Value :  ");

            //    }

            //    Console.Write("Enter Coordinate Z :   ");
            //    int z;
            //    while (!(int.TryParse(Console.ReadLine(), out z)))
            //    {
            //        Console.Write("Wrong Input , PLease Enter A Numeric Value :  ");

            //    }

            //    Point3DRW[i] = new Point3D(x, y, z);
            //}


            //foreach (var item in Point3DRW)
            //{
            //    Console.WriteLine(item);
            //}






            #endregion


            #region OverrideEquals

            //var P1 = new Point3D(0, 0, 0);
            //var P2 = new Point3D();

            //Console.WriteLine(P1.Equals(P2));

            #endregion


            #region Math Class

            //Console.WriteLine(Math.Add(5, 6));
            //Console.WriteLine(Math.Subtract(5, 6));
            //Console.WriteLine(Math.Multiply(5, 6));
            //Console.WriteLine(Math.Division(5, 6));

            #endregion


            #region Singleton

            //NIC n = new NIC();

            #endregion


            #region Duration

            //var d1 = new Duration(1, 55, 22);
            //var d2 = new Duration(1, 55, 22);

            //Console.WriteLine(d1.Equals(d2));

            var duraion3 = new Duration();
            //Console.WriteLine(duraion3);    //1:30:20

            //var d4 = new Duration(5, 90, 15);
            ////Console.WriteLine(d1 + " " + d4);   //1:10:15

            //var d5 = new Duration(3600);
            //Console.WriteLine(d5.ToString());   //1:0:0

            //var d6 = new Duration(7800);
            //Console.WriteLine(d6.ToString());   // 2:10:0

            //var d7 = new Duration(666);
            //Console.WriteLine(d7.ToString());   // 0:11:6

            #endregion


            #region Duraion OPOverloading



            //var Dplus = d1 + d4;
            //Console.WriteLine(Dplus);

            //var Dplus2 = d1 + 7800;
            //Console.WriteLine(Dplus2);

            //var Dplus3 = 666 + Dplus2;
            //Console.WriteLine(Dplus3);

            //var OPd = d1++;
            //Console.WriteLine(OPd);

            //var OPd2 = --d1;
            //Console.WriteLine(OPd2);


            //Console.WriteLine(d1 > d4);
            //Console.WriteLine(d1 <= d4);

            //DateTime Obj = (DateTime)d1;
            //Console.WriteLine(Obj);


            #endregion




            Console.ReadKey();
        }
    }
}
