using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer
{
    public class DozenDescriber : INumberPartDescriber
    {
        public string Describe(
            int number, 
            ILanguageNumbersDescriptor numbersDescriptor
        )
        {
            var subDozens = number % 100;

            if (subDozens >= 10 && 
                subDozens < 20)
            {
                return numbersDescriptor.Vocabulary[subDozens];
            }

            var dozens = (number % 100) - (number % 10);

            if (dozens >= 20)
                return numbersDescriptor.Vocabulary[dozens];

            return string.Empty;
        }
    }
}