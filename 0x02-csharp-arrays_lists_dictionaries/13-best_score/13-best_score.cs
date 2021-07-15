using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string best = "None";
        foreach (KeyValuePair<string, int> kvp in myList)
        {
            if (best == "None" || myList[best] < kvp.Value)
                best = kvp.Key;
        }
        return best;
    }
}