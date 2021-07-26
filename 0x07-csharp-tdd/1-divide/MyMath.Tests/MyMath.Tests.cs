using System;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Class containing all unittests for Matrix class methods.</summary>
    public class MatrixTests
    {
        private static int[,] matrix = new int[2, 2]{{2, 4}, {6, 8}};
        /// <summary>Tests regular division.</summary>
        [Test]
        public void SimpleDivide()
        {
            int [,] res = Matrix.Divide(MatrixTests.matrix, 2);
            Assert.AreEqual(res, new int[2, 2]{{1, 2}, {3, 4}});
        }
        /// <summary>Tests division of a null matrix.</summary>
        [Test]
        public void NullMatrixDivision()
        {
            int [,] res = Matrix.Divide(null, 1);
            Assert.AreEqual(res, null);
        }
        /// <summary>Tests error message of dividing by zero.</summary>
        [Test]
        public void DivideByZeroError()
        {
            try
            {
                int [,] res = Matrix.Divide(matrix, 0);
            }
            catch(Exception e)
            {
                Assert.AreEqual(e, "Num cannot be 0");
            }
        }
        /// <summary>Tests return value of dividing by zero.</summary>
        [Test]
        public void DivideByZeroReturn()
        {
            int [,] res = Matrix.Divide(matrix, 0);
            Assert.AreEqual(res, null);
        }
    }
}