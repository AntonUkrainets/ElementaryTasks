using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.En
{
    public class EnThousandDescriberTests
    {
        [Theory]
        [InlineData(1000, "one thousand")]
        [InlineData(2500, "two thousands")]
        [InlineData(9999, "nine thousands")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var thousandDescriber = new ThousandDescriber();
            var ruLocalizationNumbers = new EnLoсalizationNumbers();

            // Act
            var actualValue = thousandDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}