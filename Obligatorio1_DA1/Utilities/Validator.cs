using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static bool AsciiCharacterRangeForPassword(string text)
        {
            Regex AllCharactersAcceptedInPassword = new Regex(@"^[ -~]+$", RegexOptions.Compiled);
            return AllCharactersAcceptedInPassword.IsMatch(text);
        }

        public static bool StringIsExactlyThisLong(int supposedLong, string text)
        {
            return text.Length == supposedLong;
        }

        public static bool NumberCardOnlyDigits(string cardNumber)
        {
            Regex onlyNumbers16Length = new Regex(@"^[0-9]{16}", RegexOptions.Compiled);
            return onlyNumbers16Length.IsMatch(cardNumber);
        }
    }
}
