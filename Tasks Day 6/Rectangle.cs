namespace Tasks_Day_6V2
{
    class Rectangle : GeoShapes
    {
        public Rectangle()
        {

        }
        public Rectangle(double _dim1, double _dim2) : base(_dim1, _dim2)
        {

        }


        public override double CalArea()
        {
            return Dim1 * Dim2;
        }

    }
}
