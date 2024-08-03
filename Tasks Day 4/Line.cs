namespace Tasks_Day_4
{
    class Line
    {
        Point Start;
        Point End;

        public Line(int x, int y)
        {
            Start = new Point();
            End = new Point();

            Start.SetpointX(x);
            End.SetpointY(y);

        }

        public Point GetStart()
        {
            return Start;
        }

        public Point GetEnd()
        {
            return End;
        }

        public void SetStart(Point _start)
        {
            Start = _start;
        }

        public void SetEnd(Point _end)
        {
            End = _end;
        }

        public void DrawLine()
        {
            Console.WriteLine($" Start : {Start.GetpointX()} \n End : {End.GetpointY()} ");
        }

    }
}