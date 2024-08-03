namespace Tasks_Day_9
{
    public class Duration
    {

        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }


        public Duration()
        {
            Hours = 1;
            Minutes = 30;
            Seconds = 20;

        }

        public Duration(int _timepersecond)
        {
            Hours = _timepersecond / 3600;
            Minutes = (_timepersecond % 3600) / 60;
            Seconds = _timepersecond % 60;
        }

        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;


        }

        public int ToSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration d, Duration other)
        {

            return new Duration(d.ToSeconds() + other.ToSeconds());
        }

        public static Duration operator +(Duration d, int seconds)
        {

            return new Duration(d.ToSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {

            return new Duration(d.ToSeconds() + seconds);
        }

        public static Duration operator ++(Duration d)
        {

            return new Duration(d.ToSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {

            return new Duration(d.ToSeconds() - 60);
        }




        public static bool operator >(Duration d, Duration other)
        {
            return d.Hours > other.Hours && d.Minutes > other.Minutes && d.Seconds > other.Seconds;
        }

        public static bool operator <(Duration d, Duration other)
        {
            return d.Hours < other.Hours && d.Minutes < other.Minutes && d.Seconds < other.Seconds;
        }

        public static bool operator >=(Duration d, Duration other)
        {
            return d.Hours >= other.Hours && d.Minutes >= other.Minutes && d.Seconds >= other.Seconds;
        }

        public static bool operator <=(Duration d, Duration other)
        {
            return d.Hours <= other.Hours && d.Minutes <= other.Minutes && d.Seconds <= other.Seconds;



        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }


        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }

        public override bool Equals(object? obj)
        {
            var duration = obj as Duration;

            if (duration == null) return false;

            if (duration.GetType() != typeof(Duration)) return false;

            if (object.ReferenceEquals(duration, this)) return true;

            return this.Hours == duration.Hours && this.Minutes == duration.Minutes && this.Seconds == duration.Seconds;
        }
    }
}
