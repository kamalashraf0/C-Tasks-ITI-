namespace Tasks_Day_6V2
{
    class Utiltity
    {
        public static double SumofAreas(GeoShapes[] geo)
        {
            double sum = 0;

            for (int i = 0; i < geo.Length; i++)
            {
                sum += geo[i].CalArea();
            }

            return sum;
        }
    }
}
