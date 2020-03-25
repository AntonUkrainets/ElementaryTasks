using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.Ru
{
    public class EnDozenDescriberTests
    {
        [Theory]
        [InlineData(10, "десять")]
        [InlineData(11, "одиннадцать")]
        [InlineData(19, "девятнадцать")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var dozenDescriber = new DozenDescriber();
            var ruLocalizationNumbers = new RuLocalizationNumbers();

            // Act
            var actualValue = dozenDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}