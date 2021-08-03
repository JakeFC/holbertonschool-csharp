using System;

///<summary>Defines functions for matrices.</summary>
class MatrixMath
{
	///<summary>Rotates a square 2D matrix by given angle in radians.</summary>
	///<param name="matrix">2D matrix input.</param>
	///<param name="angle">Rotation angle in radians.</param>
	///<returns>The resulting matrix, or one containg -1 if invalid size.</returns>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		int limitY = matrix.GetUpperBound(0);
		int limitX = matrix.GetUpperBound(1);
		if (limitX != 1)
			return new double[,]{{-1},};
		var rotation = new double[2, 2]{{Math.Cos(angle), Math.Sin(angle)}, {-Math.Sin(angle), Math.Cos(angle)}};
		var result = new double[limitY + 1, 2];
		for (int y = 0; y <= limitY; y++)
		{
			for (int x = 0; x < 2; x++)
			{
				double total = 0;
				for (int i = 0; i <= limitX; i++)
				{
					total += Math.Round(matrix[y, i] * rotation[i, x], 2);
				}
				result[y, x] = Math.Round(total, 2);
			}
		}
		return result;
	}
}
