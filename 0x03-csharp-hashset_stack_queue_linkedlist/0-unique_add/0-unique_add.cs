using System;
using System.Collections.Generic;

class List
{
    // adds all unique integers in a list
    public static int Sum(List<int> myList)
    {
        var set = new HashSet<int>(myList);
        int total = 0;
        foreach (int x in set)
            total += x;
        return total;
    }
}