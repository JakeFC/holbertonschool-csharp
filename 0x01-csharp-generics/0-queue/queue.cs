using System;
using System.Reflection;

///<summary>Custom generic class of Queue with type T.</summary>
public class Queue<T>
{
	///<summary>Returns the Queue's type.</summary>
	public Type CheckType()
	{
		return this.GetType().GetGenericArguments()[0];
	}
}
