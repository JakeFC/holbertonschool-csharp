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
		if (matrix1.Length != matrix2.Length || matrix1.Rank < 2 || matrix1.Rank > 3)
			return new double[,]{{-1}, {-1}};
		for (int i = 0; i < matrix1.Rank; i++)
		{
			if (matrix1.GetLength(i) != matrix2.GetLength(i) || matrix1.GetLength(i) != matrix1.Rank)
				return new double[,]{{-1}, {-1}};
			for (int j = 0; j < matrix1.GetLength(i); j++)
			{
				matrix1[i, j] += matrix2[i, j];
			}
		}
		return matrix1;
	}
}
