using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ru
{
    public class RuHundredThousandDescriberTests
    {
        [Theory]
        [InlineData(100000, "сто")]
        [InlineData(500500, "пятьсот")]
        [InlineData(999999, "девятьсот")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var hundredThousandDescriber = new HundredThousandDescriber();
            var ruLocalizationNumbers = new RuLocalizationNumbers();

            // Act
            var actualValue = hundredThousandDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}