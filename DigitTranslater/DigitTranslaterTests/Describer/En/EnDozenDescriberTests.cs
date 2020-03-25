using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.En
{
    public class EnDozenDescriberTests
    {
        [Theory]
        [InlineData(10, "ten")]
        [InlineData(11, "eleven")]
        [InlineData(19, "nineteen")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var dozenDescriber = new DozenDescriber();
            var ruLocalizationNumbers = new EnLoсalizationNumbers();

            // Act
            var actualValue = dozenDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}