using DigitTranslater.Validation;
using Xunit;

namespace DigitTranslaterTests.Validation
{
    public class ValidatorTests
    {
        [Fact]
        public void IsNumberOverflow_Positive()
        {
            // Arrange
            var number = 1000000000;

            // Act
            var actualValue = Validator.IsNumberOverflow(number);

            // Assert
            Assert.True(actualValue);
        }

        [Fact]
        public void IsNumberOverflow_Negative()
        {
            // Arrange
            var number = 100;

            // Act
            var actualValue = Validator.IsNumberOverflow(number);

            // Assert
            Assert.False(actualValue);
        }

        [Fact]
        public void IsPositiveNumber_Positive()
        {
            // Arrange
            var number = 0;

            // Act
            var actualValue = Validator.IsPositiveNumber(number);

            // Assert
            Assert.True(actualValue);
        }

        [Fact]
        public void IsPositiveNumber_Negative()
        {
            // Arrange
            var number = -1;

            // Act
            var actualValue = Validator.IsPositiveNumber(number);

            // Assert
            Assert.False(actualValue);
        }

        [Fact]
        public void IsParametersValid_Positive()
        {
            // Arrange
            var args = new string[] { "someArgs1", "someArgs2" };

            // Act
            var actualValue = Validator.IsParametersValid(args);

            // Assert
            Assert.True(actualValue);
        }

        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("a", "b", "c")]
        public void IsParametersValid_Negative(params string[] args)
        {
            // Act
            var actualValue = Validator.IsParametersValid(args);

            // Assert
            Assert.False(actualValue);
        }
    }
}