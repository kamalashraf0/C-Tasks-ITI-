namespace Tasks_Day_6V2
{
    abstract class GeoShapes
    {
        protected double Dim1 { get; set; }
        protected double Dim2 { get; set; }

        public GeoShapes()
        {
            Dim1 = 0;
            Dim2 = 0;
        }

        public GeoShapes(double _dim1, double _dim2)
        {
            Dim1 = _dim1;

            Dim2 = _dim2;
        }

        public GeoShapes(GeoShapes _geoshapes)
        {
            Dim1 = _geoshapes.Dim1;
            Dim2 = _geoshapes.Dim2;

        }

        public abstract double CalArea();

    }
}
