using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        var lst = new List<int>();
        int i = 0;
        for (; i < size - 1; i++)
        {
            lst.Add(i);
            Console.Write(i.ToString() + " ");
        }
        if (size > 0)
        {
            lst.Add(i);
            Console.Write(i);
        }
        Console.WriteLine();
        return lst;
    }
}