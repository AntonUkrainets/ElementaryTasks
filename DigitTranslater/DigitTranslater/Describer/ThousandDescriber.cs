using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer
{
    public class ThousandDescriber : INumberPartDescriber
    {
        public string Describe(
            int subThousands,
            ILanguageNumbersDescriptor numbersDescriptor
        )
        {
            var result = string.Empty;

            if (subThousands > 10000 &&
                subThousands < 20000)
            {
                return string.Empty;
            }

            var thousands = (subThousands % 10000) - (subThousands % 1000);

            if (thousands >= 1000)
                result = numbersDescriptor.Vocabulary[thousands];

            if (thousands == 0 &&
                subThousands % 1000000 >= 10000)
            {
                result += numbersDescriptor.Vocabulary[-1000];
            }

            return result;
        }
    }
}