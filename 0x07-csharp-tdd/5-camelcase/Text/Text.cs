using System;

namespace Text
{
    /// <summary>Custom string class.</summary>
    public class Str
    {
        /// <summary>Counts the number of words in a camel case string.</summary>
        /// <param name="s">String input.</param>
        /// <returns>The number of words in string.</returns>
        public static int CamelCase(string s)
        {
            if (s.Length == 0)
                return 0;
            int words = 1;
            foreach (char c in s)
            {
                if (c > 64 && c < 91)
                    words++;
            }
            return words;
        }
    }
}
