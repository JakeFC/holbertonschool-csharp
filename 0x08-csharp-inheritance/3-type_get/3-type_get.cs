using System;
using System.Reflection;

class Obj
{
    ///<summary>Prints the names of the available properties and methods of an object.</summary>
    ///<param name="myObj">Object input.</param>
    public static void Print(object myObj)
    {
        PropertyInfo[] properties = myObj.GetType().GetProperties();
        MethodInfo[] methods = myObj.GetType().GetMethods();
        Console.WriteLine(myObj.GetType().Name + " Properties:");
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine(property.Name);
        }
        Console.WriteLine(myObj.GetType().Name + " Methods:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}