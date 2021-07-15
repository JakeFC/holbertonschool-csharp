using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jArr = new int[3][];
            jArr[0] = new int[4];
            jArr[1] = new int[7];
            jArr[2] = new int[2];
            for (int y = 0; y < jArr.Length; y++)
            {
                for (int x = 0; x < jArr[y].Length; x++)
                {
                    jArr[y][x] = x;
                    if (x < jArr[y].Length - 1)
                        Console.Write(jArr[y][x].ToString() + " ");
                    else
                        Console.WriteLine(jArr[y][x].ToString());
                }
            }
        }
    }
}
