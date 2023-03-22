using LW3;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PlusTest()
        {
            // Arrange
            int testOut = 3;

            // Act
            var result = CoreLogic.DoPlus(1, 2);

            // Assert
            Assert.Equal(testOut, result);

        }
        
        [Fact]
        public void MinusTest()
        {
            // Arrange
            int testOut = 1;

            // Act
            var result = CoreLogic.DoMinus(3, 2);

            // Assert
            Assert.Equal(testOut, result);

        }
        [Fact]
        public void DivTest()
        {
            // Arrange
            int testOut = 2;

            // Act
            var result = CoreLogic.DoDivided(10, 5);

            // Assert
            Assert.Equal(testOut, result);

        }
        [Fact]
        public void MulTest()
        {
            // Arrange
            int testOut = 10;

            // Act
            var result = CoreLogic.DoMultiply(2, 5);

            // Assert
            Assert.Equal(testOut, result);

        }
    }
}
