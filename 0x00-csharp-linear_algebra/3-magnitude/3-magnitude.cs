using System;
using System.Math;

	///<summary>Defines vector functions.</summary>
    class VectorMath
    {
		///<summary>Finds the length of a 2D or 3D vector.</summary>
		///<param name="vector">Array coordinates of 2D or 3D vector.</param>
		///<returns>The length of the vector, or -1.</returns>
        public static double Magnitude(double[] vector)
        {
			double length;
            if (vector.Length < 2 || vector.Length > 3)
			{
				return -1;
			}
			foreach (double element in vector)
			{
				length += element * element;
			}
			return Math.Round(Math.Sqrt(length), 2);
        }
    }
}
