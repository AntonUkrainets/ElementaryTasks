using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ru
{
    public class RuMillionDescriberTests
    {
        [Theory]
        [InlineData(1000000, "один миллион")]
        [InlineData(5000500, "пять миллионов")]
        [InlineData(9999999, "девять миллионов")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var millionDescriber = new MillionDescriber();
            var ruLocalizationNumbers = new RuLocalizationNumbers();

            // Act
            var actualValue = millionDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}