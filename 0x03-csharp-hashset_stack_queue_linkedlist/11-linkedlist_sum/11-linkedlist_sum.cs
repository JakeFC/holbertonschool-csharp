using System;
using System.Collections.Generic;

class LList
{
    // Returns the sum of all the data of a LinkedList.
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        foreach (int x in myLList)
            sum += x;
        return sum;
    }
}