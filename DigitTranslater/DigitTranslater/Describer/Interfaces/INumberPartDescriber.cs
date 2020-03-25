using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Describer.Interfaces
{
    public interface INumberPartDescriber
    {
        string Describe(int number, ILanguageNumbersDescriptor numbersDescriptor);
    }
}