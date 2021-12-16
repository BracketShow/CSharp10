namespace CSharpBefore10
{
    public struct Point
    {
        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }

    public class StructUsage
    {
        public void UseStruct()
        {
            var point = new Point(1, 2);
            point.X = 8;
        }
    }
}
