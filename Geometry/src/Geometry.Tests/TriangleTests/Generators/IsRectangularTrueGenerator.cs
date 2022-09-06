namespace Geometry.Tests.TriangleTests.Generators;

public class IsRectangularTrueGenerator : SidesTheoryData
{
    public IsRectangularTrueGenerator()
    {
        Add(3, 4, 5);
        Add(40, 30, 50);
        Add(500, 300, 400);
    }
}