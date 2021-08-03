using System;

///<summary>Defines Matrix functions.</summary>
class MatrixMath
{
	///<summary>Adds two matrices.</summary>
	///<param name="matrix1">First matrix input.</param>
	///<param name="matrix2">Second matrix input.</param>
	///<returns>The resulting matrix, or one containing -1 if they aren't both 2D or 3D.</returns>
	public static double[,] Add(double[,] matrix1, double[,] matrix2)
	{
		if (matrix1.Length != matrix2.Length || matrix1.GetUpperBound(0) < 1 || matrix.GetUpperBound(0) > 2)
			return new double[,]{{-1},};
		if (matrix1.GetUpperBound(0) != matrix1.GetUpperBound(1))
			return new double[,]{{-1},};
		for (int i = 0; i <= matrix1.GetUpperBound(0); i++)
		{
			for (int j = 0; j <= matrix2.GetUpperBound(1); j++)
			{
				matrix1[i, j] += matrix2[i, j];
			}
		}
		return matrix1;
	}
}
