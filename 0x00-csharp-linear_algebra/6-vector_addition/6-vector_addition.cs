using System;

///<summary>Defines vector functions.</summary>
class VectorMath
{
	///<summary>Adds two vectors.</summary>
	///<param name="vector1">First vector input.</param>
	///<param name="vector2">Second vector input.</param>
	///<returns>The resulting vector, or -1 if inputs are not 2D or 3D vectors.</returns>
	public static double[] Add(double[] vector1, double[] vector2)
	{
		if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3)
		{
			return new double[]{-1};
		}
		int length = Math.Max(vector1.Length, vector2.Length);
		double[] result = new double[length];
		result[0] = vector1[0] + vector2[0];
		result[1] = vector1[1] + vector2[1];
		if (length == 3)
		{
			if (vector1.Length == 2)
				result[2] = vector2[2];
			else if (vector2.Length == 2)
				result[2] = vector1[2];
			else
				result[2] = vector1[2] + vector2[2];
		}
		return result;
	}
}
