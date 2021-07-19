using System;
using System.Collections.Generic;

class List
{
    // Divides 2 lists
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        var resList = new List<int>();
        for (int i = 0; i < listLength; i++)
        {
            int res = 0;
            try
            {
                res = list1[i] / list2[i];
                resList.Add(res);
            }
            catch (DivideByZeroException)
            {
                resList.Add(res);
                Console.WriteLine("Cannot divide by zero");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                break;
            }
        }
        return resList;
    }
}