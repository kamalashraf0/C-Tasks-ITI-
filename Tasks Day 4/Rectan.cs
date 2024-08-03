namespace Tasks_Day_4
{
    class Rectan
    {
        Point H;
        Point W;
        public Rectan()
        {
            H = null;
            W = null;

        }

        public Rectan(Point _h, Point _w)
        {

            H = _h;
            W = _w;
        }

        public void SetH(Point _H)
        {
            H = _H;
        }
        public void SetW(Point _W)
        {
            W = _W;
        }
        public Point GetH()
        {
            return H;
        }
        public Point GetW()
        {
            return W;
        }



        public void DrawRect()
        {
            Console.WriteLine($" H : {H.GetpointX()}  W : {W.GetpointY()}");
        }
    }
}