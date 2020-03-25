using DigitTranslater.Business;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests
{
    public class ConverterRuTests
    {
        [Theory]
        [InlineData(0, "ноль")]
        [InlineData(1, "один")]
        [InlineData(10, "десять")]
        [InlineData(11, "одиннадцать")]
        [InlineData(19, "девятнадцать")]
        [InlineData(35, "тридцать пять")]
        [InlineData(50, "пятьдесят")]
        [InlineData(99, "девяносто девять")]
        [InlineData(100, "сто")]
        [InlineData(345, "триста сорок пять")]
        [InlineData(999, "девятьсот девяносто девять")]
        [InlineData(1000, "одна тысяча")]
        [InlineData(1245, "одна тысяча двести сорок пять")]
        [InlineData(7777, "семь тысяч семьсот семьдесят семь")]
        [InlineData(11111, "одиннадцать тысяч сто одиннадцать")]
        [InlineData(19000, "девятнадцать тысяч")]
        [InlineData(45256, "сорок пять тысяч двести пятьдесят шесть")]
        [InlineData(90000, "девяносто тысяч")]
        [InlineData(95000, "девяносто пять тысяч")]
        [InlineData(99999, "девяносто девять тысяч девятьсот девяносто девять")]
        [InlineData(100000, "сто тысяч")]
        [InlineData(150000, "сто пятьдесят тысяч")]
        [InlineData(900000, "девятьсот тысяч")]
        [InlineData(999999, "девятьсот девяносто девять тысяч девятьсот девяносто девять")]
        [InlineData(1000000, "один миллион")]
        [InlineData(1500000, "один миллион пятьсот тысяч")]
        [InlineData(8545324, "восемь миллионов пятьсот сорок пять тысяч триста двадцать четыре")]
        [InlineData(9999999, "девять миллионов девятьсот девяносто девять тысяч девятьсот девяносто девять")]
        [InlineData(10000000, "десять миллионов")]
        [InlineData(15000000, "пятнадцать миллионов")]
        [InlineData(50000000, "пятьдесят миллионов")]
        [InlineData(77243921, "семьдесят семь миллионов двести сорок три тысячи девятьсот двадцать один")]
        [InlineData(99999999, "девяносто девять миллионов девятьсот девяносто девять тысяч девятьсот девяносто девять")]
        [InlineData(100000000, "сто миллионов")]
        [InlineData(123478934, "сто двадцать три миллиона четыреста семьдесят восемь тысяч девятьсот тридцать четыре")]
        [InlineData(150000000, "сто пятьдесят миллионов")]
        [InlineData(500000000, "пятьсот миллионов")]
        [InlineData(999999999, "девятьсот девяносто девять миллионов девятьсот девяносто девять тысяч девятьсот девяносто девять")]
        public void ConvertNumber_Positive_Tests(int number, string expectedValue)
        {
            // Arrange
            var localization = new RuLocalizationNumbers();

            // Act
            var actualValue = NumberConverter.ConvertToString(number, localization);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}