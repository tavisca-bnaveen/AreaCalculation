using CalucateArea;
using System;
using Xunit;

namespace AreaTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var testTriangle = new Triangle(4, 5);
            Assert.Equal(10, testTriangle.Area());
        }
        [Fact]
        public void Test2()
        {
            var testCircle = new Circle(7);
            Assert.Equal(154, testCircle.Area());
        }
        [Fact]
        public void Test3()
        {
            var testRectangle = new Rectangle(4, 5);
            Assert.Equal(20, testRectangle.Area());
        }
        [Fact]
        public void Test4()
        {
            var testSquare = new Square(4);
            Assert.Equal(16, testSquare.Area());
        }
    }
}
