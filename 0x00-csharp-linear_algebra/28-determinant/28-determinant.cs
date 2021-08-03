using System;

///<summary>Defines functions for matrices.</summary>
class MatrixMath
{
	///<summary>Calculates the determinant of a matrix.</summary>
	///<param name="matrix">Matrix input.</param>
	///<returns>The determinant, or -1 if matrix isn't 2D or 3D.</returns>
	public static double Determinant(double[,] matrix)
	{
		int limitY = matrix.GetUpperBound(0);
		int limitX = matrix.GetUpperBound(1);
		if (limitY < 1 || limitY > 2)
			return -1;
		double result = 0;
		if (limitY == 1)
		{
			result += matrix[0, 0] * matrix[1, 1];
			result -= matrix[0, 1] * matrix[1, 0];
		}
		else
		{
			result += matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] + matrix[1, 2] * matrix[2, 1]);
			result += matrix[1, 0] * (matrix[0, 1] * matrix[2, 2] + matrix[0, 2] * matrix[2, 1]);
			result += matrix[2, 0] * (matrix[0, 1] * matrix[1, 2] + matrix[0, 2] * matrix[1, 1]);
		}
		return result;
	}
}
