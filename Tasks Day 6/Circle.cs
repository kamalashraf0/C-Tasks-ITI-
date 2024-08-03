namespace Tasks_Day_6V2
{
    class Circle : GeoShapes
    {
        Circle() { }
        public Circle(double radius) : base(radius, radius)
        {

        }

        public override double CalArea()
        {
            return Math.PI * Dim1 * Dim2;
        }
    }
}
