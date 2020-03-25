using System.Collections.Generic;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Localization
{
    public abstract class LanguageNumbersDescriptor : ILanguageNumbersDescriptor
    {
        public Dictionary<int, string> Vocabulary { get; protected set; }

        public string Name { get; protected set; }

        public IList<string> Number { get; }

        public LanguageNumbersDescriptor()
        {
            InitLanguage();
        }

        public abstract void InitLanguage();
    }
}