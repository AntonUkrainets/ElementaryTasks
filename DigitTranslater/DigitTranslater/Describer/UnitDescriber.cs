using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer
{
    public class UnitDescriber : INumberPartDescriber
    {
        public string Describe(
            int number,
            ILanguageNumbersDescriptor numbersDescriptor
        )
        {
            var units = number % 100;

            if (units > 10 &&
                units < 20)
            {
                return string.Empty;
            }

            units = number % 10;

            if (units == 0 &&
                number > 0)
            {
                return string.Empty;
            }

            return numbersDescriptor.Vocabulary[units];
        }
    }
}