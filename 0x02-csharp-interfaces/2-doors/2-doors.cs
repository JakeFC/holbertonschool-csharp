using System;

///<summary>Abstract class which defines a name and ToString() method.</summary>
public abstract class Base
{
	///<summary>Name of the object.</summary>
	public string name { get; set; }

	///<summary>Returns a string representation of the object.</summary>
	public override string ToString()
	{
		return String.Format("{0} is a {1}", name, this.GetType());
	}
}

///<summary>Contract specifying interaction.</summary>
public interface IInteractive
{
	///<summary>Defines interaction.</summary>
	void Interact();
}

///<summary>Contract specifying durability.</summary>
public interface IBreakable
{
	///<summary>Durability of object.</summary>
	int durability { get; set; }

	///<summary>Defines durability break.</summary>
	void Break();
}

///<summary>Contract specifying collectability.</summary>
public interface ICollectable
{
	///<summary>Collected status of object.</summary>
	bool isCollected { get; set; }

	///<summary>Defines collection.</summary>
	void Collect();
}

///<summary>Child class of Base implementing IInteractive interface.</summary>
public class Door : Base, IInteractive
{
	///<summary>Initializes a Door with default name "Door".</summary>
	public Door()
	{
		name = "Door";
	}
	///<summary>Initializes a Door with given name.</summary>
	public Door(string nameInput)
	{
		name = nameInput;
	}

	///<summary>Defines interaction.</summary>
	public void Interact()
	{
		Console.WriteLine(String.Format("You try to open the {0}. It's locked.", name));
	}
}
