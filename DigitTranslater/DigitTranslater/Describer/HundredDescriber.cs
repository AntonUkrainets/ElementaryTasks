using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer
{
    public class HundredDescriber : INumberPartDescriber
    {
        public string Describe(
            int number,
            ILanguageNumbersDescriptor numbersDescriptor
        )
        {
            var hundreds = (number % 1000) - (number % 100);

            if (hundreds >= 100)
                return numbersDescriptor.Vocabulary[hundreds];

            return string.Empty;
        }
    }
}