using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ru
{
    public class RuDozenMillionsDescriberTests
    {
        [Theory]
        [InlineData(10000000, "десять миллионов")]
        [InlineData(50000500, "пятьдесят")]
        [InlineData(99090090, "девяносто")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var dozenMillionsDescriber = new DozenMillionsDescriber();
            var ruLocalizationNumbers = new RuLocalizationNumbers();

            // Act
            var actualValue = dozenMillionsDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}