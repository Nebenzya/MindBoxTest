using GeometryLib;
using Xunit;

namespace GeometryLibTests;

public class ShapeBuilderTests
{
    [Fact]
    public void GetShapeTest_InputOneParametr_OutputCircleObject()
    {
        Shape shape = ShapeBuilder.GetShape(1);
        var obj = shape as Сircle;
        Assert.NotNull(obj);
    }

    [Fact]
    public void GetShapeTest_InputThreeParametrs_OutputTriangleObject()
    {
        Shape shape = ShapeBuilder.GetShape(1,2,3);
        var obj = shape as Triangle;
        Assert.NotNull(obj);
    }
}
