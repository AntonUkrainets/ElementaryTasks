using DigitTranslater.Business;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests
{
    public class ConverterUaTests
    {
        [Theory]
        [InlineData(0, "нуль")]
        [InlineData(1, "один")]
        [InlineData(10, "десять")]
        [InlineData(11, "одинадцять")]
        [InlineData(19, "дев'ятнадцять")]
        [InlineData(35, "тридцять п'ять")]
        [InlineData(50, "п'ятдесят")]
        [InlineData(99, "дев'яносто дев'ять")]
        [InlineData(100, "сто")]
        [InlineData(345, "триста сорок п'ять")]
        [InlineData(999, "дев'ятсот дев'яносто дев'ять")]
        [InlineData(1000, "одна тисяча")]
        [InlineData(1245, "одна тисяча двісті сорок п'ять")]
        [InlineData(7777, "сім тисяч сімсот сімдесят сім")]
        [InlineData(11111, "одинадцять тисяч сто одинадцять")]
        [InlineData(19000, "дев'ятнадцять тисяч")]
        [InlineData(45256, "сорок п'ять тисяч двісті п'ятдесят шість")]
        [InlineData(90000, "дев'яносто тисяч")]
        [InlineData(95000, "дев'яносто п'ять тисяч")]
        [InlineData(99999, "дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять")]
        [InlineData(100000, "сто тисяч")]
        [InlineData(150000, "сто п'ятдесят тисяч")]
        [InlineData(900000, "дев'ятсот тисяч")]
        [InlineData(999999, "дев'ятсот дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять")]
        [InlineData(1000000, "один мільйон")]
        [InlineData(1500000, "один мільйон п'ятсот тисяч")]
        [InlineData(8545324, "вісім мільйонів п'ятсот сорок п'ять тисяч триста двадцять чотири")]
        [InlineData(9999999, "дев'ять мільйонів дев'ятсот дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять")]
        [InlineData(10000000, "десять мільйонів")]
        [InlineData(15000000, "п'ятнадцять мільйонів")]
        [InlineData(50000000, "п'ятдесят мільйонів")]
        [InlineData(77243921, "сімдесят сім мільйонів двісті сорок три тисячі дев'ятсот двадцять один")]
        [InlineData(99999999, "дев'яносто дев'ять мільйонів дев'ятсот дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять")]
        [InlineData(100000000, "сто мільйонів")]
        [InlineData(123478934, "сто двадцять три мільйона чотириста сімдесят вісім тисяч дев'ятсот тридцять чотири")]
        [InlineData(150000000, "сто п'ятдесят мільйонів")]
        [InlineData(500000000, "п'ятсот мільйонів")]
        [InlineData(999999999, "дев'ятсот дев'яносто дев'ять мільйонів дев'ятсот дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять")]
        public void ConvertNumber(int number, string expectedValue)
        {
            // Arrange
            var localization = new UaLocalizationNumbers();

            // Act
            var result = NumberConverter.ConvertToString(number, localization);

            // Assert
            Assert.Equal(expectedValue, result);
        }
    }
}