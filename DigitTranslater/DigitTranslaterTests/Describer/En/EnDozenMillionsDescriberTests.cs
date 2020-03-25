using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.En
{
    public class EnDozenMillionsDescriberTests
    {
        [Theory]
        [InlineData(10000000, "ten millions")]
        [InlineData(50000500, "fifty")]
        [InlineData(99090090, "ninety")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var dozenMillionsDescriber = new DozenMillionsDescriber();
            var ruLocalizationNumbers = new EnLoсalizationNumbers();

            // Act
            var actualValue = dozenMillionsDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}