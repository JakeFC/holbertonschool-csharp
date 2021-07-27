using System;

class Obj
{
    ///<summary>Checks if object is an instance of a class that inherited from Array.</summary>
    ///<param name="obj">Object input.</param>
    ///<returns>True if obj inherited from Array, otherwise false.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}