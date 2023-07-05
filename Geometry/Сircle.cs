namespace GeometryLib;

public class Сircle : Shape
{
    public double Radius { get; }

    public Сircle(double radius)
    {
        Radius = radius;
    }

    public override double Area() => Math.PI * Radius * Radius;
}
