using System;
using System.Collections.Generic;

class List
{
    // Prints n elements of a list, if they exist, and returns the number
    // of elements printed
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;
        for (; i < n; i++)
        {
            try
            {
                Console.WriteLine(myList[i]);
            }
            catch (ArgumentOutOfRangeException)
            {
                return i;
            }
        }
        return i;
    }
}