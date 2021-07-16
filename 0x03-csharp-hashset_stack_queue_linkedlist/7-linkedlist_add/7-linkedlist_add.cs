using System;
using System.Collections.Generic;

class LList
{
    // Adds a node to the beginning of a LinkedList.
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        myLList.AddFirst(n);
        return myLList.First;
    }
}