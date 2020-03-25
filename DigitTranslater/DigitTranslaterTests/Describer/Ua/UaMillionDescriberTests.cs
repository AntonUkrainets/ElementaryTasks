using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ua
{
    public class UaMillionDescriberTests
    {
        [Theory]
        [InlineData(1000000, "один мільйон")]
        [InlineData(5000500, "п'ять мільйонів")]
        [InlineData(9999999, "дев'ять мільйонів")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var millionDescriber = new MillionDescriber();
            var uaLocalizationNumbers = new UaLocalizationNumbers();

            // Act
            var actualValue = millionDescriber.Describe(number, uaLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}