using System;

class Obj
{
    ///<summary>Checks if an object is an int.</summary>
    ///<param name="obj">Object input.</param>
    ///<returns>True if object, false otherwise.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return true;
        return false;
    }
}