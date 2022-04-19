using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(-2, 3, 5, 6)]
        [InlineData(2, -3, 5, 4)]
        [InlineData(2, 3, -5, 0)]
        [InlineData(2, -3, -5, -6)]
        [InlineData(0, 3, 5, 8)]
        [InlineData(2, 0, 5, 7)]
        [InlineData(2, 3, 0, 5)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-5, -10, -3, -18)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var testAdd = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = testAdd.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,10,-6)]//Add test data <-------
        [InlineData(10,4,6)]
        [InlineData(0,0,0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var testSub = new Calculator();
            //Act
            var actual = testSub.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,2,2)]//Add test data <-------
        [InlineData(0, 2, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(10, 2, 20)]
        [InlineData(-5, 0, 0)]
        [InlineData(-5, -5, 25)]
        [InlineData(5, -5, -25)]
        [InlineData(-5, 5, -25)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var testMult = new Calculator();
            //Act
            var actual = testMult.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,2)]//Add test data <-------
        [InlineData(0,5,0)]
        [InlineData(-10,5,-2)]
        [InlineData(-10,-5,2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divTest = new Calculator();
            //Act
            var actual = divTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
