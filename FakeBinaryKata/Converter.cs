using System;
using System.Text.RegularExpressions;

namespace FakeBinaryKata
{
    internal class Converter
    {
        public static string DigitsStringToBinary(string digitsString)
        {

            // replace all digits less than 5 with 0
            string replaceDigitsLessThanFive = Regex.Replace(digitsString, "[0-4]", "0");

            // replace all digits greater than 5 with 1
            string replaceDigitsgreaterThanFive = Regex.Replace(replaceDigitsLessThanFive, "[5-9]", "1");

            return replaceDigitsgreaterThanFive;
        }
    }
}