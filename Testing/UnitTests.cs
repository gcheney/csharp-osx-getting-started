using System;
using Xunit;

namespace Testing
{
    public class UnitTests
    {
        [Fact]
        public void ReturnFiveMoreThanInput()
        {
            //Arrange
            int input = 10;
            int expectedResult = 15;

            //Act
            int actualResult = input.PlusFive();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void UtilitiesReturnFiveMoreThanInput()
        {
            //Arrange
            int input = 10;
            var utilities = new Utilities();
            int expectedResult = 15;

            //Act
            int actualResult = utilities.PlusFive(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}