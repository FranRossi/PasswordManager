using System.Text.RegularExpressions;

namespace Obligatorio1_DA1.Utilities
{
    public static class Validator
    {
        public static bool MaxLengthOfString(string text, int maxNumber)
        {
            return (text.Length <= maxNumber);
        }

        public static bool MinLengthOfString(string text, int minNumber)
        {
            return (text.Length >= minNumber);
        }

        public static bool LengthOfStringBetweenTwoNumbers(string text, int minNumber, int maxNumber)
        {
            return MinLengthOfString(text, minNumber) && MaxLengthOfString(text, maxNumber);
        }

        public static bool AsciiCharacterRangeForPassword(string text)
        {
            Regex AllCharactersAcceptedInPassword = new Regex(@"^[ -~]+$", RegexOptions.Compiled);
            return AllCharactersAcceptedInPassword.IsMatch(text);
        }

        public static bool StringIsExactlyThisLong(int supposedLong, string text)
        {
            return text.Length == supposedLong;
        }

        public static bool OnlyDigits(string text)
        {
            Regex onlyDigits = new Regex(@"^[0-9]+$", RegexOptions.Compiled);
            return onlyDigits.IsMatch(text);
        }
    }
}
