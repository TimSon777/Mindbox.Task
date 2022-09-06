namespace Geometry.Tests.TriangleTests.Generators;

public class NegativeSidesGenerator : SidesTheoryData
{
    public NegativeSidesGenerator()
    {
        Add(0, 0, -1);
        Add(-5, 4, 5);
        Add(-3, -3, 0);
        Add(-777, -777, -777);
    }
}