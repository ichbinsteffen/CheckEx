using System;
using System.Text.RegularExpressions;

namespace CheckEx
{
    public class CheckEx
    {
        private const string DEFAULT_PATTERN_ALL_NUMBERS = @"^\-?\d{1,3}(\d*|(\,\d{3})*)?(\.\d*)?([Ee][\+\-]?\d+)?$";
        private string PatternAllNumbers = DEFAULT_PATTERN_ALL_NUMBERS;

        public CheckEx()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="decimalSeparator">The decimal separator is optional in the inspected string. Nonetheless you can specify it in order to match only numbers that make correct use of the separator when there is one.</param>
        /// <param name="thousandSeparator">The thousand separator is optional in the inspected string. Nonetheless you can specify it in order to match only numbers that make correct use of the separator when there are some.</param>
        public CheckEx(char decimalSeparator, char thousandSeparator)
        {
            if (decimalSeparator == thousandSeparator)
            {
                throw new ArgumentException();
            }
                
            PatternAllNumbers = PatternAllNumbers.Replace('.', decimalSeparator);
            PatternAllNumbers = PatternAllNumbers.Replace(',', thousandSeparator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsNumber(string input)
        {
            return Regex.IsMatch(input, DEFAULT_PATTERN_ALL_NUMBERS);
        }
    }
}
