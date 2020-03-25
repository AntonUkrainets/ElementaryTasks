using System.Collections.Generic;
using System.Text;
using DigitTranslater.Describer;
using DigitTranslater.Describer.Interfaces;
using DigitTranslater.Localization.Interfaces;

namespace DigitTranslater.Business
{
    public static class NumberConverter
    {
        private static readonly List<INumberPartDescriber> describers;

        static NumberConverter()
        {
            describers = new List<INumberPartDescriber>
            {
                new HundredMillionDescriber(),
                new DozenMillionsDescriber(),
                new MillionDescriber(),
                new HundredThousandDescriber(),
                new DozenThousandDescriber(),
                new ThousandDescriber(),
                new HundredDescriber(),
                new DozenDescriber(),
                new UnitDescriber()
            };
        }

        public static string ConvertToString(
            int number,
            ILanguageNumbersDescriptor numbersDictionary
        )
        {
            var result = new StringBuilder();

            foreach (var describer in describers)
            {
                var part = describer.Describe(number, numbersDictionary);

                result.Append(part);

                if (part != string.Empty)
                    result.Append(" ");
            }

            return result.ToString().Trim();
        }
    }
}