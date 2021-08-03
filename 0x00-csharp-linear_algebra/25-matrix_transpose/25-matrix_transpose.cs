using System;

///<summary>Defines functions for matrices.</summary>
class MatrixMath
{
	///<summary>Transposes (flips) a matrix.</summary>
	///<param name="matrix">Matrix of any dimension or size to be transposed.</param>
	///<returns>The resulting matrix</returns>
	public static double[,] Transpose(double[,] matrix)
	{
		int limitY = matrix.GetUpperBound(0);
		int limitX = matrix.GetUpperBound(1);
		var result = new double[limitX + 1, limitY + 1];
		for (int y = 0; y <= limitX; y++)
		{
			for (int x = 0; x<= limitY; x++)
				result[y, x] = matrix[x, y];
		}
		return result;
	}
}
