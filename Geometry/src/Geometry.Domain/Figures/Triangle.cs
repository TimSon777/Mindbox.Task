using Geometry.Domain.Helpers;

namespace Geometry.Domain.Figures;

public class Triangle : Figure
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    private readonly IReadOnlyList<double> _sortedSidesAsc;
    
    public bool IsRectangular 
        => Math.Abs(_sortedSidesAsc[2].Sqr() - (_sortedSidesAsc[1].Sqr() + _sortedSidesAsc[0].Sqr())) < .00001;

    public Triangle(double a, double b, double c)
    {
        ThrowWhenNotCorrect(a, b, c);
        
        FirstSide = a;
        SecondSide = b;
        ThirdSide = c;

        _sortedSidesAsc = new[] {a, b, c}
            .OrderBy(x => x)
            .ToArray();
    }

    public override double Area
    {
        get
        {
            var semiPerimeter = Perimeter / 2;
            var areaIsSquared = semiPerimeter *
                                (semiPerimeter - FirstSide) *
                                (semiPerimeter - SecondSide) *
                                (semiPerimeter - ThirdSide);
            
            return Math.Sqrt(areaIsSquared);
        }
    }

    public double Perimeter => FirstSide + SecondSide + ThirdSide;

    private static void ThrowWhenLengthNegative(double sideLength)
    {
        if (sideLength < 0)
        {
            throw new ArgumentException($"The length of the triangle's side cannot be negative. Actual is {sideLength}");
        }
    }

    private static void ThrowWhenNotCorrect(double a, double b, double c)
    {
        ThrowWhenLengthNegative(a);
        ThrowWhenLengthNegative(b);
        ThrowWhenLengthNegative(c);

        if (a + b < c || a + c < b || b + c < a)
        {
            throw new ArgumentException($"Triangle with such sides doesn't exist: {a}, {b}, {c}");
        }
    }
}