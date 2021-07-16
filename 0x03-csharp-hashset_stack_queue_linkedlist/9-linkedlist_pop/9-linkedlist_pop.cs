using System;
using System.Collections.Generic;

class LList
{
    // Deletes the head node of a LinkedList and returns that node’s data.
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.First == null)
            return 0;
        return myLList.First.Value;
    }
}