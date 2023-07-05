using GeometryLib;
using Xunit;

namespace GeometryLibTests;

public class TriangleTests
{
    [Fact]
    public void TriangleAreaTest_Input3_4_5_Output6()
    {
        double expected = 6;
        Triangle triangle = new Triangle(3, 4, 5);
        double actual = triangle.Area();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TriangleIsRightTest_Input3_4_5_OutputTrue()
    {
        bool expected = true;
        Triangle triangle = new Triangle(3, 4, 5);
        bool actual = triangle.IsRight;
        Assert.Equal(expected, actual);
    }
}