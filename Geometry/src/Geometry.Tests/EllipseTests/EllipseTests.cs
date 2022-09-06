using System;
using Geometry.Domain.Figures;
using Geometry.Tests.EllipseTests.Generators;
using Geometry.Tests.Helpers;
using Xunit;

namespace Geometry.Tests.EllipseTests;

public class EllipseTests
{
    [Theory]
    [ClassData(typeof(NegativeSemiAxesGenerator))]
    public void NegativeSemiAxes_InputNotValid_ThrowException(double x, double y)
    {
        Assert.Throws<ArgumentException>(() => new Ellipse(x, y));
    }
    
    [Theory]
    [ClassData(typeof(AreaGenerator))]
    public void Area_InputValid_Correct(double x, double y, double expectedArea)
    {
        var ellipse = new Ellipse(x, y);
        TestHelpers.AssertArea(ellipse, expectedArea);
    }
}