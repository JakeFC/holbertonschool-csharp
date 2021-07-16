using System;
using System.Collections.Generic;

class LList
{
    // Finds a value in a LinkedList and returns its index position in the list.
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int i = 0;
        foreach (int x in myLList)
        {
            if (x == value)
                return i;
            i++;
        }
        return -1;
    }
}