using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer
{
    public class DozenMillionsDescriber : INumberPartDescriber
    {
        public string Describe(
            int number, 
            ILanguageNumbersDescriptor numbersDescriptor
        )
        {
            var subDozenMillions = (number % 100000000) - (number % 1000000);
            if (subDozenMillions > 10000000 &&
                subDozenMillions < 20000000)
            {
                return numbersDescriptor.Vocabulary[subDozenMillions];
            }

            var dozenMillions = (number % 100000000) - (number % 10000000);

            if (dozenMillions >= 10000000)
                return numbersDescriptor.Vocabulary[dozenMillions];

            return string.Empty;
        }
    }
}