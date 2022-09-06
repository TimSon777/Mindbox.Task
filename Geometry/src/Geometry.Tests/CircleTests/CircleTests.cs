using System;
using Geometry.Domain.Figures;
using Geometry.Tests.CircleTests.Generators;
using Geometry.Tests.Helpers;
using Xunit;

namespace Geometry.Tests.CircleTests;

public class CircleTests
{
    [Theory]
    [ClassData(typeof(AreaGenerator))]
    public void Area_InputValid_Correct(double x, double expectedArea)
    {
        var circle = new Circle(x);
        TestHelpers.AssertArea(circle, expectedArea);
    }
    
    [Fact]
    public void NegativeSemiAxes_InputNotValid_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-777_777_777));
    }
}