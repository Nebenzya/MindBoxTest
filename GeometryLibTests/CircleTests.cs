using GeometryLib;
using Xunit;


namespace GeometryLibTests
{
    public class CircleTests
    {
        [Fact]
        public void CircleAreaTest_Input1_Output2()
        {
            double expected = Math.PI;
            Сircle circle = new Сircle(1);
            double actual = circle.Area();
            Assert.Equal(expected, actual);
        }
    }
}
