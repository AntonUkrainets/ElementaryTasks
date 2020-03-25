using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ua
{
    public class UaHundredMillionDescriberTests
    {
        [Theory]
        [InlineData(100000000, "сто")]
        [InlineData(500005000, "п'ятсот")]
        [InlineData(990990099, "дев'ятсот")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var hundredMillionDescriber = new HundredMillionDescriber();
            var uaLocalizationNumbers = new UaLocalizationNumbers();

            // Act
            var actualValue = hundredMillionDescriber.Describe(number, uaLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}