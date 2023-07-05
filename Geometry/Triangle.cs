namespace GeometryLib;

public class Triangle : Shape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    /// <summary>
    /// Является ли треугольник прямоугольным
    /// </summary>
    public bool IsRight
    {
        get
        {
            if ((Math.Pow(A, 2) + Math.Pow(B, 2)) == Math.Pow(C, 2))
                return true;
            else
                return false;
        }
    }

    public Triangle(double cathetA, double cathetB, double hypotenuseC)
    {
        A = cathetA;
        B = cathetB;
        C = hypotenuseC;
    }

    public override double Area()
    {
        double p = (A + B + C) / 2;
        return Math.Pow((p*(p-A)*(p-B)*(p-C)), 0.5);
    }
}
