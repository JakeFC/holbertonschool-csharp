using System;

///<summary>Defines math functions for matrices.</summary>
class MatrixMath
{
	///<summary>Calculates the inverse of a 2D matrix.</summary>
	///<param name="matrix">Matrix input.</param>
	///<returns>The resulting matrix, or [-1] if matrix is not 2D or not invertible.</returns>
	public static double[,] Inverse2D(double[,] matrix)
	{
		if (matrix.GetUpperBound(0) != 1 || matrix.GetUpperBound(1) != 1)
			return new double[,]{{-1},};
		double determinant = 0;
		determinant += matrix[0, 0] * matrix[1, 1];
		determinant -= matrix[0, 1] * matrix[1, 0];
		if (determinant == 0)
			return new double[,]{{-1},};
		var result = new double[2,2];
		determinant = 1 / determinant;
		result[0,0] = Math.Round(determinant * matrix[1, 1], 2);
		result[0,1] = Math.Round(determinant * -matrix[0, 1], 2);
		result[1,0] = Math.Round(determinant * -matrix[1, 0], 2);
		result[1,1] = Math.Round(determinant * matrix[0, 0], 2);
		return result;
	}
}
