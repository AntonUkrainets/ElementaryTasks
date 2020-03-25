using System.Collections.Generic;

namespace DigitTranslater.Localization.Interfaces
{
    public interface ILanguageNumbersDescriptor
    {
        Dictionary<int, string> Vocabulary { get; }

        string Name { get; }
    }
}