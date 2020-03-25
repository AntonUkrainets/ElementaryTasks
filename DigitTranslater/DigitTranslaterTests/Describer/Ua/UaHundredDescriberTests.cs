using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ua
{
    public class UaHundredDescriberTests
    {
        [Theory]
        [InlineData(100, "сто")]
        [InlineData(500, "п'ятсот")]
        [InlineData(999, "дев'ятсот")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var hundredDescriber = new HundredDescriber();
            var uaLocalizationNumbers = new UaLocalizationNumbers();

            // Act
            var actualValue = hundredDescriber.Describe(number, uaLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}