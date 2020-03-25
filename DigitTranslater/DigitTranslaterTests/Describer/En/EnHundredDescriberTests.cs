using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.En
{
    public class EnHundredDescriberTests
    {
        [Theory]
        [InlineData(100, "one hundred")]
        [InlineData(500, "five hundreds")]
        [InlineData(999, "nine hundreds")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var hundredDescriber = new HundredDescriber();
            var ruLocalizationNumbers = new EnLoсalizationNumbers();

            // Act
            var actualValue = hundredDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}