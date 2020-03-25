using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ua
{
    public class UaDozenThousandDescriberTests
    {
        [Theory]
        [InlineData(10000, "десять тисяч")]
        [InlineData(50500, "п'ятдесят")]
        [InlineData(99099, "дев'яносто")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var dozenThousandDescriber = new DozenThousandDescriber();
            var uaLocalizationNumbers = new UaLocalizationNumbers();

            // Act
            var actualValue = dozenThousandDescriber.Describe(number, uaLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}