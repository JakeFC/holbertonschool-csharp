using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        var isEven = new List<bool>();
        foreach (int element in myList)
        {
            if (element % 2 == 0)
                isEven.Add(true);
            else
                isEven.Add(false);
        }
        return isEven;
    }
}