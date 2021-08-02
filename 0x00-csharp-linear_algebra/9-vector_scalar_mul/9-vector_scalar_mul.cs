using System;

///<summary>Defines vector functions.</summary>
class VectorMath
{
	///<summary>Multiplies a vector and scalar.</summary>
	///<param name="vector">Vector to be scaled.</param>
	///<param name="scalar">Scalar to multiply by.</param>
	///<returns>The new vector, or -1 if vector is not 2D or 3D.</returns>
	public static double[] Multiply(double[] vector, double scalar)
	{
		if (vector.Length < 2 || vector.Length > 3)
			return new double[]{-1};
		var result = new double[vector.Length];
		for (int i = 0; i < vector.Length; i++)
		{
			result[i] = vector[i] * scalar;
		}
		return result;
	}
}
