using Xunit;

namespace Geometry.Tests.TriangleTests.Generators;

public class AreaGenerator : TheoryData<double, double, double, double>
{
    public AreaGenerator()
    {
        Add(3, 4, 5, 6);
        Add(6, 7, 3, 8.94427190);
        Add(23, 33, 44, 371.0795063);
        Add(0, 5, 5, 0);
    }
}