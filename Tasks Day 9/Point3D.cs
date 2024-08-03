namespace Tasks_Day_9
{
    public class Point3D
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        //public Point3D(int _x , int _y)
        //{
        //    X = _x;
        //    Y = _y;
        //}

        public Point3D(int _x, int _y, int _z = 0)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }

        public override string ToString()
        {
            return $" Point Coordinates ({X},{Y},{Z}) ";
        }

        public override bool Equals(object? obj)
        {
            var Coordinate = obj as Point3D;

            if (Coordinate == null) return false;

            if (Coordinate.GetType() != this.GetType()) return false;

            if (object.ReferenceEquals(this, Coordinate)) return true;

            return this.X == Coordinate.X && this.Y == Coordinate.Y && this.Z == Coordinate.Z;
        }

    }
}
