using Tasks_Day_6V2;

namespace Tasks_Day_6
{

    //#region Early/Static Binding  


    //class GeoShapes
    //{
    //    protected double Dim1 { get; set; }
    //    protected double Dim2 { get; set; }

    //    public GeoShapes()
    //    {
    //        Dim1 = 0;
    //        Dim2 = 0;
    //    }

    //    public GeoShapes(double _dim1, double _dim2)
    //    {
    //        Dim1 = _dim1;

    //        Dim2 = _dim2;
    //    }

    //    public GeoShapes(GeoShapes _geoshapes)
    //    {
    //        Dim1 = _geoshapes.Dim1;
    //        Dim2 = _geoshapes.Dim2;

    //    }


    //}

    //class Rectangle : GeoShapes
    //{
    //    public Rectangle()
    //    {

    //    }
    //    public Rectangle(double _dim1, double _dim2) : base(_dim1, _dim2)
    //    {

    //    }


    //    public double CalArea()
    //    {
    //        return Dim1 * Dim2;
    //    }

    //}

    //class Square : Rectangle
    //{
    //    public Square()
    //    {

    //    }
    //    public Square(double _dim) : base(_dim, _dim)
    //    {

    //    }


    //}

    //class Circle : GeoShapes
    //{
    //    Circle() { }
    //    public Circle(double radius) : base(radius, radius)
    //    {

    //    }

    //    public double CalArea()
    //    {
    //        return Math.PI * Dim1 * Dim2;
    //    }
    //}

    //class Triangle : GeoShapes
    //{
    //    public Triangle()
    //    {

    //    }
    //    public Triangle(double _dim1, double _dim2) : base(_dim1, _dim2)
    //    {

    //    }

    //    public double CalArea()
    //    {
    //        return 0.5 * Dim1 * Dim2;
    //    }
    //}



    //#endregion

    class Program
    {
        static void Main(string[] args)
        {


            #region Early/Static Binding  

            //GeoShapes geo0 = new GeoShapes(3,4);
            //GeoShapes geo = new GeoShapes(geo0); 


            //Console.WriteLine();




            #endregion


            #region Late/Dynamic Binding

            Rectangle rec = new Rectangle(3, 4);  //12;

            Square sq = new Square(3);   //9

            Circle C = new Circle(3);   //28.274333882308138



            GeoShapes[] geoShapes = { rec, sq, C };

            Console.WriteLine(rec.CalArea() + sq.CalArea() + C.CalArea());

            Console.WriteLine(Utiltity.SumofAreas(geoShapes));



            #endregion



            Console.ReadKey();
        }




    }
}
