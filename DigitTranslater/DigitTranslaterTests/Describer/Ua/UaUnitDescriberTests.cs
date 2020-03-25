using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ua
{
    public class UaUnitDescriberTests
    {
        [Theory]
        [InlineData(0, "нуль")]
        [InlineData(1, "один")]
        [InlineData(9, "дев'ять")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var unitDescriber = new UnitDescriber();
            var uaLocalizationNumbers = new UaLocalizationNumbers();

            // Act
            var actualValue = unitDescriber.Describe(number, uaLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}