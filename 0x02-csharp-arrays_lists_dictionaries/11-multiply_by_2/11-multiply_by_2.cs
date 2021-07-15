using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        var newDict = new Dictionary<string, int>();
        foreach (string key in myDict.Keys)
            newDict[key] = myDict[key] * 2;
        return newDict;
    }
}