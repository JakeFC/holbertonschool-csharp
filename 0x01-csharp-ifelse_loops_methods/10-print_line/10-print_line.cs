using System;

class Line
{
    public static void PrintLine(int length)
    {
        for (; length > 0; length--)
            Console.Write('_');
        Console.WriteLine("");
    }
}