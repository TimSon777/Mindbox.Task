namespace Geometry.Domain.Figures;

public class Ellipse : Figure
{
    public double FirstSemiAxis { get; }
    public double SecondSemiAxis { get; }

    public Ellipse(double firstSemiAxis, double secondSemiAxis)
    {
        
        FirstSemiAxis = ThrowWhenLengthNegativeOrQuit(firstSemiAxis);
        SecondSemiAxis = ThrowWhenLengthNegativeOrQuit(secondSemiAxis);
    }

    public override double Area => Math.PI * FirstSemiAxis * SecondSemiAxis;
    
    private static double ThrowWhenLengthNegativeOrQuit(double semiAxisLength)
    {
        if (semiAxisLength < 0)
        {
            throw new ArgumentException(
                $"The length of the ellipse semi-axis cannot be negative. Actual is {semiAxisLength}");
        }

        return semiAxisLength;
    }
}