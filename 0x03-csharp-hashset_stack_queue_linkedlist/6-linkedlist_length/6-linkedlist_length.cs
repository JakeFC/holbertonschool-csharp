using System;
using System.Collections.Generic;

class LList
{
    // Returns the number of elements in a LinkedList.
    public static int Length(LinkedList<int> myLList)
    {
        LinkedListNode<int> current = myLList.First;
        int count = 0;
        while (current != null)
            {
                current = current.Next;
                count++;
            }
        return count;
    }
}