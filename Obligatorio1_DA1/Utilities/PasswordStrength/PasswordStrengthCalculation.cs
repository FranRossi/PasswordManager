using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public static class PasswordStrengthCalculation
    {
        public static PasswordStrengthColor CalculatePasswordStrength(string passToCheckedStrength)
        {
            if (IsRedStrength(passToCheckedStrength))
                return PasswordStrengthColor.Red;
            if (IsOrangeStrength(passToCheckedStrength))
                return PasswordStrengthColor.Orange;
            return CalculateLargePasswordStrength(passToCheckedStrength);
        }

        private static PasswordStrengthColor CalculateLargePasswordStrength(string passToCheckedStrength)
        {
            bool hasUpperCase, hasLowerCase, hasNumber, hasSymbol;
            hasUpperCase = hasLowerCase = hasNumber = hasSymbol = false;
            int typeCount = 0;
            int maxTypeCount = 4;
            for (int i = 0; i < passToCheckedStrength.Length && typeCount < maxTypeCount; i++)
            {
                if (IsLowerCase(passToCheckedStrength.ElementAt(i)) && !hasLowerCase)
                {
                    typeCount++;
                    hasLowerCase = true;
                }
                else if (IsUpperCase(passToCheckedStrength.ElementAt(i)) && !hasUpperCase)
                {
                    typeCount++;
                    hasUpperCase = true;
                }
                else if (IsNumber(passToCheckedStrength.ElementAt(i)) && !hasNumber)
                {
                    typeCount++;
                    hasNumber = true;
                }
                else if (IsSymbol(passToCheckedStrength.ElementAt(i)) && !hasSymbol)
                {
                    typeCount++;
                    hasSymbol = true;
                }
            }
            if (hasLowerCase && hasUpperCase && !hasNumber && !hasSymbol)
                return PasswordStrengthColor.LightGreen;
            return CheckResultDependingOnTypeCount(typeCount);
        }

        private static PasswordStrengthColor CheckResultDependingOnTypeCount(int typeCount)
        {
            int minTypeCountForGreen = 2;
            if (typeCount > minTypeCountForGreen)
                return (PasswordStrengthColor)typeCount;
            else
                return PasswordStrengthColor.Yellow;
        }

        private static bool IsRedStrength(string passToCheckedStrength)
        {
            Regex lengthBetween1And8 = new Regex(@"^.{1,8}$", RegexOptions.Compiled);
            return lengthBetween1And8.IsMatch(passToCheckedStrength);
        }

        private static bool IsOrangeStrength(string passToCheckedStrength)
        {
            Regex lengthBetween8And14 = new Regex(@"^.{8,14}$", RegexOptions.Compiled);
            return lengthBetween8And14.IsMatch(passToCheckedStrength);
        }

        private static bool IsSymbol(char characterToCheck)
        {
            Regex isSymbol = new Regex(@"^[ -/:-@[-`{-~]+$", RegexOptions.Compiled);
            return isSymbol.IsMatch(characterToCheck.ToString());
        }

        private static bool IsNumber(char characterToCheck)
        {
            Regex isNumber = new Regex(@"^[0-9]+$", RegexOptions.Compiled);
            return isNumber.IsMatch(characterToCheck.ToString());
        }

        private static bool IsUpperCase(char characterToCheck)
        {
            Regex isUpperCase = new Regex(@"^[A-Z]+$", RegexOptions.Compiled);
            return isUpperCase.IsMatch(characterToCheck.ToString());
        }

        private static bool IsLowerCase(char characterToCheck)
        {
            Regex isLowerCase = new Regex(@"^[a-z]+$", RegexOptions.Compiled);
            return isLowerCase.IsMatch(characterToCheck.ToString());
        }
    }
}
