using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer
{
    public class HundredThousandDescriber : INumberPartDescriber
    {
        public string Describe(
            int number,
            ILanguageNumbersDescriptor numbersDescriptor
        )
        {
            var hundredsThousands = (number % 1000000) - (number % 100000);

            if (hundredsThousands >= 100000)
                return numbersDescriptor.Vocabulary[hundredsThousands];

            return string.Empty;
        }
    }
}