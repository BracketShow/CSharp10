namespace CSharp10;

public record struct Point
{
    public Point()
    {        
    }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; init; } = 0;
    public double Y { get; init; } = 0;
}

public record struct Point2(double X, double Y); // get; set;

public readonly record struct Point3(double X, double Y); // get; init;

public class StructUsage
{
    public void TryStructs()
    {
        var point = new Point()
        {
            X = 5
        };

        var point2 = new Point2(2, 3);
        point2.X = 8;

        var point3 = new Point3(3, 4);
        point3.Y = 88;
    }
}
