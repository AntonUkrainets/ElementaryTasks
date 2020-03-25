using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ua
{
    public class UaHundredThousandDescriberTests
    {
        [Theory]
        [InlineData(100000, "сто")]
        [InlineData(500500, "п'ятсот")]
        [InlineData(999999, "дев'ятсот")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var hundredThousandDescriber = new HundredThousandDescriber();
            var uaLocalizationNumbers = new UaLocalizationNumbers();

            // Act
            var actualValue = hundredThousandDescriber.Describe(number, uaLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}