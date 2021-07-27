using System;

class Obj
{
    ///<summary>Checks whether derivedType is a subclass of baseType.</summary>
    ///<param name="derivedType">Potential subclass to be checked.</param>
    ///<param name="baseType">Parent class to be checked against.</param>
    ///<returns>True if subclass, otherwise false.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}