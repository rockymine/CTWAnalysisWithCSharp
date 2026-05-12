using CTWAnalysis.Domain.Common;
using Xunit;

namespace CTWAnalysis.Domain.Tests.Common;

public class PositionTests
{
    [Fact]
    public void TwoPositionsWithSameCoordinates_AreEqual()
    {
        // Arrange
        var a = new Position(1.0, 2.0, 3.0);
        var b = new Position(1.0, 2.0, 3.0);

        // Assert
        Assert.Equal(a, b);
    }

    [Fact]
    public void TwoPositionsWithDifferentCoordinates_AreNotEqual()
    {
        // Arrange
        var a = new Position(1.0, 2.0, 3.0);
        var b = new Position(2.0, 2.0, 3.0);

        // Assert
        Assert.NotEqual(a, b);
    }

    [Fact]
    public void DistanceTo_ReturnsEuclideanDistance()
    {
        // Arrange
        var origin = new Position(0, 0, 0);
        var point = new Position(3, 0, 4);

        // Act
        var distance = origin.DistanceTo(point);

        // Assert
        Assert.Equal(5.0, distance, precision: 5);
    }
}