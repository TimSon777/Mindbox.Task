namespace Geometry.Tests.TriangleTests.Generators;

public class IsRectangularFalseGenerator : SidesTheoryData
{
    public IsRectangularFalseGenerator()
    {
        Add(1, 1, 1);
        Add(4, 5, 6);
        Add(8, 5, 3);
    }
}