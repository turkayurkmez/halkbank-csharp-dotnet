using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class CustomExtensions
    {
        public static double GetSquare(this int value)
        {
            return Math.Pow(value, 2);
        }

        public static string RemoveEmptySpaces(this string value)
        {
            return value.Replace(" ", string.Empty);
        }

        public static string ToTitleCase(this string value)
        {
            var array = value.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                string source = array[i];
                array[i] = $"{source.Substring(0, 1).ToUpperInvariant()}{source.Substring(1)}";

            }

            return string.Join(" ", array);
        }

        public static char NextChar(this Random random, bool isLowerCase = true)
        {

            return isLowerCase ? (char)random.Next(97, 123) : (char)random.Next(65, 91);
        }

        public static string NextString(this Random random, int length, bool isLowerCase = true)
        {
            string response = string.Empty;
            for (int i = 0; i < length; i++)
            {
                var randomChar = random.NextChar(isLowerCase);
                response += randomChar;
            }
            return response;
        }
    }
}
