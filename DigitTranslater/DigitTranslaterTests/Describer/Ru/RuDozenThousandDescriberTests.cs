using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ru
{
    public class RuDozenThousandDescriberTests
    {
        [Theory]
        [InlineData(10000, "десять тысяч")]
        [InlineData(50500, "пятьдесят")]
        [InlineData(99099, "девяносто")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var dozenThousandDescriber = new DozenThousandDescriber();
            var ruLocalizationNumbers = new RuLocalizationNumbers();

            // Act
            var actualValue = dozenThousandDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}