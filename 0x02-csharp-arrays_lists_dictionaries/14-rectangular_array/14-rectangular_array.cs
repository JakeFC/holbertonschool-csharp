using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[, ] arr = new int[5, 5];
        arr[2, 2] = 1;
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                Console.Write(arr[y, x].ToString());
                if (x < 4)
                    Console.Write(" ");
                else
                    Console.WriteLine();
            }
        }
    }
}