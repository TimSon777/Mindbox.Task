using System;
using Xunit;

namespace Geometry.Tests.CircleTests.Generators;

public class AreaGenerator : TheoryData<double, double>
{
    public AreaGenerator()
    {
        Add(0, 0);
        Add(5, 78.5398);
        Add(1 / Math.PI, 1 / Math.PI);
    }
}