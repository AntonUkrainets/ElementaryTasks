using DigitTranslater.Describer;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests.Describer.En
{
    public class EnDozenThousandDescriberTests
    {
        [Theory]
        [InlineData(10000, "ten thousands")]
        [InlineData(50500, "fifty")]
        [InlineData(99099, "ninety")]
        public void Describe(int number, string expectedValue)
        {
            // Arrange
            var dozenThousandDescriber = new DozenThousandDescriber();
            var ruLocalizationNumbers = new EnLoсalizationNumbers();

            // Act
            var actualValue = dozenThousandDescriber.Describe(number, ruLocalizationNumbers);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}