using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>Test class for Operations.Add() method.</summary>
    public class AddTests
    {
        /// <summary>Tests Operations.Add() method with positive numbers.</summary>
        [Test]
        public void AddingPositive()
        {
            int sum = Operations.Add(2, 4);
            Assert.AreEqual(6, sum);
        }
        /// <summary>Tests Operations.Add() method with negative numbers.</summary>
        [Test]
        public void AddingNegative()
        {
            int sum = Operations.Add(-1, -3);
            Assert.AreEqual(-4, sum);
        }
        /// <summary>Tests Operations.Add() method with positive and negative numbers.</summary>
        [Test]
        public void AddingPositiveAndNegative()
        {
            int sum = Operations.Add(-2, 7);
            Assert.AreEqual(5, sum);
        }
    }
}