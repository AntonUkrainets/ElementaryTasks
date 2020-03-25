using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.En
{
    public class EnMillionDescriberTests
    {
        [Theory]
        [InlineData(1000000, "one million")]
        [InlineData(5000500, "five millions")]
        [InlineData(9999999, "nine millions")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var millionDescriber = new MillionDescriber();
            var ruLocalizationNumbers = new EnLoсalizationNumbers();

            // Act
            var actualValue = millionDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}