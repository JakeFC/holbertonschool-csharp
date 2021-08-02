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
		if (vector1.Length != vector2.Length || vector1.Length < 2 || vector2.Length > 3)
		{
			return new double[]{-1};
		}
		int length = vector1.Length;
		double[] result = new double[length];
		for (int i = 0; i < result.Length; i++)
		{
			result[i] = vector1[i] + vector2[i];
		}
		return result;
	}
}
