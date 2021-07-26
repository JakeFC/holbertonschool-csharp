using System;

namespace MyMath
{
    /// <summary>MyMath class containing methods for working with matrices.</summary>
    public class Matrix
    {
        /// <summary>Divides all elements of a matrix.</summary>
        /// <param name="matrix">2-D array to be divided.</param>
        /// <param name="num">Number by which to divide the matrix.</param>
        /// <returns>A new matrix containing divided elements, or null if impossible.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }
            if (num == 0)
            {
                Console.Error.WriteLine("Num cannot be 0");
                return null;
            }
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                    matrix[y, x] /= num;
            }
            return matrix;
        }
    }
}
