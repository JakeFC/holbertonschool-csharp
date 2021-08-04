using System;

///<summary>Abstract class which defines a name and ToString() method.</summary>
public abstract class Base
{
	///<summary>Name of the object.</summary>
	public string name;

	///<summary>Returns a string representation of the object.</summary>
	public override string ToString()
	{
		return String.Format("{0} is a {1}", name, this.GetType());
	}
}
