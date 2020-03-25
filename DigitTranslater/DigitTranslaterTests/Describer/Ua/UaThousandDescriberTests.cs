using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ua
{
    public class UaThousandDescriberTests
    {
        [Theory]
        [InlineData(1000, "одна тисяча")]
        [InlineData(2500, "дві тисячі")]
        [InlineData(9999, "дев'ять тисяч")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var thousandDescriber = new ThousandDescriber();
            var uaLocalizationNumbers = new UaLocalizationNumbers();

            // Act
            var actualValue = thousandDescriber.Describe(number, uaLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}