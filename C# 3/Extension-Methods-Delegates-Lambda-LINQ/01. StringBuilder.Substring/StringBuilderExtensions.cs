using System;
using System.Text;

namespace StringBuilderExtensions
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex)
        {
            return SubstringOverload(sb, startIndex, sb.ToString().Length - startIndex);
        }

        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            return SubstringOverload(sb, startIndex, length);
        }

        private static StringBuilder SubstringOverload(StringBuilder sb, int startIndex, int length)
        {
            string sbStr = sb.ToString();
            return new StringBuilder(sbStr.Substring(startIndex, length));
        }
    }
}
