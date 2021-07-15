using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        for (int y = 0; y < myMatrix.GetLength(0); y++)
        {
            for (int x = 0; x < myMatrix.GetLength(1); x++)
            {
                myMatrix[y, x] *= myMatrix[y, x];
            }
        }
        return myMatrix;
    }
}