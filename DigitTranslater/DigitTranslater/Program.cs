using System;
using System.Linq;
using DigitTranslater.Business;
using DigitTranslater.Localization;
using DigitTranslater.Localization.Interfaces;
using DigitTranslater.Parser;
using DigitTranslater.Validation;
using Liba.Logger;

namespace DigitTranslater
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            var logPath = "application.log";

            var logger = new AggregatedLogger(
                new FileLogger(logPath),
                new ConsoleLogger()
            );

            try
            {
                if (!Validator.IsParametersValid(args))
                    throw new FormatException("Input data must be in format <LocalizationType> <number>");

                var languageNumbersDescriptors = new ILanguageNumbersDescriptor[]
                {
                    new EnLoсalizationNumbers(),
                    new RuLocalizationNumbers(),
                    new UaLocalizationNumbers()
                };

                var inputDataParser = new InputDataParser(languageNumbersDescriptors, logger);
                var inputData = inputDataParser.GetInputData(args);

                var localization = languageNumbersDescriptors
                    .First(l => l.Name == inputData.LocalizationName);

                var result = NumberConverter.ConvertToString(inputData.Number, localization);

                logger.LogInformation($"Result: {result}");
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);
            }
        }
    }
}