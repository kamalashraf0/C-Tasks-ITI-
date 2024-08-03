namespace Tasks_Day_4
{
    class Point
    {
        private int pointX;
        private int pointY;


        public Point()
        {
            SetpointX(1);
            SetpointY(2);
        }

        public int GetpointX()
        {
            return pointX;
        }
        public int GetpointY()
        {
            return pointY;
        }

        public void SetpointX(int _pointX)
        {
            this.pointX = _pointX;
        }

        public void SetpointY(int _pointY)
        {
            this.pointY = _pointY;
        }



    }
}