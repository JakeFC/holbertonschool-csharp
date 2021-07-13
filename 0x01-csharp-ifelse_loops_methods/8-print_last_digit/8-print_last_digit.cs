using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int i = Math.Abs(number % 10);
        Console.Write(i);
        return (i);
    }
}