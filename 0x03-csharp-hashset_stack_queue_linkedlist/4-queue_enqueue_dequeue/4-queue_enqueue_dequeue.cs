using System;
using System.Collections.Generic;

class MyQueue
{
    // Prints the number of items in aQueue, the item at the top of aQueue without removing it,
    // and if aQueue contains a given item search. Adds a new item newItem to aQueue and removes
    // all items up to and including search if it is found.
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count > 0)
            Console.WriteLine("First item: {0}", aQueue.Peek());
        else
            Console.WriteLine("Queue is empty");
        aQueue.Enqueue(newItem);
        bool contains = aQueue.Contains(search);
        bool stay = true;
        if (contains)
        {
            while (stay)
            {
                if (aQueue.Peek() == search)
                    stay = false;
                aQueue.Dequeue();
            }
        }
        Console.WriteLine("Queue contains \"{0}\": {1}", search, contains);
        return aQueue;
    }
}