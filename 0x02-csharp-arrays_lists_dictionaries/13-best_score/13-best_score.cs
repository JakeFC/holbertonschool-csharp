using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string best = null;
        foreach (KeyValuePair<string, int> kvp in myList)
        {
            if (best == null || myList[best] < kvp.Value)
                best = kvp.Key;
        }
        return best;
    }
}