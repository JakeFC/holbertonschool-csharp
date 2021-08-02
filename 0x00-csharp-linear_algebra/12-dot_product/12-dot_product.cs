using System;

///<summary>Defines vector functions.</summary>
class VectorMath
{
	///<summary>Calculates the dot product of two 2D vectors or two 3D vectors.</summary>
	///<param name="vector1">First vector input.</param>
	///<param name="vector2">Second vector input.</param>
	///<returns>The dot product, or -1 if vectors are not both 2D or both 3D.</returns>
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length != vector2.Length || vector1.Length < 2 || vector2.Length > 3)
		{
			return -1;
		}
		double result = 0;
		for (int i = 0; i < vector1.Length; i++)
		{
			result += vector1[i] * vector2[i];
		}
		return result;
	}
}
