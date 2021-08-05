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
		this.name = "Door";
	}
	///<summary>Initializes a Door with given name.</summary>
	public Door(string nameInput)
	{
		this.name = nameInput;
	}

	///<summary>Defines interaction.</summary>
	public void Interact()
	{
		Console.WriteLine(String.Format("You try to open the {0}. It's locked.", name));
	}
}

///<summary>Child class of Base implementing IInteractive and IBreakable interfaces.</summary>
public class Decoration : Base, IInteractive, IBreakable
{
	///<summary>QuestItem status of Decoration.</summary>
	public bool isQuestItem { get; set; }
	///<summary>Durability of Decoration.</summary>
	public int durability { get; set; }

	///<summary>Initializes a Decoration with name, durability, and isQuestItem as either input or default values.</summary>
	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		this.name = name;
		if (durability <= 0)
			throw new Exception("Durability must be greater than 0");
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}

	///<summary>Prints a string, based on durability and QuestItem status of the object.</summary>
	public void Interact()
	{
		if (durability <= 0)
			Console.WriteLine(String.Format("The {0} has been broken.", this.name));
		else if (isQuestItem)
			Console.WriteLine(String.Format("You look at the {0}. There's a key inside.", this.name));
		else
			Console.WriteLine(String.Format("You look at the {0}. Not much to see here.", this.name));
	}

	///<summary>Decrements durability by 1 and prints a relevant string based on the value.</summary>
	public void Break()
	{
		this.durability -= 1;
		if (durability > 0)
			Console.WriteLine(String.Format("You hit the {0}. It cracks.", this.name));
		if (durability == 0)
			Console.WriteLine(String.Format("You smash the {0}. What a mess.", this.name));
		if (durability < 0)
			Console.WriteLine(String.Format("The {0} is already broken.", this.name));
	}
}

///<summary>Child class of Base, which implements the ICollectable interface.</summary>
public class Key : Base, ICollectable
{
	///<summary>Collected status of object.</summary>
	public bool isCollected { get; set; }

	///<summary>Instantiates a Key with optional name and isCollected values, or defaults.</summary>
	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}

	///<summary>Prints a relevant string based on isCollected status and changes status if not previously true.</summary>
	public void Collect()
	{
		if (isCollected)
			Console.WriteLine(String.Format("You have already picked up the {0}.", name));
		else
		{
			Console.WriteLine(String.Format("You pick up the {0}.", name));
			this.isCollected = true;
		}
	}
}
