using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ru
{
    public class RuHundredDescriberTests
    {
        [Theory]
        [InlineData(100, "сто")]
        [InlineData(500, "пятьсот")]
        [InlineData(999, "девятьсот")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var hundredDescriber = new HundredDescriber();
            var ruLocalizationNumbers = new RuLocalizationNumbers();

            // Act
            var actualValue = hundredDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}