using System;
using System.Collections.Generic;

class LList
{
    // Returns the value of the nth node of a LinkedList.
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        for (int i = 0; current != null; current = current.Next, i++)
            {
                if (i == n)
                    return current.Value;
            }
        return 0;
    }
}