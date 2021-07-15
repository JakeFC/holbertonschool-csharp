using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sorted = new SortedList<string, string> ();
        foreach (string key in myDict.Keys)
            sorted[key] = myDict[key];
        foreach (string key in sorted.Keys)
            Console.WriteLine("{0}: {1}", key, sorted[key]);
    }
}