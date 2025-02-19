using Xunit;

public class CircleTests
{
    [Fact]
    public void CalculateCircumference_ValidRadius_ReturnsCorrectResult()
    {
        double result = Circle.CalculateCircumference(1);
        Assert.Equal(6.28, result, 2);
    }

    [Fact]
    public void CalculateArea_ValidRadius_ReturnsCorrectResult()
    {
        double result = Circle.CalculateArea(1);
        Assert.Equal(3.14, result, 2);
    }
}
