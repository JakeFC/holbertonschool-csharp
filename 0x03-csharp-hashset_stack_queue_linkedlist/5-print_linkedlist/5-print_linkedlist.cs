using System;
using System.Collections.Generic;

class LList
{
    // Creates and prints a LinkedList of integers of a given size.
    public static LinkedList<int> CreatePrint(int size)
    {
        var linkly = new LinkedList<int>{};
        for (int i = 0; i < size; i++)
            {
                linkly.AddLast(i);
                Console.WriteLine(i);
            }
        return linkly;
    }
}