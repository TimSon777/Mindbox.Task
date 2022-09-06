using Geometry.Domain;
using Xunit;

namespace Geometry.Tests.Helpers;

public static class TestHelpers
{
    public static void AssertArea(Figure figure, double expectedArea)
    {
        Assert.Equal(figure.Area, expectedArea, 2);
    }
}