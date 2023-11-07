using DavidLibrary;
using System.Data;

namespace TestDavidLibrary
{
    public class TestNumberLibrary
    {
        [Fact]
        public void TestPi()
        {
            Assert.Equal(3.1415, NumberLibrary.PI);
        }
        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(5, 2, 3)]
        [InlineData(-3, -1, -2)]
        [InlineData(-1, 1, -2)]
        public void TestAdd(int sum, int a, int b)
        {
            Assert.Equal(sum, NumberLibrary.Add(a, b));
        }
        [Theory]
        [InlineData(2, 4, 2)]
        [InlineData(6, 4, -2)]
        [InlineData(0, -2, -2)]
        public void TestSub(int sum, int a, int b)
        {
            Assert.Equal(sum, NumberLibrary.Subtract(a, b));
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(0, 0, 2)]
        [InlineData(4, -2, -2)]
        [InlineData(-4, 2, -2)]
        public void TestMulti(int sum, int a, int b)
        {
            Assert.Equal(sum, NumberLibrary.Multiply(a, b));
        }
        [Theory]
        [InlineData(6, 12, 2)]
        [InlineData(-3, 6, -2)]
        [InlineData(3, -6, -2)]
        public void TestDivide(int sum, int a, int b)
        {
            Assert.Equal(sum, NumberLibrary.Divide(a, b));
        }
        [Theory]
        [InlineData(0, 2, 2)]
        [InlineData(1, 3, 2)]
        public void TestMod(int sum, int a, int b)
        {
            Assert.Equal(sum, NumberLibrary.Modulo(a,b));
        }
        [Theory]
        [InlineData(8, 2)]
        [InlineData(64, 4)]
        [InlineData(-512, -8)]
        public void TestCube(int sum, int a)
        {
            Assert.Equal(sum, NumberLibrary.Cubed(a));
        }
    }
}