using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ua
{
    public class UaDozenDescriberTests
    {
        [Theory]
        [InlineData(10, "десять")]
        [InlineData(11, "одинадцять")]
        [InlineData(19, "дев'ятнадцять")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var dozenDescriber = new DozenDescriber();
            var uaLocalizationNumbers = new UaLocalizationNumbers();

            // Act
            var actualValue = dozenDescriber.Describe(number, uaLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}