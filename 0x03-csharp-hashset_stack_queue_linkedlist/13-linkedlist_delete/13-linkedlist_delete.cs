using System;
using System.Collections.Generic;

class LList
{
    // Deletes the node at given position in a LinkedList.
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        foreach (int x in myLList)
        {
            if (i == index)
            {
                myLList.Remove(x);
                break;
            }
            i++;
        }
    }
}