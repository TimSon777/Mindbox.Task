using Xunit;

namespace Geometry.Tests.EllipseTests.Generators;

public class AreaGenerator : TheoryData<double, double, double>
{
    public AreaGenerator()
    {
        Add(5, 7, 109.95574);
        Add(0, 43, 0);
        Add(54, 77, 13062.74225);
    }
}