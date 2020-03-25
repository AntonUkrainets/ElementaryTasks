using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ru
{
    public class RuHundredMillionDescriberTests
    {
        [Theory]
        [InlineData(100000000, "сто")]
        [InlineData(500005000, "пятьсот")]
        [InlineData(990990099, "девятьсот")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var hundredMillionDescriber = new HundredMillionDescriber();
            var ruLocalizationNumbers = new RuLocalizationNumbers();

            // Act
            var actualValue = hundredMillionDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}