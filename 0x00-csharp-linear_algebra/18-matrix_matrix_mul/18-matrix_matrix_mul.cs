using System;

///<summary>Defines functions for matrices.</summary>
class MatrixMath
{
	///<summary>Multiplies two matrices.</summary>
	///<param name="matrix1">First matrix input.</param>
	///<param name="matrix2">Second matrix input.</param>
	///<returns>The resulting matrix, or one containg -1 if not possible.</returns>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		int mOneY = matrix1.GetUpperBound(0);
		int mOneX = matrix1.GetUpperBound(1);
		int mTwoY = matrix2.GetUpperBound(0);
		int mTwoX = matrix2.GetUpperBound(1);
		if (mOneX != mTwoY)
			return new double[,]{{-1},};
		var result = new double[mOneY + 1, mTwoX + 1];
		for (int y = 0; y <= mOneY; y++)
		{
			for (int x = 0; x <= mTwoX; x++)
			{
				double total = 0;
				for (int i = 0; i <= mOneX; i++)
				{
					total += matrix1[y, i] * matrix2[i, x];
				}
				result[y, x] = total;
			}
		}
		return result;
	}
}
