namespace Geometry.Tests.TriangleTests.Generators;

public class NotExistsGenerator : SidesTheoryData
{
    public NotExistsGenerator()
    {
        Add(10000, 10, 20);
        Add(3, 1000, 20);
        Add(1, 1, 20);
    }
}