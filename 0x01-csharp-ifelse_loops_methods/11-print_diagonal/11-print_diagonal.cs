using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 0; length > 0; length--, i++)
        {
            for (int j = i; j > 0; j--)
                Console.Write(' ');
            Console.WriteLine('\\');
        }
        Console.WriteLine("");
    }
}