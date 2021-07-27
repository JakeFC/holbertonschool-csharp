using System;

namespace Text
{
    /// <summary>Custom string class.</summary>
    public class Str
    {
        /// <summary>Finds the index of the first unique character in a string.</summary>
        /// <param name="s">String input.</param>
        /// <returns>Index of the first unique character, or -1 if none.</returns>
        public static int UniqueChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                // int lengthRemaining = s.Length - i - 1;
                // if (!(s.Substring(0, i).Contains(c.ToString())) &&
                //     (lengthRemaining == 0 || !(s.Substring(i + 1, lengthRemaining).Contains(c.ToString()))))
                // {
                //     return i;
                // }
                if (s.Split(c).Length - 1 == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
