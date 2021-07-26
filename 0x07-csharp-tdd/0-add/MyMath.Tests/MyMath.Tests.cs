using System;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>Test class for Operations.Add() method.</summary>
    [TestFixture]
    public class AddTests
    {
        /// <summary>Tests Operations.Add() method with positive numbers.</summary>
        [Test]
        public void AddPositive()
        {
            Assert.AreEqual(6, Operations.Add(2, 4));
        }
        /// <summary>Tests Operations.Add() method with negative numbers.</summary>
        [Test]
        public void AddNegative()
        {
            Assert.AreEqual(-4, Operations.Add(-1, -3));
        }
        /// <summary>Tests Operations.Add() method with positive and negative numbers.</summary>
        [Test]
        public void AddPositiveAndNegative()
        {
            Assert.AreEqual(5, Operations.Add(-2, 7));
        }
        /// <summary>Tests Operations.Add() method with a positive number and zero.</summary>
        [Test]
        public void AddZero()
        {
            Assert.AreEqual(1, Operations.Add(0, 1));
        }
    }
}