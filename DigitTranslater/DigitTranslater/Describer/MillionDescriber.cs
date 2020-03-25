using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer
{
    public class MillionDescriber : INumberPartDescriber
    {
        public string Describe(
            int number, 
            ILanguageNumbersDescriptor numbersDescriptor
        )
        {
            if (number >= 10000000 &&
                number < 20000000)
            {
                return string.Empty;
            }

            var result = string.Empty;

            var millions = (number % 10000000) - (number % 1000000);

            if (millions >= 1000000)
                result = numbersDescriptor.Vocabulary[millions];

            if (millions == 0 && 
                number % 1000000000 >= 10000000)
            {
                return numbersDescriptor.Vocabulary[-1000000];
            }

            return result;
        }
    }
}