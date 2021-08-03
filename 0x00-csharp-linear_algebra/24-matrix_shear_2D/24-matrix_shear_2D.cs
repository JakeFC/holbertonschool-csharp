using System;

///<summary>Defines functions for matrices.</summary>
class MatrixMath
{
	///<summary>Shears a square 2D matrix in given direction by given factor.</summary>
	///<param name="matrix">2D matrix input.</param>
	///<param name="direction">Direction in which to shear.</param>
	///<param name="factor">Shear factor.</param>
	///<returns>The resulting matrix, or one containg -1 if invalid size.</returns>
	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		int limitY = matrix.GetUpperBound(0);
		int limitX = matrix.GetUpperBound(1);
		if (limitX != 1 || (direction != 'x') && (direction != 'y'))
			return new double[,]{{-1},};
		var shear = new double[2, 2]{{1, 0}, {0, 1}};
		var result = new double[limitY + 1, 2];
		if (direction == 'x')
			shear[1, 0] = factor;
		else
			shear[0, 1] = factor;
		for (int y = 0; y <= limitY; y++)
		{
			for (int x = 0; x < 2; x++)
			{
				double total = 0;
				for (int i = 0; i <= limitX; i++)
				{
					total += Math.Round(matrix[y, i] * shear[i, x], 2);
				}
				result[y, x] = Math.Round(total, 2);
			}
		}
		return result;
	}
}
