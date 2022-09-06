namespace Geometry.Domain.Figures;

public class Circle : Ellipse
{
    public double Radius { get; }

    public Circle(double radius) : base(radius, radius)
    {
        Radius = radius;
    }
}