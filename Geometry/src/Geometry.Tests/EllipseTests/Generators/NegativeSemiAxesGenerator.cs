using Xunit;

namespace Geometry.Tests.EllipseTests.Generators;

public class NegativeSemiAxesGenerator : TheoryData<double, double>
{
    public NegativeSemiAxesGenerator()
    {
        Add(-19, -888888);
        Add(-14, 0);
        Add(44, -15);
    }
}