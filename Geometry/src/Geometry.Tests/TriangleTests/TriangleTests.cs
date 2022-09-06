using System;
using Geometry.Domain.Figures;
using Geometry.Tests.Helpers;
using Geometry.Tests.TriangleTests.Generators;
using Xunit;

namespace Geometry.Tests.TriangleTests;

public class TriangleTests
{
    [Theory]
    [ClassData(typeof(NegativeSidesGenerator))]
    public void NegativeSides_InputNotValid_ThrowException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    
    [Theory]
    [ClassData(typeof(NotExistsGenerator))]
    public void NotExist_InputNotValid_ThrowException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    
    [Theory]
    [ClassData(typeof(IsRectangularTrueGenerator))]
    public void IsRectangle_InputValid_True(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.True(triangle.IsRectangular);
    }
    
    [Theory]
    [ClassData(typeof(IsRectangularFalseGenerator))]
    public void IsRectangle_InputValid_False(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.False(triangle.IsRectangular);
    }
    
    [Theory]
    [ClassData(typeof(AreaGenerator))]
    public void Area_InputValid_Correct(double a, double b, double c, double expectedArea)
    {
        var triangle = new Triangle(a, b, c);
        TestHelpers.AssertArea(triangle, expectedArea);
    }
}