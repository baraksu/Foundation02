using GetNumbersWhenSumOfDigitsGreaterThanNum;
using Xunit;
namespace Bagrut2023
{
    public class GetNumbersWhenSumOfDigitsGreaterThanNumTests
    {
        [Fact]
        public void GetNumbers_WhenExists()
        {
            // Arrange
            int num = 8;
            int[] numbers = { 15,81,3,8,111,9,10011 };

            int[] expected = { 1,5};
            // Act
            var result = Program.GetNumbersWhenSumOfDigitsGreaterThanNum(num,numbers);

            // Assert
            Assert.Equal(expected,result);
        }
        [Fact]
        public void GetNumbers_WhenNotExists()
        {
            // Arrange
            int num = 35;
            int[] numbers = { 15, 81, 3, 8, 111, 9, 10011 };

            int[] expected = { 1, 5 };
            // Act
            var result = Program.GetNumbersWhenSumOfDigitsGreaterThanNum(num, numbers);

            // Assert
            Assert.Null(result);
        }



    }
}