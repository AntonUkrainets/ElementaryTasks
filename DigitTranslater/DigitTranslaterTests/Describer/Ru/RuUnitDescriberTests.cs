using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ru
{
    public class EnUnitDescriberTests
    {
        [Theory]
        [InlineData(0, "ноль")]
        [InlineData(1, "один")]
        [InlineData(9, "девять")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var unitDescriber = new UnitDescriber();
            var ruLocalizationNumbers = new RuLocalizationNumbers();

            // Act
            var actualValue = unitDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}