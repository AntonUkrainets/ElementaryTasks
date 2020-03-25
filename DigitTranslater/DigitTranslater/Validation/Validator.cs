namespace DigitTranslater.Validation
{
    public static class Validator
    {
        public static bool IsNumberOverflow(int number)
        {
            return number >= 1000000000; // 1 billion
        }

        public static bool IsPositiveNumber(int number)
        {
            return number >= 0;
        }

        public static bool IsParametersValid(string[] args)
        {
            return args.Length == 2;
        }
    }
}