using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Unittests for Str method functionality.</summary>
    [TestFixture]
    public class StrTests
    {
        /// <summary>Tests Str.IsPalindrome() with a basic palindrome of lowercase letters.</summary>
        [Test]
        public void BasicPalindrome()
        {
            Assert.True(Str.IsPalindrome("level"));
        }

        /// <summary>Tests Str.IsPalindrome() with a non-palindrome of letters.</summary>
        [Test]
        public void NotPalindrome()
        {
            Assert.False(Str.IsPalindrome("tacos"));
        }

        /// <summary>Tests Str.IsPalindrome() with a palindrome of upper and lowercase letters.</summary>
        [Test]
        public void IgnoreCasePalindrome()
        {
            Assert.True(Str.IsPalindrome("Racecar"));
        }

        /// <summary>Tests Str.IsPalindrome() with a palindrome of letters, spaces, and punctuation.</summary>
        [Test]
        public void IgnorePunctuationPalindrome()
        {
            Assert.True(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        /// <summary>Tests Str.IsPalindrome() with an empty string.</summary>
        [Test]
        public void EmptyPalindrome()
        {
            Assert.True(Str.IsPalindrome(""));
        }
    }
}