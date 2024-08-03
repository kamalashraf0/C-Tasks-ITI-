namespace Tasks_Day_6V2
{
    class Triangle : GeoShapes
    {
        public Triangle()
        {

        }
        public Triangle(double _dim1, double _dim2) : base(_dim1, _dim2)
        {

        }

        public override double CalArea()
        {
            return 0.5 * Dim1 * Dim2;
        }
    }
}
