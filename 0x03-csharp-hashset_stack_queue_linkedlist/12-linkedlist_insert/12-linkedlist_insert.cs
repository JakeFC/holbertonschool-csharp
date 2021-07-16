using System;
using System.Collections.Generic;

class LList
{
    // Inserts a new node in the correct position in an ordered LinkedList and returns it.
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        if (current == null)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }
        LinkedListNode<int> previous = null;
        foreach (int x in myLList)
            {
                if (n < x)
                    break;
                previous = current;
                current = current.Next;
            }
        myLList.AddAfter(previous, n);
        return myLList.Find(n);
    }
}