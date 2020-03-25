using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ru
{
    public class RuThousandDescriberTests
    {
        [Theory]
        [InlineData(1000, "одна тысяча")]
        [InlineData(2500, "две тысячи")]
        [InlineData(9999, "девять тысяч")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var thousandDescriber = new ThousandDescriber();
            var ruLocalizationNumbers = new RuLocalizationNumbers();

            // Act
            var actualValue = thousandDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}