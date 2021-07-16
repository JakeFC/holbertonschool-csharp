using System;
using System.Collections.Generic;

class LList
{
    // Inserts a new node in the correct position in an ordered LinkedList and returns it.
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        foreach (int x in myLList)
            {
                if (n < x)
                {
                    myLList.AddBefore(current, n);
                    return myLList.Find(n);
                }
                current = current.Next;
            }
        myLList.AddLast(n);
        return myLList.Last;
    }
}