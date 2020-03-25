using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer
{
    public class DozenThousandDescriber : INumberPartDescriber
    {
        public string Describe(
            int number, 
            ILanguageNumbersDescriptor numbersDescriptor
        )
        {
            var result = string.Empty;

            var subDozenThousands = (number % 100000) - (number % 1000);
            if (subDozenThousands > 10000 &&
                subDozenThousands < 20000)
            {
                return numbersDescriptor.Vocabulary[subDozenThousands];
            }

            var dozenThousands = (number % 100000) - (number % 10000);

            if (dozenThousands >= 10000)
                result = numbersDescriptor.Vocabulary[dozenThousands];

            return result;
        }
    }
}