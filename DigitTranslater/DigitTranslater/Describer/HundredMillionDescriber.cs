using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer
{
    public class HundredMillionDescriber : INumberPartDescriber
    {
        public string Describe(
            int number,
            ILanguageNumbersDescriptor numbersDescriptor
        )
        {
            var hundredsMillions = (number % 1000000000) - (number % 100000000);

            if (hundredsMillions >= 100000000)
                return numbersDescriptor.Vocabulary[hundredsMillions];

            return string.Empty;
        }
    }
}