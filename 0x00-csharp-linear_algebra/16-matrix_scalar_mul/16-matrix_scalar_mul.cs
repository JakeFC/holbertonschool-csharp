using System;

///<summary>Defines functions for matrices.</summary>
class MatrixMath
{
	///<summary>Multiplies a matrix and scalar.</summary>
	///<param name="matrix">Matrix to be multiplied.</param>
	///<param name="scalar">Number to multiply by.</param>
	///<returns>The new matrix, or -1 if not 2D or 3D matrix.</returns>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		int upper0 = matrix.GetUpperBound(0);
		int upper1 = matrix.GetUpperBound(1);
		if (upper0 < 1 || upper0 > 2 || upper0 != upper1)
			return new double[,]{{-1},};
		for (int i = 0; i <= matrix.GetUpperBound(0); i++)
		{
			for (int j = 0; j <= matrix.GetUpperBound(1); j++)
			{
				matrix[i, j] *= scalar;
			}
		}
		return matrix;
	}
}
