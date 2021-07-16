using System;
using System.Collections.Generic;

class MyStack
{
    // Prints the number of items in aStack, the item at the top of aStack without removing it,
    // and if aStack contains a given item search. If aStack contains the given item search,
    // remove all items up to and including search. Return the stack. Add a new given item newItem to aStack
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        Console.WriteLine("Top item: {0}", aStack.Peek());
        bool contains = aStack.Contains(search);
        bool stay = true;
        if (contains)
        {
            while (stay)
            {
                if (aStack.Peek() == search)
                    stay = false;
                aStack.Pop();
            }
        }
        Console.WriteLine("Stack contains \"{0}\": {1}", search, contains);
        aStack.Push(newItem);
        return aStack;
    }
}