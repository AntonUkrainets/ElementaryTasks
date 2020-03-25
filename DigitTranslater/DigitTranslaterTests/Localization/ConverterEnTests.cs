using DigitTranslater.Business;
using DigitTranslater.Localization;
using Xunit;

namespace DigitTranslaterTests
{
    public class ConverterEnTests
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "one")]
        [InlineData(10, "ten")]
        [InlineData(11, "eleven")]
        [InlineData(19, "nineteen")]
        [InlineData(35, "thirty five")]
        [InlineData(50, "fifty")]
        [InlineData(99, "ninety nine")]
        [InlineData(100, "one hundred")]
        [InlineData(345, "three hundreds forty five")]
        [InlineData(999, "nine hundreds ninety nine")]
        [InlineData(1000, "one thousand")]
        [InlineData(1245, "one thousand two hundreds forty five")]
        [InlineData(7777, "seven thousands seven hundreds seventy seven")]
        [InlineData(11111, "eleven thousands one hundred eleven")]
        [InlineData(19000, "nineteen thousands")]
        [InlineData(45256, "forty five thousands two hundreds fifty six")]
        [InlineData(90000, "ninety thousand")]
        [InlineData(95000, "ninety five thousands")]
        [InlineData(99999, "ninety nine thousands nine hundreds ninety nine")]
        [InlineData(100000, "one hundred thousand")]
        [InlineData(150000, "one hundred fifty thousand")]
        [InlineData(900000, "nine hundreds thousand")]
        [InlineData(999999, "nine hundreds ninety nine thousands nine hundreds ninety nine")]
        [InlineData(1000000, "one million")]
        [InlineData(1500000, "one million five hundreds thousand")]
        [InlineData(8545324, "eight millions five hundreds forty five thousands three hundreds twenty four")]
        [InlineData(9999999, "nine millions nine hundreds ninety nine thousands nine hundreds ninety nine")]
        [InlineData(10000000, "ten millions")]
        [InlineData(15000000, "fiveteen millions")]
        [InlineData(50000000, "fifty million")]
        [InlineData(77243921, "seventy seven millions two hundreds forty three thousands nine hundreds twenty one")]
        [InlineData(99999999, "ninety nine millions nine hundreds ninety nine thousands nine hundreds ninety nine")]
        [InlineData(100000000, "one hundred million")]
        [InlineData(123478934, "one hundred twenty three millions four hundreds seventy eight thousands nine hundreds thirty four")]
        [InlineData(150000000, "one hundred fifty million")]
        [InlineData(500000000, "five hundreds million")]
        [InlineData(999999999, "nine hundreds ninety nine millions nine hundreds ninety nine thousands nine hundreds ninety nine")]
        public void ConvertNumber(int number, string expectedValue)
        {
            // Arrange
            var localization = new EnLoсalizationNumbers();

            // Act
            var result = NumberConverter.ConvertToString(number, localization);

            // Assert
            Assert.Equal(expectedValue, result);
        }
    }
}