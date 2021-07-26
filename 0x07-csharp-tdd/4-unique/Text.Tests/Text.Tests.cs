using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Unittests for Str.UniqueChar() method functionality.</summary>
    [TestFixture]
    public class UniqueCharTests
    {
        /// <summary>Test for first character in string being unique.</summary>
        [Test]
        public void FirstCharacterUnique()
        {
            Assert.AreEqual(0, Str.UniqueChar("mississippi"));
        }

        /// <summary>Test for last character in string being unique.</summary>
        [Test]
        public void LastCharacterUnique()
        {
            Assert.AreEqual(4, Str.UniqueChar("peeps"));
        }

        /// <summary>Test for middle character in string being unique.</summary>
        [Test]
        public void MiddleCharacterUnique()
        {
            Assert.AreEqual(2, Str.UniqueChar("level"));
        }

        /// <summary>Test for multiple characters in string being unique.</summary>
        [Test]
        public void MultipleUniqueCharacters()
        {
            Assert.AreEqual(1, Str.UniqueChar("papyrus"));
        }

        /// <summary>Test for no character in string being unique.</summary>
        [Test]
        public void NoUniqueCharacters()
        {
            Assert.AreEqual(-1, Str.UniqueChar("toot"));
        }

        /// <summary>Test for empty string.</summary>
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }
    }
}