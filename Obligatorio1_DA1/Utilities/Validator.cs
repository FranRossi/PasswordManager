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
        public static bool maxLength(string text, int maxNumber)
        {
            return (text.Length <= maxNumber);
        }

        public static bool minLength(string text, int minNumber)
        {
            return (text.Length >= minNumber);
        }

        public static bool asciiCharacterRange(string text)
        {
            Regex regex = new Regex(@"^[ -~]+$", RegexOptions.Compiled);
            return (regex.IsMatch(text));
        }
    }
}
