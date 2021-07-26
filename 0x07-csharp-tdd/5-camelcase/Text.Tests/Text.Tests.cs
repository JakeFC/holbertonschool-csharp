using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Unittests for Str.CamelCase() method functionality.</summary>
    public class CamelCaseTests
    {
        /// <summary>Tests string containing one word.</summary>
        [Test]
        public void OneWord()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        /// <summary>Tests string containing two words.</summary>
        [Test]
        public void TwoWords()
        {
            Assert.AreEqual(2, Str.CamelCase("muchFun"));
        }

        /// <summary>Tests string containing three words of one letter each.</summary>
        [Test]
        public void ThreeWordsOneLetter()
        {
            Assert.AreEqual(3, Str.CamelCase("iOS"));
        }

        /// <summary>Tests empty string.</summary>
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }
    }
}