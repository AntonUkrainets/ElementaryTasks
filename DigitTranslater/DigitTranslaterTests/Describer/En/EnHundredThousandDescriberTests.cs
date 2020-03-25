using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.En
{
    public class EnHundredThousandDescriberTests
    {
        [Theory]
        [InlineData(100000, "one hundred")]
        [InlineData(500500, "five hundreds")]
        [InlineData(999999, "nine hundreds")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var hundredThousandDescriber = new HundredThousandDescriber();
            var ruLocalizationNumbers = new EnLoсalizationNumbers();

            // Act
            var actualValue = hundredThousandDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}