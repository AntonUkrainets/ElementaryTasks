using System;
using System.Collections.Generic;
using DigitTranslater.Localization;
using DigitTranslater.Localization.Interfaces;
using DigitTranslater.Model;
using DigitTranslater.Parser;
using Liba.Logger.Interfaces;
using Moq;
using Xunit;

namespace DigitTranslaterTests.Parser
{
    public class InputDataParserTests
    {
        [Theory]
        [InlineData("RU", 123, "Ru", "123")]
        [InlineData("EN", 456, "eN", "456")]
        [InlineData("UA", 123456, "Ua", "123456")]
        public void GetInputData_Test(
            string expectedLocaly,
            int expectedNumber,
            params string[] args
        )
        {
            // Arrange
            var expectedValue = new InputData()
            {
                LocalizationName = expectedLocaly,
                Number = expectedNumber
            };

            var logger = new Mock<ILogger>();

            var languageNumbersDescriptors = new ILanguageNumbersDescriptor[]
            {
                new EnLoсalizationNumbers(),
                new RuLocalizationNumbers(),
                new UaLocalizationNumbers()
            };

            var inputDataParser = new InputDataParser(languageNumbersDescriptors, logger.Object);

            // Act
            var actualValue = inputDataParser.GetInputData(args);

            // Assert
            Assert.Equal(expectedValue.LocalizationName, actualValue.LocalizationName);
            Assert.Equal(expectedValue.Number, actualValue.Number);
        }

        [Theory]
        [InlineData("ru", "str")]
        [InlineData("en", "abc")]
        [InlineData("ua", "qwe")]
        public void GetInputData_NotNumbers_Tests(params string[] args)
        {
            // Arrange
            var logger = new Mock<ILogger>();

            var languageNumbersDescriptors = new ILanguageNumbersDescriptor[]
            {
                new EnLoсalizationNumbers(),
                new RuLocalizationNumbers(),
                new UaLocalizationNumbers()
            };

            var inputDataParser = new InputDataParser(languageNumbersDescriptors, logger.Object);

            // Assert
            Assert.Throws<FormatException>(() => inputDataParser.GetInputData(args));
        }

        [Theory]
        [InlineData("ru", "-1")]
        [InlineData("en", "-1")]
        [InlineData("ua", "-1")]
        public void GetInputData_NegativeNumbers_Tests(params string[] args)
        {
            // Arrange
            var logger = new Mock<ILogger>();

            var languageNumbersDescriptors = new ILanguageNumbersDescriptor[]
            {
                new EnLoсalizationNumbers(),
                new RuLocalizationNumbers(),
                new UaLocalizationNumbers()
            };

            var inputDataParser = new InputDataParser(languageNumbersDescriptors, logger.Object);

            // Assert
            Assert.Throws<ArgumentException>(() => inputDataParser.GetInputData(args));
        }

        [Fact]
        public void GetInputData_OverflowNumbers_Tests()
        {
            // Arrange
            var args = new string[] { "ru", "1000000000" };

            var logger = new Mock<ILogger>();

            var languageNumbersDescriptors = new List<ILanguageNumbersDescriptor>
                {
                    new EnLoсalizationNumbers(),
                    new RuLocalizationNumbers(),
                    new UaLocalizationNumbers()
                };

            var inputDataParser = new InputDataParser(languageNumbersDescriptors, logger.Object);

            // Assert
            Assert.Throws<OverflowException>(() => inputDataParser.GetInputData(args));
        }
    }
}