using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        var newList = new List<int> {};
        foreach (int a in list1)
        {
            if (list2.Contains(a))
                newList.Add(a);
        }
        newList.Sort();
        return newList;
    }
}