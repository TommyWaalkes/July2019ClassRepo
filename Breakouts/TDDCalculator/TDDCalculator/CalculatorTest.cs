using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDCalculator
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Calculator c = new Calculator();
            int actual = c.Add(1,2);
            int expected = 3;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd5PLus10ShouldBe15()
        {
            Calculator c = new Calculator();
            int expected = 15;
            int actual = c.Add(5, 10);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,2)]
        [InlineData(3, 5)]
        [InlineData(500, 350)]
        public void TestAddManyValues(int x, int y)
        {
            Calculator c = new Calculator();

            int expected = x + y;
            int actual = c.Add(x, y);

            Assert.Equal(0, actual);
        }
    }
}
