using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_WorksWithsumoftwonumbers()
        {
            var expected = 10;
            var a = 5;
            var b = 5;
            var actual = sum(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(2)]
        [InlineData(6)]
        [InlineData(8)]
        public void Iseven_WorksWithManyInputs(int value)
        {
            Assert.True(Iseven(value));
        }
        int sum(int a, int b)
        {
            return a + b;
        }
        bool Iseven(int value)
        {
            return value % 2 == 0;
        }

    }
}
