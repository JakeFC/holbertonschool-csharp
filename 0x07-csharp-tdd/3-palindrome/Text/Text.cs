using System;

namespace Text
{
    /// <summary>Custom string class.</summary>
    public class Str
    {
        /// <summary>Checks whether the letters of a string form a pallindrome.</summary>
        /// <param name="s">String input.</param>
        /// <returns>True if palindrome, or false if not.</returns>
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            string removeChars = "";
            foreach (char c in s)
            {
                if (c < 97 || c > 122)
                    removeChars += c;
            }
            s = String.Join("", s.Split(removeChars.ToCharArray()));
            int start = 0;
            for (int end = s.Length - 1; start < end; start++, end--)
            {
                if (s[start] != s[end])
                    return false;
            }
            return true;
        }
    }
}
