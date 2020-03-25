using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.En
{
    public class EnHundredMillionDescriberTests
    {
        [Theory]
        [InlineData(100000000, "one hundred")]
        [InlineData(500005000, "five hundreds")]
        [InlineData(990990099, "nine hundreds")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var hundredMillionDescriber = new HundredMillionDescriber();
            var ruLocalizationNumbers = new EnLoсalizationNumbers();

            // Act
            var actualValue = hundredMillionDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}