using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ua
{
    public class UaDozenMillionsDescriberTests
    {
        [Theory]
        [InlineData(10000000, "десять мільйонів")]
        [InlineData(50000500, "п'ятдесят")]
        [InlineData(99090090, "дев'яносто")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var dozenMillionsDescriber = new DozenMillionsDescriber();
            var uaLocalizationNumbers = new UaLocalizationNumbers();

            // Act
            var actualValue = dozenMillionsDescriber.Describe(number, uaLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}